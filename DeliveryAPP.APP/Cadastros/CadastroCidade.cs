using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using DeliveryAPP.APP.Base;

namespace DeliveryAPP.APP.Cadastros
{
    public partial class CadastroCidade : CadastroBase
    {
        private readonly IBaseService<Cidade> _cidadeService;
        private List<Cidade>? cidades;

        public CadastroCidade(IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void PreencheObjeto(Cidade cidade)
        {
            cidade.Nome = txtName.Text;
            cidade.Estado = comboUF.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cidade = _cidadeService.GetById<Cidade>(id);
                        PreencheObjeto(cidade);
                        cidade = _cidadeService.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    }
                }
                else
                {
                    var cidade = new Cidade();
                    PreencheObjeto(cidade);
                    _cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);

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
            cidades = _cidadeService.Get<Cidade>().ToList();
            dataGridView1.DataSource = cidades;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();
            comboUF.Text = linha?.Cells["Estado"].Value.ToString();
        }
    }
}
