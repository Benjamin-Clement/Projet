namespace Projet
{
    partial class AddProjet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddResponsable = new System.Windows.Forms.Button();
            this.ResponsableProjet = new System.Windows.Forms.ComboBox();
            this.IdProjet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarProject = new System.Windows.Forms.MonthCalendar();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.TextBoxResponsable = new System.Windows.Forms.TextBox();
            this.ReturnResponsable = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 440);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(512, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 440);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.ReturnResponsable);
            this.panel5.Controls.Add(this.TextBoxResponsable);
            this.panel5.Controls.Add(this.AddResponsable);
            this.panel5.Controls.Add(this.ResponsableProjet);
            this.panel5.Controls.Add(this.IdProjet);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.BtnValider);
            this.panel5.Controls.Add(this.BtnAnnuler);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.CalendarProject);
            this.panel5.Controls.Add(this.ProjectName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(502, 430);
            this.panel5.TabIndex = 4;
            // 
            // AddResponsable
            // 
            this.AddResponsable.Location = new System.Drawing.Point(376, 77);
            this.AddResponsable.Name = "AddResponsable";
            this.AddResponsable.Size = new System.Drawing.Size(21, 23);
            this.AddResponsable.TabIndex = 10;
            this.AddResponsable.Text = "+";
            this.AddResponsable.UseVisualStyleBackColor = true;
            this.AddResponsable.Click += new System.EventHandler(this.AddResponsable_Click);
            // 
            // ResponsableProjet
            // 
            this.ResponsableProjet.FormattingEnabled = true;
            this.ResponsableProjet.Location = new System.Drawing.Point(231, 75);
            this.ResponsableProjet.Name = "ResponsableProjet";
            this.ResponsableProjet.Size = new System.Drawing.Size(139, 24);
            this.ResponsableProjet.TabIndex = 9;
            // 
            // IdProjet
            // 
            this.IdProjet.Location = new System.Drawing.Point(231, 19);
            this.IdProjet.Name = "IdProjet";
            this.IdProjet.Size = new System.Drawing.Size(139, 22);
            this.IdProjet.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identifiant :";
            // 
            // BtnValider
            // 
            this.BtnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(206)))), ((int)(((byte)(76)))));
            this.BtnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnValider.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValider.ForeColor = System.Drawing.Color.White;
            this.BtnValider.Location = new System.Drawing.Point(285, 364);
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
            this.BtnAnnuler.Location = new System.Drawing.Point(108, 364);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(85, 30);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Responsable : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du projet : ";
            // 
            // CalendarProject
            // 
            this.CalendarProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarProject.Location = new System.Drawing.Point(108, 109);
            this.CalendarProject.Name = "CalendarProject";
            this.CalendarProject.TabIndex = 2;
            // 
            // ProjectName
            // 
            this.ProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectName.Location = new System.Drawing.Point(231, 47);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(139, 22);
            this.ProjectName.TabIndex = 0;
            // 
            // TextBoxResponsable
            // 
            this.TextBoxResponsable.Location = new System.Drawing.Point(231, 75);
            this.TextBoxResponsable.Name = "TextBoxResponsable";
            this.TextBoxResponsable.Size = new System.Drawing.Size(139, 22);
            this.TextBoxResponsable.TabIndex = 11;
            this.TextBoxResponsable.Visible = false;
            // 
            // ReturnResponsable
            // 
            this.ReturnResponsable.Location = new System.Drawing.Point(376, 77);
            this.ReturnResponsable.Name = "ReturnResponsable";
            this.ReturnResponsable.Size = new System.Drawing.Size(75, 23);
            this.ReturnResponsable.TabIndex = 12;
            this.ReturnResponsable.Text = "Retour";
            this.ReturnResponsable.UseVisualStyleBackColor = true;
            this.ReturnResponsable.Visible = false;
            this.ReturnResponsable.Click += new System.EventHandler(this.ReturnResponsable_Click);
            // 
            // AddProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProjet";
            this.Load += new System.EventHandler(this.AddProjet_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarProject;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Button AddResponsable;
        private System.Windows.Forms.ComboBox ResponsableProjet;
        private System.Windows.Forms.TextBox IdProjet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxResponsable;
        private System.Windows.Forms.Button ReturnResponsable;
    }
}