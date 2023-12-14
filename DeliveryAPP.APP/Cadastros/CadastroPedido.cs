using DeliveryAPP.APP.Base;
using DeliveryAPP.APP.Model;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Service.Validators;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace DeliveryAPP.APP.Cadastros
{
    public partial class CadastroPedido : CadastroBase
    {
        private List<ItemPedidoModel> _pedidoItems;
        private readonly IBaseService<Pedido> _pedidoService;
        private readonly IBaseService<Restaurante> _restauranteService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;

        private List<PedidoModel>? pedidos;

        public CadastroPedido(IBaseService<Pedido> pedidoService,
                             IBaseService<Restaurante> restauranteService,
                             IBaseService<Cliente> clienteService,
                             IBaseService<Produto> produtoService)
        {
            _pedidoService = pedidoService;
            _restauranteService = restauranteService;
            _clienteService = clienteService;
            _produtoService = produtoService;
            _pedidoItems = new List<ItemPedidoModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();
            Novo();
        }

        private void CarregarCombo()
        {
            comboRestaurante.ValueMember = "Id";
            comboRestaurante.DisplayMember = "Nome";
            comboRestaurante.DataSource = _restauranteService.Get<Restaurante>().ToList();

            comboCliente.ValueMember = "Id";
            comboCliente.DisplayMember = "Nome";
            comboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            comboProduto.ValueMember = "Id";
            comboProduto.DisplayMember = "Nome";
            comboProduto.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Pedido pedido)
        {
            if (DateTime.TryParse(txtData.Text, out var dataVenda))
            {
                pedido.Datacompra = dataVenda;
            }

            if (int.TryParse(comboRestaurante.SelectedValue.ToString(), out var idRestaurante))
            {
                var restaurante = _restauranteService.GetById<Restaurante>(idRestaurante);
                pedido.Restaurante = restaurante;
            }

            if (int.TryParse(comboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                pedido.Cliente = cliente;
            }
            pedido.Valortotal = _pedidoItems.Sum(x => x.Valortot);

            foreach (var item in _pedidoItems)
            {
                var itemPedido = new ItemPedido
                {
                    Pedido = pedido,
                    Produto = _produtoService.GetById<Produto>(item.IdProduto),
                    Valoruni= item.Valoruni,
                    Quantidade = item.Quantidade,
                    Valortot = item.Valortot
                };

                pedido.Item.Add(itemPedido);
            }

        }

        protected override void Novo()
        {
            base.Novo();
            _pedidoItems.Clear();
            CarregaGridItensVenda();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var pedido = _pedidoService.GetById<Pedido>(id);
                        PreencheObjeto(pedido);
                        pedido = _pedidoService.Update<Pedido, Pedido, PedidoValidator>(pedido);
                    }
                }
                else
                {
                    var pedido = new Pedido();
                    PreencheObjeto(pedido);
                    pedido = _pedidoService.Add<Pedido, Pedido, PedidoValidator>(pedido);
                }

                poisonTabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _pedidoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente", "Restaurante" };
            pedidos = _pedidoService.Get<PedidoModel>(includes).ToList();
            dataGridView1.DataSource = pedidos;
            dataGridView1.Columns["IdRestaurante"]!.Visible = false;
            dataGridView1.Columns["IdCliente"]!.Visible = false;
            dataGridView1.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            comboRestaurante.SelectedValue = linha?.Cells["IdRestaurante"].Value;
            comboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            txtData.Text = DateTime.TryParse(linha?.Cells["Datacompra"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

            var includes = new List<string>() { "Cliente", "Restaurante", "Item", "Item.Produto" };
            var pedido = _pedidoService.GetById<Pedido>(id, includes);
            _pedidoItems = new List<ItemPedidoModel>();
            foreach (var item in pedido.Item)
            {
                var pedidoItem = new ItemPedidoModel
                {
                    Id = item.Id,
                    IdProduto = item.Produto!.Id,
                    Produto = item.Produto!.Nome,
                    Valortot = item.Valortot,
                    Quantidade = item.Quantidade,
                    Valoruni = item.Valoruni
                };
                _pedidoItems.Add(pedidoItem);
            }
            CarregaGridItensVenda();

        }

        private void CarregaGridItensVenda()
        {
            var source = new BindingSource();
            source.DataSource = _pedidoItems.ToArray();
            dataGridView2.DataSource = source;
            dataGridView2.Columns["Id"]!.Visible = false;
            dataGridView2.Columns["IdProduto"]!.HeaderText = @"Id.Produto";
            dataGridView2.Columns["Valoruni"]!.DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Valoruni"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["Valortot"]!.DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Valortot"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var pedidoItem = new ItemPedidoModel();
                if (int.TryParse(comboProduto.SelectedValue.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    pedidoItem.IdProduto = produto.Id;
                    pedidoItem.Produto = produto.Nome;
                }

                if (float.TryParse(txtVluni.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var vlUnitario))
                {
                    pedidoItem.Valoruni = vlUnitario;
                }
                if (int.TryParse(txtqtd.Text, out var qtd))
                {
                    pedidoItem.Quantidade = qtd;
                }

                pedidoItem.Valortot = pedidoItem.Quantidade * pedidoItem.Valoruni;

                _pedidoItems.Add(pedidoItem);
                CalculaTotalVenda();
                CarregaGridItensVenda();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

        private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtVluni.Text, out double value))
                txtVluni.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtVluni.Text = string.Empty;

            CalculaTotalItem();
        }

        private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(txtVluni.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(txtqtd.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * vlUnitario;
                txtVlTot.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalculaTotalVenda()
        {
             var valorTotal = $@"Valor Total: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _pedidoItems.Sum(x => x.Valortot))}";
             txtVlTot.Text= $@"Qtd. Produtos: {_pedidoItems.Sum(x => x.Quantidade)}";
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }
    }
}
