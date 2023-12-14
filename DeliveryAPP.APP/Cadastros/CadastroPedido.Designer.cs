namespace DeliveryAPP.APP.Cadastros
{
    partial class CadastroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedido));
            txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            comboRestaurante = new ReaLTaiizor.Controls.MaterialComboBox();
            txtVluni = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            comboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            comboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            txtqtd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtVlTot = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dataGridView2 = new DataGridView();
            poisonTabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Location = new Point(548, 7);
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Size = new Size(849, 410);
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(dataGridView2);
            tabCadastro.Controls.Add(txtVlTot);
            tabCadastro.Controls.Add(txtqtd);
            tabCadastro.Controls.Add(comboProduto);
            tabCadastro.Controls.Add(txtId);
            tabCadastro.Controls.Add(comboCliente);
            tabCadastro.Controls.Add(parrotButton1);
            tabCadastro.Controls.Add(txtVluni);
            tabCadastro.Controls.Add(comboRestaurante);
            tabCadastro.Controls.Add(txtData);
            tabCadastro.Location = new Point(4, 41);
            tabCadastro.Size = new Size(841, 365);
            tabCadastro.Controls.SetChildIndex(txtData, 0);
            tabCadastro.Controls.SetChildIndex(comboRestaurante, 0);
            tabCadastro.Controls.SetChildIndex(txtVluni, 0);
            tabCadastro.Controls.SetChildIndex(parrotButton1, 0);
            tabCadastro.Controls.SetChildIndex(comboCliente, 0);
            tabCadastro.Controls.SetChildIndex(txtId, 0);
            tabCadastro.Controls.SetChildIndex(comboProduto, 0);
            tabCadastro.Controls.SetChildIndex(txtqtd, 0);
            tabCadastro.Controls.SetChildIndex(txtVlTot, 0);
            tabCadastro.Controls.SetChildIndex(dataGridView2, 0);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(918, 10);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1055, 10);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(688, 7);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(408, 7);
            // 
            // txtData
            // 
            txtData.AllowPromptAsInput = true;
            txtData.AnimateReadOnly = false;
            txtData.AsciiOnly = false;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.BeepOnError = false;
            txtData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HidePromptOnLeave = false;
            txtData.HideSelection = true;
            txtData.Hint = "Data Da Compra";
            txtData.InsertKeyMode = InsertKeyMode.Default;
            txtData.LeadingIcon = null;
            txtData.Location = new Point(9, 6);
            txtData.Mask = "99/99/9999";
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.PromptChar = '_';
            txtData.ReadOnly = false;
            txtData.RejectInputOnFirstFailure = false;
            txtData.ResetOnPrompt = true;
            txtData.ResetOnSpace = true;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(196, 48);
            txtData.SkipLiterals = true;
            txtData.TabIndex = 1;
            txtData.TabStop = false;
            txtData.Text = "  /  /";
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            txtData.ValidatingType = null;
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
            comboRestaurante.Location = new Point(211, 6);
            comboRestaurante.MaxDropDownItems = 4;
            comboRestaurante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboRestaurante.Name = "comboRestaurante";
            comboRestaurante.Size = new Size(430, 49);
            comboRestaurante.StartIndex = 0;
            comboRestaurante.TabIndex = 2;
            // 
            // txtVluni
            // 
            txtVluni.AnimateReadOnly = false;
            txtVluni.AutoCompleteMode = AutoCompleteMode.None;
            txtVluni.AutoCompleteSource = AutoCompleteSource.None;
            txtVluni.BackgroundImageLayout = ImageLayout.None;
            txtVluni.CharacterCasing = CharacterCasing.Normal;
            txtVluni.Depth = 0;
            txtVluni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVluni.HideSelection = true;
            txtVluni.Hint = "Vl. Unit";
            txtVluni.LeadingIcon = null;
            txtVluni.Location = new Point(211, 116);
            txtVluni.MaxLength = 32767;
            txtVluni.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVluni.Name = "txtVluni";
            txtVluni.PasswordChar = '\0';
            txtVluni.PrefixSuffixText = null;
            txtVluni.ReadOnly = false;
            txtVluni.RightToLeft = RightToLeft.No;
            txtVluni.SelectedText = "";
            txtVluni.SelectionLength = 0;
            txtVluni.SelectionStart = 0;
            txtVluni.ShortcutsEnabled = true;
            txtVluni.Size = new Size(138, 48);
            txtVluni.TabIndex = 3;
            txtVluni.TabStop = false;
            txtVluni.TextAlign = HorizontalAlignment.Left;
            txtVluni.TrailingIcon = null;
            txtVluni.UseSystemPasswordChar = false;
            // 
            // parrotButton1
            // 
            parrotButton1.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton1.ButtonImage = (Image)resources.GetObject("parrotButton1.ButtonImage");
            parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton1.ButtonText = "Button";
            parrotButton1.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton1.ClickTextColor = Color.Black;
            parrotButton1.CornerRadius = 5;
            parrotButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotButton1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton1.HoverTextColor = Color.Black;
            parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton1.Location = new Point(635, 117);
            parrotButton1.Name = "parrotButton1";
            parrotButton1.Size = new Size(200, 50);
            parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton1.TabIndex = 4;
            parrotButton1.TextColor = Color.Black;
            parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton1.Vertical_Alignment = StringAlignment.Center;
            // 
            // comboCliente
            // 
            comboCliente.AutoResize = false;
            comboCliente.BackColor = Color.FromArgb(255, 255, 255);
            comboCliente.Depth = 0;
            comboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            comboCliente.DropDownHeight = 174;
            comboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCliente.DropDownWidth = 121;
            comboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboCliente.FormattingEnabled = true;
            comboCliente.Hint = "Cliente";
            comboCliente.IntegralHeight = false;
            comboCliente.ItemHeight = 43;
            comboCliente.Location = new Point(9, 61);
            comboCliente.MaxDropDownItems = 4;
            comboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(826, 49);
            comboCliente.StartIndex = 0;
            comboCliente.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(647, 6);
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
            txtId.Size = new Size(188, 48);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // comboProduto
            // 
            comboProduto.AutoResize = false;
            comboProduto.BackColor = Color.FromArgb(255, 255, 255);
            comboProduto.Depth = 0;
            comboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            comboProduto.DropDownHeight = 174;
            comboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduto.DropDownWidth = 121;
            comboProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboProduto.FormattingEnabled = true;
            comboProduto.Hint = "Produto";
            comboProduto.IntegralHeight = false;
            comboProduto.ItemHeight = 43;
            comboProduto.Location = new Point(9, 116);
            comboProduto.MaxDropDownItems = 4;
            comboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboProduto.Name = "comboProduto";
            comboProduto.Size = new Size(196, 49);
            comboProduto.StartIndex = 0;
            comboProduto.TabIndex = 7;
            // 
            // txtqtd
            // 
            txtqtd.AnimateReadOnly = false;
            txtqtd.AutoCompleteMode = AutoCompleteMode.None;
            txtqtd.AutoCompleteSource = AutoCompleteSource.None;
            txtqtd.BackgroundImageLayout = ImageLayout.None;
            txtqtd.CharacterCasing = CharacterCasing.Normal;
            txtqtd.Depth = 0;
            txtqtd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtqtd.HideSelection = true;
            txtqtd.Hint = "Qtd";
            txtqtd.LeadingIcon = null;
            txtqtd.Location = new Point(355, 116);
            txtqtd.MaxLength = 32767;
            txtqtd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtqtd.Name = "txtqtd";
            txtqtd.PasswordChar = '\0';
            txtqtd.PrefixSuffixText = null;
            txtqtd.ReadOnly = false;
            txtqtd.RightToLeft = RightToLeft.No;
            txtqtd.SelectedText = "";
            txtqtd.SelectionLength = 0;
            txtqtd.SelectionStart = 0;
            txtqtd.ShortcutsEnabled = true;
            txtqtd.Size = new Size(107, 48);
            txtqtd.TabIndex = 8;
            txtqtd.TabStop = false;
            txtqtd.TextAlign = HorizontalAlignment.Left;
            txtqtd.TrailingIcon = null;
            txtqtd.UseSystemPasswordChar = false;
            // 
            // txtVlTot
            // 
            txtVlTot.AnimateReadOnly = false;
            txtVlTot.AutoCompleteMode = AutoCompleteMode.None;
            txtVlTot.AutoCompleteSource = AutoCompleteSource.None;
            txtVlTot.BackgroundImageLayout = ImageLayout.None;
            txtVlTot.CharacterCasing = CharacterCasing.Normal;
            txtVlTot.Depth = 0;
            txtVlTot.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVlTot.HideSelection = true;
            txtVlTot.Hint = "Vl. Total";
            txtVlTot.LeadingIcon = null;
            txtVlTot.Location = new Point(468, 117);
            txtVlTot.MaxLength = 32767;
            txtVlTot.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVlTot.Name = "txtVlTot";
            txtVlTot.PasswordChar = '\0';
            txtVlTot.PrefixSuffixText = null;
            txtVlTot.ReadOnly = false;
            txtVlTot.RightToLeft = RightToLeft.No;
            txtVlTot.SelectedText = "";
            txtVlTot.SelectionLength = 0;
            txtVlTot.SelectionStart = 0;
            txtVlTot.ShortcutsEnabled = true;
            txtVlTot.Size = new Size(161, 48);
            txtVlTot.TabIndex = 9;
            txtVlTot.TabStop = false;
            txtVlTot.TextAlign = HorizontalAlignment.Left;
            txtVlTot.TrailingIcon = null;
            txtVlTot.UseSystemPasswordChar = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 171);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(826, 132);
            dataGridView2.TabIndex = 10;
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 477);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            TransparencyKey = Color.Empty;
            poisonTabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVluni;
        private ReaLTaiizor.Controls.MaterialComboBox comboRestaurante;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox comboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVlTot;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtqtd;
        private ReaLTaiizor.Controls.MaterialComboBox comboProduto;
        private DataGridView dataGridView2;
    }
}