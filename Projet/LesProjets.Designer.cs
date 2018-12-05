namespace Projet
{
    partial class LesProjets
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddProjet = new System.Windows.Forms.Button();
            this.PanelProjets = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Projet.DatabaseDataSet();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetTableAdapter = new Projet.DatabaseDataSetTableAdapters.ProjetTableAdapter();
            this.ComboProjet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelIdPrj = new System.Windows.Forms.Label();
            this.LabelNomPrj = new System.Windows.Forms.Label();
            this.LabelRespProjet = new System.Windows.Forms.Label();
            this.LabelDebutPrj = new System.Windows.Forms.Label();
            this.LabelFinPrj = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelProjets.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des projets";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(73)))));
            this.flowLayoutPanel1.Controls.Add(this.BtnAddProjet);
            this.flowLayoutPanel1.Controls.Add(this.PanelProjets);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 733);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnAddProjet
            // 
            this.BtnAddProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(206)))), ((int)(((byte)(76)))));
            this.BtnAddProjet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddProjet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProjet.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddProjet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(206)))), ((int)(((byte)(76)))));
            this.BtnAddProjet.FlatAppearance.BorderSize = 0;
            this.BtnAddProjet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddProjet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProjet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddProjet.Location = new System.Drawing.Point(3, 3);
            this.BtnAddProjet.Name = "BtnAddProjet";
            this.BtnAddProjet.Size = new System.Drawing.Size(191, 30);
            this.BtnAddProjet.TabIndex = 0;
            this.BtnAddProjet.Text = "Ajouter un projet +";
            this.BtnAddProjet.UseVisualStyleBackColor = false;
            this.BtnAddProjet.Click += new System.EventHandler(this.BtnAddProjet_Click);
            // 
            // PanelProjets
            // 
            this.PanelProjets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(73)))));
            this.PanelProjets.Controls.Add(this.panel4);
            this.PanelProjets.Controls.Add(this.ComboProjet);
            this.PanelProjets.Location = new System.Drawing.Point(3, 39);
            this.PanelProjets.Name = "PanelProjets";
            this.PanelProjets.Size = new System.Drawing.Size(191, 682);
            this.PanelProjets.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 733);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(212, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 733);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.LabelFinPrj);
            this.panel4.Controls.Add(this.LabelDebutPrj);
            this.panel4.Controls.Add(this.LabelRespProjet);
            this.panel4.Controls.Add(this.LabelNomPrj);
            this.panel4.Controls.Add(this.LabelIdPrj);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 646);
            this.panel4.TabIndex = 0;
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "Projet";
            this.projetBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "Projet";
            this.projetBindingSource.DataSource = this.databaseDataSet;
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // ComboProjet
            // 
            this.ComboProjet.FormattingEnabled = true;
            this.ComboProjet.Location = new System.Drawing.Point(3, 3);
            this.ComboProjet.Name = "ComboProjet";
            this.ComboProjet.Size = new System.Drawing.Size(185, 24);
            this.ComboProjet.TabIndex = 0;
            this.ComboProjet.DropDown += new System.EventHandler(this.ComboProjet_DropDown);
            this.ComboProjet.SelectedIndexChanged += new System.EventHandler(this.ComboProjet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Responsable :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fin prévue :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Debut :";
            // 
            // LabelIdPrj
            // 
            this.LabelIdPrj.AutoSize = true;
            this.LabelIdPrj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdPrj.ForeColor = System.Drawing.Color.White;
            this.LabelIdPrj.Location = new System.Drawing.Point(42, 4);
            this.LabelIdPrj.Name = "LabelIdPrj";
            this.LabelIdPrj.Size = new System.Drawing.Size(0, 18);
            this.LabelIdPrj.TabIndex = 5;
            // 
            // LabelNomPrj
            // 
            this.LabelNomPrj.AutoSize = true;
            this.LabelNomPrj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomPrj.ForeColor = System.Drawing.Color.White;
            this.LabelNomPrj.Location = new System.Drawing.Point(60, 22);
            this.LabelNomPrj.Name = "LabelNomPrj";
            this.LabelNomPrj.Size = new System.Drawing.Size(0, 18);
            this.LabelNomPrj.TabIndex = 6;
            // 
            // LabelRespProjet
            // 
            this.LabelRespProjet.AutoSize = true;
            this.LabelRespProjet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRespProjet.ForeColor = System.Drawing.Color.White;
            this.LabelRespProjet.Location = new System.Drawing.Point(122, 40);
            this.LabelRespProjet.Name = "LabelRespProjet";
            this.LabelRespProjet.Size = new System.Drawing.Size(0, 18);
            this.LabelRespProjet.TabIndex = 7;
            // 
            // LabelDebutPrj
            // 
            this.LabelDebutPrj.AutoSize = true;
            this.LabelDebutPrj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDebutPrj.ForeColor = System.Drawing.Color.White;
            this.LabelDebutPrj.Location = new System.Drawing.Point(72, 58);
            this.LabelDebutPrj.Name = "LabelDebutPrj";
            this.LabelDebutPrj.Size = new System.Drawing.Size(0, 18);
            this.LabelDebutPrj.TabIndex = 8;
            // 
            // LabelFinPrj
            // 
            this.LabelFinPrj.AutoSize = true;
            this.LabelFinPrj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinPrj.ForeColor = System.Drawing.Color.White;
            this.LabelFinPrj.Location = new System.Drawing.Point(106, 76);
            this.LabelFinPrj.Name = "LabelFinPrj";
            this.LabelFinPrj.Size = new System.Drawing.Size(0, 18);
            this.LabelFinPrj.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LesProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1260, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "LesProjets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de projets";
            this.Load += new System.EventHandler(this.LesProjets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelProjets.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAddProjet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelProjets;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private DatabaseDataSetTableAdapters.ProjetTableAdapter projetTableAdapter;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        private System.Windows.Forms.ComboBox ComboProjet;
        private System.Windows.Forms.Label LabelFinPrj;
        private System.Windows.Forms.Label LabelDebutPrj;
        private System.Windows.Forms.Label LabelRespProjet;
        private System.Windows.Forms.Label LabelNomPrj;
        private System.Windows.Forms.Label LabelIdPrj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}