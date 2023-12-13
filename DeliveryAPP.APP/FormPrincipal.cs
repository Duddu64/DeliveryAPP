using DeliveryAPP.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using DeliveryAPP.APP.Cadastros;
using DeliveryAPP.APP.Infra;
using ReaLTaiizor.Forms;
namespace DeliveryAPP.APP
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCategoria>();
        }

        private void cadastroDeRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroRestaurante>();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroProduto>();
        }

        private void cadastroDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPedido>();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCliente>();
        }

        private void cadastroDeCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCidade>();
        }

        private void Exibeformulario<Tform>() where Tform : Form
        {
            var cad = ConfigureDl.ServicesProvider!.GetService<Tform>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}