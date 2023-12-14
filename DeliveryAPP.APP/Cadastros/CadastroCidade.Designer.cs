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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCidade));
            this.txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.comboUF = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.poisonTabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Size = new System.Drawing.Size(778, 215);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.txtId);
            this.tabCadastro.Controls.Add(this.comboUF);
            this.tabCadastro.Controls.Add(this.txtName);
            this.tabCadastro.Location = new System.Drawing.Point(4, 41);
            this.tabCadastro.Size = new System.Drawing.Size(770, 170);
            this.tabCadastro.Controls.SetChildIndex(this.txtName, 0);
            this.tabCadastro.Controls.SetChildIndex(this.comboUF, 0);
            this.tabCadastro.Controls.SetChildIndex(this.txtId, 0);
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
            this.txtName.Location = new System.Drawing.Point(21, 25);
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
            this.txtName.Size = new System.Drawing.Size(452, 48);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // comboUF
            // 
            this.comboUF.AutoResize = false;
            this.comboUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboUF.Depth = 0;
            this.comboUF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboUF.DropDownHeight = 174;
            this.comboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUF.DropDownWidth = 121;
            this.comboUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboUF.FormattingEnabled = true;
            this.comboUF.IntegralHeight = false;
            this.comboUF.ItemHeight = 43;
            this.comboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboUF.Location = new System.Drawing.Point(479, 25);
            this.comboUF.MaxDropDownItems = 4;
            this.comboUF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(135, 49);
            this.comboUF.StartIndex = 0;
            this.comboUF.TabIndex = 2;
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
            this.txtId.Location = new System.Drawing.Point(620, 26);
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
            this.txtId.Size = new System.Drawing.Size(140, 48);
            this.txtId.TabIndex = 3;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 282);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cidade";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.poisonTabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox comboUF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}