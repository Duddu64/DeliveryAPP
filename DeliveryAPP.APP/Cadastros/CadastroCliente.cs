using DeliveryAPP.APP.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DeliveryAPP.APP.Model;

namespace DeliveryAPP.APP.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ClienteModel>? clientes;

        public CadastroCliente(IBaseService<Cliente> clienteService, IBaseService<Cidade> cidadeService)
        {
            _clienteService = clienteService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            comboCidade.ValueMember = "ID";
            comboCidade.DisplayMember = "NomeEstado";
            comboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtName.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtAdress.Text;

            if (int.TryParse(comboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                cliente.Cidade = cidade;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cliente = _cidadeService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);

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
                _cidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<ClienteModel>(new[] { "Cidade" }).ToList();
            dataGridView1.DataSource = clientes;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();
            txtAdress.Text = linha?.Cells["Endereco"].Value.ToString();
            comboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;
        }
    }
}
