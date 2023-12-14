namespace DeliveryAPP.APP.Cadastros
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.comboRestaurante = new ReaLTaiizor.Controls.MaterialComboBox();
            this.comboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.poisonTabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Size = new System.Drawing.Size(812, 457);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.hopePictureBox1);
            this.tabCadastro.Controls.Add(this.comboCategoria);
            this.tabCadastro.Controls.Add(this.comboRestaurante);
            this.tabCadastro.Controls.Add(this.txtId);
            this.tabCadastro.Controls.Add(this.txtName);
            this.tabCadastro.Location = new System.Drawing.Point(4, 41);
            this.tabCadastro.Size = new System.Drawing.Size(804, 412);
            this.tabCadastro.Controls.SetChildIndex(this.txtName, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboRestaurante, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboCategoria, 0);
            this.tabCadastro.Controls.SetChildIndex(this.hopePictureBox1, 0);
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.Hint = "Nome";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(6, 6);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(601, 48);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(613, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = false;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(177, 48);
            this.txtId.TabIndex = 2;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // comboRestaurante
            // 
            this.comboRestaurante.AutoResize = false;
            this.comboRestaurante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboRestaurante.Depth = 0;
            this.comboRestaurante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboRestaurante.DropDownHeight = 174;
            this.comboRestaurante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRestaurante.DropDownWidth = 121;
            this.comboRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboRestaurante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboRestaurante.FormattingEnabled = true;
            this.comboRestaurante.Hint = "Restaurante";
            this.comboRestaurante.IntegralHeight = false;
            this.comboRestaurante.ItemHeight = 43;
            this.comboRestaurante.Location = new System.Drawing.Point(6, 60);
            this.comboRestaurante.MaxDropDownItems = 4;
            this.comboRestaurante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboRestaurante.Name = "comboRestaurante";
            this.comboRestaurante.Size = new System.Drawing.Size(784, 49);
            this.comboRestaurante.StartIndex = 0;
            this.comboRestaurante.TabIndex = 3;
            // 
            // comboCategoria
            // 
            this.comboCategoria.AutoResize = false;
            this.comboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCategoria.Depth = 0;
            this.comboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCategoria.DropDownHeight = 174;
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.DropDownWidth = 121;
            this.comboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Hint = "Categoria";
            this.comboCategoria.IntegralHeight = false;
            this.comboCategoria.ItemHeight = 43;
            this.comboCategoria.Location = new System.Drawing.Point(6, 115);
            this.comboCategoria.MaxDropDownItems = 4;
            this.comboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(784, 49);
            this.comboCategoria.StartIndex = 0;
            this.comboCategoria.TabIndex = 4;
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.White;
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.InitialImage = null;
            this.hopePictureBox1.Location = new System.Drawing.Point(311, 170);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(183, 170);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 5;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopePictureBox1.Click += new System.EventHandler(this.hopePictureBox1_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 524);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.poisonTabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox comboCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox comboRestaurante;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}