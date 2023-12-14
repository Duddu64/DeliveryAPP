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
            this.formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formMenuStrip1
            // 
            this.formMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.formMenuStrip1.Location = new System.Drawing.Point(3, 64);
            this.formMenuStrip1.Name = "formMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.formMenuStrip1.Renderer = controlRenderer1;
            this.formMenuStrip1.Size = new System.Drawing.Size(593, 24);
            this.formMenuStrip1.TabIndex = 0;
            this.formMenuStrip1.Text = "formMenuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCidadeToolStripMenuItem,
            this.cadastroDeClienteToolStripMenuItem,
            this.cadastroDePedidoToolStripMenuItem,
            this.cadastroDeProdutoToolStripMenuItem,
            this.cadastroDeRestauranteToolStripMenuItem,
            this.cadastroDeCategoriaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeCidadeToolStripMenuItem
            // 
            this.cadastroDeCidadeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDeCidadeToolStripMenuItem.Name = "cadastroDeCidadeToolStripMenuItem";
            this.cadastroDeCidadeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeCidadeToolStripMenuItem.Text = "Cadastro de Cidade";
            this.cadastroDeCidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCidadeToolStripMenuItem_Click);
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente";
            this.cadastroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClienteToolStripMenuItem_Click);
            // 
            // cadastroDePedidoToolStripMenuItem
            // 
            this.cadastroDePedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDePedidoToolStripMenuItem.Name = "cadastroDePedidoToolStripMenuItem";
            this.cadastroDePedidoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDePedidoToolStripMenuItem.Text = "Cadastro de Pedido";
            this.cadastroDePedidoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePedidoToolStripMenuItem_Click);
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutoToolStripMenuItem_Click);
            // 
            // cadastroDeRestauranteToolStripMenuItem
            // 
            this.cadastroDeRestauranteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDeRestauranteToolStripMenuItem.Name = "cadastroDeRestauranteToolStripMenuItem";
            this.cadastroDeRestauranteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeRestauranteToolStripMenuItem.Text = "Cadastro de Restaurante";
            this.cadastroDeRestauranteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeRestauranteToolStripMenuItem_Click);
            // 
            // cadastroDeCategoriaToolStripMenuItem
            // 
            this.cadastroDeCategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cadastroDeCategoriaToolStripMenuItem.Name = "cadastroDeCategoriaToolStripMenuItem";
            this.cadastroDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastroDeCategoriaToolStripMenuItem.Text = "Cadastro de Categoria";
            this.cadastroDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(599, 460);
            this.Controls.Add(this.formMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.formMenuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery APP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.formMenuStrip1.ResumeLayout(false);
            this.formMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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