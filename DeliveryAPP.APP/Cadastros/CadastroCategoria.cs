using DeliveryAPP.APP.Base;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryAPP.APP.Cadastros
{
    public partial class CadastroCategoria : CadastroBase
    {
        private readonly IBaseService<Categoria> _categoriaService;

        private List<Categoria>? categorias;
        public CadastroCategoria(IBaseService<Categoria> categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }
        private void PreencheObjeto(Categoria catgoria)
        {
            catgoria.Nome = txtName.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var catgoria = _categoriaService.GetById<Categoria>(id);
                        PreencheObjeto(catgoria);
                        catgoria = _categoriaService.Update<Categoria, Categoria, CategoriaValidator>(catgoria);
                    }
                }
                else
                {
                    var catgoria = new Categoria();
                    PreencheObjeto(catgoria);
                    _categoriaService.Add<Categoria, Categoria, CategoriaValidator>(catgoria);
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
                _categoriaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            categorias = _categoriaService.Get<Categoria>().ToList();
            dataGridView1.DataSource = categorias;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();
        }
    }
}
