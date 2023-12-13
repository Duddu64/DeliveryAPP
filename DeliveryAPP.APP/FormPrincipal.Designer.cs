namespace DeliveryAPP.APP
{
    partial class FormPrincipal: Form
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
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            this.nightForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.nightPanel1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = true;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(1200, 720);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TabStop = false;
            this.nightForm1.Text = "Delivery APP";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            this.nightForm1.Click += new System.EventHandler(this.nightForm1_Click_1);
            // 
            // nightPanel1
            // 
            this.nightPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightPanel1.Location = new System.Drawing.Point(0, 31);
            this.nightPanel1.Name = "nightPanel1";
            this.nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Right;
            this.nightPanel1.Size = new System.Drawing.Size(75, 689);
            this.nightPanel1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 720);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
    }
}