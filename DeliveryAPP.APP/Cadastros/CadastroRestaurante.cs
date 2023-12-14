using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryAPP.APP.Base;
using DeliveryAPP.APP.Model;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Service.Validators;
using ReaLTaiizor.Controls;


namespace DeliveryAPP.APP.Cadastros
{
    public partial class CadastroRestaurante : CadastroBase
    {
        private readonly IBaseService<Restaurante> _restauranteService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<RestauranteModel>? restaurantes;
        public CadastroRestaurante(IBaseService<Restaurante> restauranteService, IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            _restauranteService = restauranteService;
            InitializeComponent();
            CarregarCombo();
        }


        private void CarregarCombo()
        {
            comboCidade.ValueMember = "Id";
            comboCidade.DisplayMember = "Nome";
            comboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Restaurante restaurante)
        {
            restaurante.Nome = txtName.Text;
            restaurante.Endereco = txtAdress.Text;

            if (int.TryParse(comboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                restaurante.Cidade = cidade;
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
                        var restaurante = _restauranteService.GetById<Restaurante>(id);
                        PreencheObjeto(restaurante);
                        _restauranteService.Update<Restaurante, Restaurante, RestauranteValidator>(restaurante);
                    }
                }
                else
                {
                    var restaurante = new Restaurante();
                    PreencheObjeto(restaurante);
                    _restauranteService.Add<Restaurante, Restaurante, RestauranteValidator>(restaurante);

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
                _restauranteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            restaurantes = _restauranteService.Get<RestauranteModel>(new[] { "Cidade" }).ToList();
            dataGridView1.DataSource = restaurantes;
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
