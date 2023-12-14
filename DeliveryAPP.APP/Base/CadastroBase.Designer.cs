namespace DeliveryAPP.APP.Base
{
    partial class CadastroBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            this.poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNew = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit = new ReaLTaiizor.Controls.ParrotButton();
            this.btnDel = new ReaLTaiizor.Controls.ParrotButton();
            this.poisonTabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.poisonTabControl1.Controls.Add(this.tabCadastro);
            this.poisonTabControl1.Controls.Add(this.tabConsulta);
            this.poisonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonTabControl1.Location = new System.Drawing.Point(3, 64);
            this.poisonTabControl1.Name = "poisonTabControl1";
            this.poisonTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.poisonTabControl1.SelectedIndex = 0;
            this.poisonTabControl1.Size = new System.Drawing.Size(672, 327);
            this.poisonTabControl1.TabIndex = 0;
            this.poisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.poisonTabControl1.UseSelectable = true;
            this.poisonTabControl1.Enter += new System.EventHandler(this.tabPageConsulta_Enter);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.panel1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 41);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(664, 282);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ButtonImage")));
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "Cancelar";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.Red;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.Black;
            this.btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(387, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 50);
            this.btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ButtonImage")));
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Salvar";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.Black;
            this.btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(524, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 50);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.dataGridView1);
            this.tabConsulta.Controls.Add(this.panel2);
            this.tabConsulta.Location = new System.Drawing.Point(4, 41);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(664, 282);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 209);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ButtonImage")));
            this.btnNew.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnNew.ButtonText = "Novo";
            this.btnNew.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnNew.ClickTextColor = System.Drawing.Color.Red;
            this.btnNew.CornerRadius = 5;
            this.btnNew.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNew.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnNew.HoverTextColor = System.Drawing.Color.Black;
            this.btnNew.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnNew.Location = new System.Drawing.Point(238, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 50);
            this.btnNew.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNew.TabIndex = 2;
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNew.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNew.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ButtonImage")));
            this.btnEdit.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "Editar";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.Red;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(378, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 50);
            this.btnEdit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ButtonImage")));
            this.btnDel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDel.ButtonText = "Excluir";
            this.btnDel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDel.ClickTextColor = System.Drawing.Color.Red;
            this.btnDel.CornerRadius = 5;
            this.btnDel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDel.HoverTextColor = System.Drawing.Color.Black;
            this.btnDel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDel.Location = new System.Drawing.Point(515, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(134, 50);
            this.btnDel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDel.TabIndex = 0;
            this.btnDel.TextColor = System.Drawing.Color.Black;
            this.btnDel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDel.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 394);
            this.Controls.Add(this.poisonTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 720);
            this.Name = "CadastroBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastroBase";
            this.poisonTabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabConsulta;
        private Panel panel2;
        protected ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        protected TabPage tabCadastro;
        private Panel panel1;
        protected DataGridView dataGridView1;
        private ReaLTaiizor.Controls.ParrotButton btnCancel;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.ParrotButton btnDel;
        private ReaLTaiizor.Controls.ParrotButton btnEdit;
        private ReaLTaiizor.Controls.ParrotButton btnNew;
    }
}