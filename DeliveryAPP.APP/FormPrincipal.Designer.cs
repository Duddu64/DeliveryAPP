using ReaLTaiizor.Forms;
namespace DeliveryAPP.APP
{
    partial class FormPrincipal: MaterialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeCidadeToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroDePedidoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeRestauranteToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeCategoriaToolStripMenuItem = new ToolStripMenuItem();
            formMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, sairToolStripMenuItem });
            formMenuStrip1.Location = new Point(3, 64);
            formMenuStrip1.Name = "formMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formMenuStrip1.Renderer = controlRenderer1;
            formMenuStrip1.Size = new Size(593, 24);
            formMenuStrip1.TabIndex = 0;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeCidadeToolStripMenuItem, cadastroDeClienteToolStripMenuItem, cadastroDePedidoToolStripMenuItem, cadastroDeProdutoToolStripMenuItem, cadastroDeRestauranteToolStripMenuItem, cadastroDeCategoriaToolStripMenuItem });
            cadastrosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastroDeCidadeToolStripMenuItem
            // 
            cadastroDeCidadeToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDeCidadeToolStripMenuItem.Name = "cadastroDeCidadeToolStripMenuItem";
            cadastroDeCidadeToolStripMenuItem.Size = new Size(202, 22);
            cadastroDeCidadeToolStripMenuItem.Text = "Cadastro de Cidade";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            cadastroDeClienteToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            cadastroDeClienteToolStripMenuItem.Size = new Size(202, 22);
            cadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente";
            // 
            // cadastroDePedidoToolStripMenuItem
            // 
            cadastroDePedidoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDePedidoToolStripMenuItem.Name = "cadastroDePedidoToolStripMenuItem";
            cadastroDePedidoToolStripMenuItem.Size = new Size(202, 22);
            cadastroDePedidoToolStripMenuItem.Text = "Cadastro de Pedido";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            cadastroDeProdutoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            cadastroDeProdutoToolStripMenuItem.Size = new Size(202, 22);
            cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            // 
            // cadastroDeRestauranteToolStripMenuItem
            // 
            cadastroDeRestauranteToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDeRestauranteToolStripMenuItem.Name = "cadastroDeRestauranteToolStripMenuItem";
            cadastroDeRestauranteToolStripMenuItem.Size = new Size(202, 22);
            cadastroDeRestauranteToolStripMenuItem.Text = "Cadastro de Restaurante";
            // 
            // cadastroDeCategoriaToolStripMenuItem
            // 
            cadastroDeCategoriaToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroDeCategoriaToolStripMenuItem.Name = "cadastroDeCategoriaToolStripMenuItem";
            cadastroDeCategoriaToolStripMenuItem.Size = new Size(202, 22);
            cadastroDeCategoriaToolStripMenuItem.Text = "Cadastro de Categoria";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 460);
            Controls.Add(formMenuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = formMenuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery APP";
            formMenuStrip1.ResumeLayout(false);
            formMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCidadeToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private ToolStripMenuItem cadastroDePedidoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeRestauranteToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCategoriaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}