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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            comboRestaurante = new ReaLTaiizor.Controls.MaterialComboBox();
            comboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            poisonTabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Size = new Size(812, 457);
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(hopePictureBox1);
            tabCadastro.Controls.Add(comboCategoria);
            tabCadastro.Controls.Add(comboRestaurante);
            tabCadastro.Controls.Add(txtId);
            tabCadastro.Controls.Add(txtName);
            tabCadastro.Location = new Point(4, 41);
            tabCadastro.Size = new Size(804, 412);
            tabCadastro.Controls.SetChildIndex(txtName, 0);
            tabCadastro.Controls.SetChildIndex(txtId, 0);
            tabCadastro.Controls.SetChildIndex(comboRestaurante, 0);
            tabCadastro.Controls.SetChildIndex(comboCategoria, 0);
            tabCadastro.Controls.SetChildIndex(hopePictureBox1, 0);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(667, 10);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(804, 10);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Nome";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(6, 6);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(601, 48);
            txtName.TabIndex = 1;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(613, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(177, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // comboRestaurante
            // 
            comboRestaurante.AutoResize = false;
            comboRestaurante.BackColor = Color.FromArgb(255, 255, 255);
            comboRestaurante.Depth = 0;
            comboRestaurante.DrawMode = DrawMode.OwnerDrawVariable;
            comboRestaurante.DropDownHeight = 174;
            comboRestaurante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRestaurante.DropDownWidth = 121;
            comboRestaurante.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboRestaurante.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboRestaurante.FormattingEnabled = true;
            comboRestaurante.Hint = "Restaurante";
            comboRestaurante.IntegralHeight = false;
            comboRestaurante.ItemHeight = 43;
            comboRestaurante.Location = new Point(6, 60);
            comboRestaurante.MaxDropDownItems = 4;
            comboRestaurante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboRestaurante.Name = "comboRestaurante";
            comboRestaurante.Size = new Size(784, 49);
            comboRestaurante.StartIndex = 0;
            comboRestaurante.TabIndex = 3;
            // 
            // comboCategoria
            // 
            comboCategoria.AutoResize = false;
            comboCategoria.BackColor = Color.FromArgb(255, 255, 255);
            comboCategoria.Depth = 0;
            comboCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            comboCategoria.DropDownHeight = 174;
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.DropDownWidth = 121;
            comboCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Hint = "Categoria";
            comboCategoria.IntegralHeight = false;
            comboCategoria.ItemHeight = 43;
            comboCategoria.Location = new Point(6, 115);
            comboCategoria.MaxDropDownItems = 4;
            comboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(784, 49);
            comboCategoria.StartIndex = 0;
            comboCategoria.TabIndex = 4;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.White;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.InitialImage = null;
            hopePictureBox1.Location = new Point(311, 170);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(183, 170);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 5;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += hopePictureBox1_Click;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 524);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            TransparencyKey = Color.Empty;
            poisonTabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox comboCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox comboRestaurante;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}