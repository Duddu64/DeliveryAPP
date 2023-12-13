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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabCadastro = new TabPage();
            panel1 = new Panel();
            btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            btnSave = new ReaLTaiizor.Controls.ParrotButton();
            tabConsulta = new TabPage();
            panel2 = new Panel();
            btnNew = new ReaLTaiizor.Controls.ParrotButton();
            btnEdit = new ReaLTaiizor.Controls.ParrotButton();
            btnDel = new ReaLTaiizor.Controls.ParrotButton();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            poisonTabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            panel1.SuspendLayout();
            tabConsulta.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Appearance = TabAppearance.Buttons;
            poisonTabControl1.Controls.Add(tabCadastro);
            poisonTabControl1.Controls.Add(tabConsulta);
            poisonTabControl1.Dock = DockStyle.Fill;
            poisonTabControl1.Location = new Point(3, 64);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(794, 383);
            poisonTabControl1.TabIndex = 0;
            poisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            poisonTabControl1.UseSelectable = true;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(panel1);
            tabCadastro.Location = new Point(4, 41);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(786, 338);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 83);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnCancel.ButtonImage = (Image)resources.GetObject("btnCancel.ButtonImage");
            btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnCancel.ButtonText = "Cancelar";
            btnCancel.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnCancel.ClickTextColor = Color.Red;
            btnCancel.CornerRadius = 5;
            btnCancel.Horizontal_Alignment = StringAlignment.Center;
            btnCancel.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnCancel.HoverTextColor = Color.Black;
            btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnCancel.Location = new Point(509, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 50);
            btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 1;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Vertical_Alignment = StringAlignment.Center;
            btnCancel.Click += btnCancelar_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnSave.ButtonImage = (Image)resources.GetObject("btnSave.ButtonImage");
            btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSave.ButtonText = "Salvar";
            btnSave.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSave.ClickTextColor = Color.DarkSlateGray;
            btnSave.CornerRadius = 5;
            btnSave.Horizontal_Alignment = StringAlignment.Center;
            btnSave.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSave.HoverTextColor = Color.Black;
            btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSave.Location = new Point(646, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 50);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 0;
            btnSave.TextColor = Color.Black;
            btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Vertical_Alignment = StringAlignment.Center;
            btnSave.Click += btnSalvar_Click;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(panel2);
            tabConsulta.Controls.Add(poisonDataGridView1);
            tabConsulta.Location = new Point(4, 38);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(786, 341);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDel);
            panel2.Location = new Point(0, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 67);
            panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnNew.ButtonImage = (Image)resources.GetObject("btnNew.ButtonImage");
            btnNew.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnNew.ButtonText = "Novo";
            btnNew.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnNew.ClickTextColor = Color.Red;
            btnNew.CornerRadius = 5;
            btnNew.Horizontal_Alignment = StringAlignment.Center;
            btnNew.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnNew.HoverTextColor = Color.Black;
            btnNew.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnNew.Location = new Point(372, 7);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 50);
            btnNew.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNew.TabIndex = 2;
            btnNew.TextColor = Color.Black;
            btnNew.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNew.Vertical_Alignment = StringAlignment.Center;
            btnNew.Click += btnNovo_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnEdit.ButtonImage = (Image)resources.GetObject("btnEdit.ButtonImage");
            btnEdit.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnEdit.ButtonText = "Editar";
            btnEdit.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnEdit.ClickTextColor = Color.Red;
            btnEdit.CornerRadius = 5;
            btnEdit.Horizontal_Alignment = StringAlignment.Center;
            btnEdit.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnEdit.HoverTextColor = Color.Black;
            btnEdit.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnEdit.Location = new Point(512, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(134, 50);
            btnEdit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEdit.TabIndex = 1;
            btnEdit.TextColor = Color.Black;
            btnEdit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEdit.Vertical_Alignment = StringAlignment.Center;
            btnEdit.Click += btnEditar_Click;
            // 
            // btnDel
            // 
            btnDel.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnDel.ButtonImage = (Image)resources.GetObject("btnDel.ButtonImage");
            btnDel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnDel.ButtonText = "Excluir";
            btnDel.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnDel.ClickTextColor = Color.Red;
            btnDel.CornerRadius = 5;
            btnDel.Horizontal_Alignment = StringAlignment.Center;
            btnDel.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnDel.HoverTextColor = Color.Black;
            btnDel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnDel.Location = new Point(649, 7);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(134, 50);
            btnDel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDel.TabIndex = 0;
            btnDel.TextColor = Color.Black;
            btnDel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDel.Vertical_Alignment = StringAlignment.Center;
            btnDel.Click += btnExcluir_Click;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(0, 0);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.RowTemplate.Height = 25;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(792, 276);
            poisonDataGridView1.TabIndex = 0;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(poisonTabControl1);
            MaximumSize = new Size(1366, 720);
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            TransparencyKey = Color.DeepPink;
            poisonTabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabConsulta;
        private Panel panel2;
        protected ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        protected TabPage tabCadastro;
        protected Panel panel1;
        protected ReaLTaiizor.Controls.ParrotButton btnCancel;
        protected ReaLTaiizor.Controls.ParrotButton btnSave;
        protected ReaLTaiizor.Controls.ParrotButton btnDel;
        protected ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        protected ReaLTaiizor.Controls.ParrotButton btnEdit;
        protected ReaLTaiizor.Controls.ParrotButton btnNew;
    }
}