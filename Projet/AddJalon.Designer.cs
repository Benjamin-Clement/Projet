namespace Projet
{
    partial class AddJalon
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
            this.TextboxLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnResponsable = new System.Windows.Forms.Button();
            this.TextBoxResponsable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddResponsable = new System.Windows.Forms.Button();
            this.ResponsableProjet = new System.Windows.Forms.ComboBox();
            this.CalendarJalon = new System.Windows.Forms.MonthCalendar();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxLabel
            // 
            this.TextboxLabel.Location = new System.Drawing.Point(171, 38);
            this.TextboxLabel.Name = "TextboxLabel";
            this.TextboxLabel.Size = new System.Drawing.Size(138, 22);
            this.TextboxLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom du jalon :";
            // 
            // BtnValider
            // 
            this.BtnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(206)))), ((int)(((byte)(76)))));
            this.BtnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnValider.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValider.ForeColor = System.Drawing.Color.White;
            this.BtnValider.Location = new System.Drawing.Point(224, 332);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(85, 30);
            this.BtnValider.TabIndex = 6;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = false;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnnuler.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.ForeColor = System.Drawing.Color.White;
            this.BtnAnnuler.Location = new System.Drawing.Point(48, 332);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(85, 30);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.CalendarJalon);
            this.panel5.Controls.Add(this.AddResponsable);
            this.panel5.Controls.Add(this.ResponsableProjet);
            this.panel5.Controls.Add(this.ReturnResponsable);
            this.panel5.Controls.Add(this.TextBoxResponsable);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TextboxLabel);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.BtnValider);
            this.panel5.Controls.Add(this.BtnAnnuler);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 388);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 10);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(415, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 398);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 398);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 10);
            this.panel1.TabIndex = 10;
            // 
            // ReturnResponsable
            // 
            this.ReturnResponsable.Location = new System.Drawing.Point(316, 72);
            this.ReturnResponsable.Name = "ReturnResponsable";
            this.ReturnResponsable.Size = new System.Drawing.Size(75, 23);
            this.ReturnResponsable.TabIndex = 15;
            this.ReturnResponsable.Text = "Retour";
            this.ReturnResponsable.UseVisualStyleBackColor = true;
            this.ReturnResponsable.Visible = false;
            this.ReturnResponsable.Click += new System.EventHandler(this.ReturnResponsable_Click);
            // 
            // TextBoxResponsable
            // 
            this.TextBoxResponsable.Location = new System.Drawing.Point(171, 70);
            this.TextBoxResponsable.Name = "TextBoxResponsable";
            this.TextBoxResponsable.Size = new System.Drawing.Size(139, 22);
            this.TextBoxResponsable.TabIndex = 14;
            this.TextBoxResponsable.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Responsable : ";
            // 
            // AddResponsable
            // 
            this.AddResponsable.Location = new System.Drawing.Point(316, 72);
            this.AddResponsable.Name = "AddResponsable";
            this.AddResponsable.Size = new System.Drawing.Size(21, 23);
            this.AddResponsable.TabIndex = 17;
            this.AddResponsable.Text = "+";
            this.AddResponsable.UseVisualStyleBackColor = true;
            this.AddResponsable.Click += new System.EventHandler(this.AddResponsable_Click);
            // 
            // ResponsableProjet
            // 
            this.ResponsableProjet.FormattingEnabled = true;
            this.ResponsableProjet.Location = new System.Drawing.Point(171, 70);
            this.ResponsableProjet.Name = "ResponsableProjet";
            this.ResponsableProjet.Size = new System.Drawing.Size(139, 24);
            this.ResponsableProjet.TabIndex = 16;
            // 
            // CalendarJalon
            // 
            this.CalendarJalon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarJalon.Location = new System.Drawing.Point(48, 106);
            this.CalendarJalon.Name = "CalendarJalon";
            this.CalendarJalon.TabIndex = 18;
            // 
            // AddJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 408);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddJalon";
            this.Text = "AddJalon";
            this.Load += new System.EventHandler(this.AddJalon_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextboxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReturnResponsable;
        private System.Windows.Forms.TextBox TextBoxResponsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddResponsable;
        private System.Windows.Forms.ComboBox ResponsableProjet;
        private System.Windows.Forms.MonthCalendar CalendarJalon;
    }
}