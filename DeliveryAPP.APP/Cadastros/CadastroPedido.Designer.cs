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
            this.txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.comboRestaurante = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtVluni = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            this.comboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.comboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtqtd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtVlTot = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.poisonTabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Size = new System.Drawing.Size(849, 410);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.dataGridView2);
            this.tabCadastro.Controls.Add(this.txtVlTot);
            this.tabCadastro.Controls.Add(this.txtqtd);
            this.tabCadastro.Controls.Add(this.comboProduto);
            this.tabCadastro.Controls.Add(this.txtId);
            this.tabCadastro.Controls.Add(this.comboCliente);
            this.tabCadastro.Controls.Add(this.parrotButton1);
            this.tabCadastro.Controls.Add(this.txtVluni);
            this.tabCadastro.Controls.Add(this.comboRestaurante);
            this.tabCadastro.Controls.Add(this.txtData);
            this.tabCadastro.Location = new System.Drawing.Point(4, 41);
            this.tabCadastro.Size = new System.Drawing.Size(841, 365);
            this.tabCadastro.Controls.SetChildIndex(this.txtData, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboRestaurante, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtVluni, 0);
            this.tabCadastro.Controls.SetChildIndex(this.parrotButton1, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboCliente, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboProduto, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtqtd, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtVlTot, 0);
            this.tabCadastro.Controls.SetChildIndex(this.dataGridView2, 0);
            // 
            // txtData
            // 
            this.txtData.AllowPromptAsInput = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AsciiOnly = false;
            this.txtData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtData.BeepOnError = false;
            this.txtData.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.HidePromptOnLeave = false;
            this.txtData.HideSelection = true;
            this.txtData.Hint = "Data Da Compra";
            this.txtData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(9, 6);
            this.txtData.Mask = "99/99/9999";
            this.txtData.MaxLength = 32767;
            this.txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PrefixSuffixText = null;
            this.txtData.PromptChar = '_';
            this.txtData.ReadOnly = false;
            this.txtData.RejectInputOnFirstFailure = false;
            this.txtData.ResetOnPrompt = true;
            this.txtData.ResetOnSpace = true;
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(196, 48);
            this.txtData.SkipLiterals = true;
            this.txtData.TabIndex = 1;
            this.txtData.TabStop = false;
            this.txtData.Text = "  /  /";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.TrailingIcon = null;
            this.txtData.UseSystemPasswordChar = false;
            this.txtData.ValidatingType = null;
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
            this.comboRestaurante.Location = new System.Drawing.Point(211, 6);
            this.comboRestaurante.MaxDropDownItems = 4;
            this.comboRestaurante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboRestaurante.Name = "comboRestaurante";
            this.comboRestaurante.Size = new System.Drawing.Size(430, 49);
            this.comboRestaurante.StartIndex = 0;
            this.comboRestaurante.TabIndex = 2;
            // 
            // txtVluni
            // 
            this.txtVluni.AnimateReadOnly = false;
            this.txtVluni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVluni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVluni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVluni.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVluni.Depth = 0;
            this.txtVluni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVluni.HideSelection = true;
            this.txtVluni.Hint = "Vl. Unit";
            this.txtVluni.LeadingIcon = null;
            this.txtVluni.Location = new System.Drawing.Point(211, 116);
            this.txtVluni.MaxLength = 32767;
            this.txtVluni.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtVluni.Name = "txtVluni";
            this.txtVluni.PasswordChar = '\0';
            this.txtVluni.PrefixSuffixText = null;
            this.txtVluni.ReadOnly = false;
            this.txtVluni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVluni.SelectedText = "";
            this.txtVluni.SelectionLength = 0;
            this.txtVluni.SelectionStart = 0;
            this.txtVluni.ShortcutsEnabled = true;
            this.txtVluni.Size = new System.Drawing.Size(138, 48);
            this.txtVluni.TabIndex = 3;
            this.txtVluni.TabStop = false;
            this.txtVluni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVluni.TrailingIcon = null;
            this.txtVluni.UseSystemPasswordChar = false;
            // 
            // parrotButton1
            // 
            this.parrotButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parrotButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton1.ButtonImage")));
            this.parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton1.ButtonText = "Button";
            this.parrotButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotButton1.ClickTextColor = System.Drawing.Color.Black;
            this.parrotButton1.CornerRadius = 5;
            this.parrotButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton1.HoverTextColor = System.Drawing.Color.Black;
            this.parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton1.Location = new System.Drawing.Point(635, 117);
            this.parrotButton1.Name = "parrotButton1";
            this.parrotButton1.Size = new System.Drawing.Size(200, 50);
            this.parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton1.TabIndex = 4;
            this.parrotButton1.TextColor = System.Drawing.Color.Black;
            this.parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.AutoResize = false;
            this.comboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCliente.Depth = 0;
            this.comboCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCliente.DropDownHeight = 174;
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.DropDownWidth = 121;
            this.comboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Hint = "Cliente";
            this.comboCliente.IntegralHeight = false;
            this.comboCliente.ItemHeight = 43;
            this.comboCliente.Location = new System.Drawing.Point(9, 61);
            this.comboCliente.MaxDropDownItems = 4;
            this.comboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(826, 49);
            this.comboCliente.StartIndex = 0;
            this.comboCliente.TabIndex = 5;
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
            this.txtId.Location = new System.Drawing.Point(647, 6);
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
            this.txtId.Size = new System.Drawing.Size(188, 48);
            this.txtId.TabIndex = 6;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // comboProduto
            // 
            this.comboProduto.AutoResize = false;
            this.comboProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboProduto.Depth = 0;
            this.comboProduto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboProduto.DropDownHeight = 174;
            this.comboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduto.DropDownWidth = 121;
            this.comboProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Hint = "Produto";
            this.comboProduto.IntegralHeight = false;
            this.comboProduto.ItemHeight = 43;
            this.comboProduto.Location = new System.Drawing.Point(9, 116);
            this.comboProduto.MaxDropDownItems = 4;
            this.comboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(196, 49);
            this.comboProduto.StartIndex = 0;
            this.comboProduto.TabIndex = 7;
            // 
            // txtqtd
            // 
            this.txtqtd.AnimateReadOnly = false;
            this.txtqtd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtqtd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtqtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtqtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtqtd.Depth = 0;
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtqtd.HideSelection = true;
            this.txtqtd.Hint = "Qtd";
            this.txtqtd.LeadingIcon = null;
            this.txtqtd.Location = new System.Drawing.Point(355, 116);
            this.txtqtd.MaxLength = 32767;
            this.txtqtd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.PasswordChar = '\0';
            this.txtqtd.PrefixSuffixText = null;
            this.txtqtd.ReadOnly = false;
            this.txtqtd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtqtd.SelectedText = "";
            this.txtqtd.SelectionLength = 0;
            this.txtqtd.SelectionStart = 0;
            this.txtqtd.ShortcutsEnabled = true;
            this.txtqtd.Size = new System.Drawing.Size(107, 48);
            this.txtqtd.TabIndex = 8;
            this.txtqtd.TabStop = false;
            this.txtqtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtqtd.TrailingIcon = null;
            this.txtqtd.UseSystemPasswordChar = false;
            // 
            // txtVlTot
            // 
            this.txtVlTot.AnimateReadOnly = false;
            this.txtVlTot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVlTot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVlTot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVlTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVlTot.Depth = 0;
            this.txtVlTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVlTot.HideSelection = true;
            this.txtVlTot.Hint = "Vl. Total";
            this.txtVlTot.LeadingIcon = null;
            this.txtVlTot.Location = new System.Drawing.Point(468, 117);
            this.txtVlTot.MaxLength = 32767;
            this.txtVlTot.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtVlTot.Name = "txtVlTot";
            this.txtVlTot.PasswordChar = '\0';
            this.txtVlTot.PrefixSuffixText = null;
            this.txtVlTot.ReadOnly = false;
            this.txtVlTot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVlTot.SelectedText = "";
            this.txtVlTot.SelectionLength = 0;
            this.txtVlTot.SelectionStart = 0;
            this.txtVlTot.ShortcutsEnabled = true;
            this.txtVlTot.Size = new System.Drawing.Size(161, 48);
            this.txtVlTot.TabIndex = 9;
            this.txtVlTot.TabStop = false;
            this.txtVlTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVlTot.TrailingIcon = null;
            this.txtVlTot.UseSystemPasswordChar = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 171);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(826, 132);
            this.dataGridView2.TabIndex = 10;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 477);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pedido";
            this.poisonTabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

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