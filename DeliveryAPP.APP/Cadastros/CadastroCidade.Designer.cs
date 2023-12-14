namespace DeliveryAPP.APP.Cadastros
{
    partial class CadastroCidade
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
            comboUF = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            poisonTabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.None;
            btnDel.Location = new Point(627, 14);
            btnDel.Click += btnDel_Click;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Size = new Size(778, 215);
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(txtId);
            tabCadastro.Controls.Add(comboUF);
            tabCadastro.Controls.Add(txtName);
            tabCadastro.Location = new Point(4, 41);
            tabCadastro.Size = new Size(770, 170);
            tabCadastro.Controls.SetChildIndex(txtName, 0);
            tabCadastro.Controls.SetChildIndex(comboUF, 0);
            tabCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(489, 10);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(626, 10);
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Location = new Point(487, 14);
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.None;
            btnNew.Location = new Point(347, 14);
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
            txtName.Location = new Point(21, 25);
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
            txtName.Size = new Size(452, 48);
            txtName.TabIndex = 1;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // comboUF
            // 
            comboUF.AutoResize = false;
            comboUF.BackColor = Color.FromArgb(255, 255, 255);
            comboUF.Depth = 0;
            comboUF.DrawMode = DrawMode.OwnerDrawVariable;
            comboUF.DropDownHeight = 174;
            comboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUF.DropDownWidth = 121;
            comboUF.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboUF.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboUF.FormattingEnabled = true;
            comboUF.IntegralHeight = false;
            comboUF.ItemHeight = 43;
            comboUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboUF.Location = new Point(479, 25);
            comboUF.MaxDropDownItems = 4;
            comboUF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(135, 49);
            comboUF.StartIndex = 0;
            comboUF.TabIndex = 2;
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
            txtId.Location = new Point(620, 26);
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
            txtId.Size = new Size(140, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 282);
            Name = "CadastroCidade";
            Text = "CadastroCidade";
            TransparencyKey = Color.Empty;
            poisonTabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox comboUF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}