namespace DeliveryAPP.APP.Cadastros
{
    partial class CadastroCliente
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAdress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            comboCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            poisonTabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Location = new Point(637, 7);
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Size = new Size(794, 293);
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(txtId);
            tabCadastro.Controls.Add(comboCidade);
            tabCadastro.Controls.Add(txtAdress);
            tabCadastro.Controls.Add(txtEmail);
            tabCadastro.Controls.Add(txtName);
            tabCadastro.Location = new Point(4, 41);
            tabCadastro.Size = new Size(786, 248);
            tabCadastro.Controls.SetChildIndex(txtName, 0);
            tabCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabCadastro.Controls.SetChildIndex(txtAdress, 0);
            tabCadastro.Controls.SetChildIndex(comboCidade, 0);
            tabCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(509, 10);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(646, 10);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(622, 6);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(360, 7);
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
            txtName.Size = new Size(596, 48);
            txtName.TabIndex = 1;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(6, 60);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(774, 48);
            txtEmail.TabIndex = 2;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtAdress
            // 
            txtAdress.AnimateReadOnly = false;
            txtAdress.AutoCompleteMode = AutoCompleteMode.None;
            txtAdress.AutoCompleteSource = AutoCompleteSource.None;
            txtAdress.BackgroundImageLayout = ImageLayout.None;
            txtAdress.CharacterCasing = CharacterCasing.Normal;
            txtAdress.Depth = 0;
            txtAdress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdress.HideSelection = true;
            txtAdress.Hint = "Endereço";
            txtAdress.LeadingIcon = null;
            txtAdress.Location = new Point(6, 114);
            txtAdress.MaxLength = 32767;
            txtAdress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAdress.Name = "txtAdress";
            txtAdress.PasswordChar = '\0';
            txtAdress.PrefixSuffixText = null;
            txtAdress.ReadOnly = false;
            txtAdress.RightToLeft = RightToLeft.No;
            txtAdress.SelectedText = "";
            txtAdress.SelectionLength = 0;
            txtAdress.SelectionStart = 0;
            txtAdress.ShortcutsEnabled = true;
            txtAdress.Size = new Size(456, 48);
            txtAdress.TabIndex = 3;
            txtAdress.TabStop = false;
            txtAdress.TextAlign = HorizontalAlignment.Left;
            txtAdress.TrailingIcon = null;
            txtAdress.UseSystemPasswordChar = false;
            // 
            // comboCidade
            // 
            comboCidade.AutoResize = false;
            comboCidade.BackColor = Color.FromArgb(255, 255, 255);
            comboCidade.Depth = 0;
            comboCidade.DrawMode = DrawMode.OwnerDrawVariable;
            comboCidade.DropDownHeight = 174;
            comboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCidade.DropDownWidth = 121;
            comboCidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboCidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboCidade.FormattingEnabled = true;
            comboCidade.Hint = "Cidade";
            comboCidade.IntegralHeight = false;
            comboCidade.ItemHeight = 43;
            comboCidade.Location = new Point(468, 114);
            comboCidade.MaxDropDownItems = 4;
            comboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboCidade.Name = "comboCidade";
            comboCidade.Size = new Size(312, 49);
            comboCidade.StartIndex = 0;
            comboCidade.TabIndex = 4;
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
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(608, 6);
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
            txtId.Size = new Size(172, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Name = "CadastroCliente";
            Text = "Cadastro";
            TransparencyKey = Color.Empty;
            poisonTabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox comboCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAdress;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}