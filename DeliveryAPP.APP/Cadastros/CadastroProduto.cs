using DeliveryAPP.APP.Base;
using DeliveryAPP.APP.Model;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Service.Validators;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class CadastroProduto : CadastroBase
    {
        private readonly IBaseService<Produto> _produtoService;
        private readonly IBaseService<Categoria> _categoriaService;
        private readonly IBaseService<Restaurante> _restauranteService;
        
        private List<ProdutoModel>? produtos;
        public CadastroProduto(IBaseService<Produto> produtoService, IBaseService<Categoria> categoriaService, IBaseService<Restaurante> restauranteService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
            _restauranteService = restauranteService;
            InitializeComponent();
            CarregarCombo();
        }
        private string Img = "";

        private void CarregarCombo()
        {
            comboCategoria.ValueMember = "Id";
            comboCategoria.DisplayMember = "Nome";
            comboCategoria.DataSource = _categoriaService.Get<Categoria>().ToList();
            comboRestaurante.ValueMember = "Id";
            comboRestaurante.DisplayMember = "Nome";
            comboRestaurante.DataSource = _restauranteService.Get<Restaurante>().ToList();
        }

        private void PreencheObjeto(Produto produto)
        {

            produto.Nome = txtName.Text;
            //byte[] fotoproduto= File.ReadAllBytes(Img);
            //produto.Foto = fotoproduto;
            if (int.TryParse(comboRestaurante.SelectedValue.ToString(), out var idGrupo))
            {
                var restaurante = _restauranteService.GetById<Restaurante>(idGrupo);
                produto.Restaurante = restaurante;
            }

            if (int.TryParse(comboCategoria.SelectedValue.ToString(), out var idGrupo2))
            {
                var categoria = _categoriaService.GetById<Categoria>(idGrupo2);
                produto.Categoria = categoria;
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
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
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
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delivery APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            produtos = _produtoService.Get<ProdutoModel>().ToList();
            dataGridView1.DataSource = produtos;
            //dataGridView1.Columns["Id"]!.Visible = false;

            dataGridView1.Columns["Foto"]!.Visible= false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();
            comboRestaurante.Text = linha?.Cells["Restaurante"].Value.ToString();
            comboCategoria.Text = linha?.Cells["Categoria"].Value.ToString();
        }
        
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap Resize = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(Resize))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                g.DrawImage(img, 0, 0, width, height);
            }

            return Resize;
        }
        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Img = openFileDialog.FileName;
                    Image IMG = Image.FromFile(Img);
                    Image IMGSel = ResizeImage(IMG, hopePictureBox1.Width, hopePictureBox1.Height);
                    hopePictureBox1.Image = IMGSel;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
