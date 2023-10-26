namespace Ex034
{
    partial class Form1
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
            lblPrenom = new Label();
            lblNom = new Label();
            lblDdn = new Label();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            txtDdn = new TextBox();
            btnAjouterClient = new Button();
            btnRechercher = new Button();
            SuspendLayout();
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(12, 18);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 0;
            lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(12, 67);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom";
            // 
            // lblDdn
            // 
            lblDdn.AutoSize = true;
            lblDdn.Location = new Point(12, 114);
            lblDdn.Name = "lblDdn";
            lblDdn.Size = new Size(101, 15);
            lblDdn.TabIndex = 2;
            lblDdn.Text = "Date de naissance";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(119, 15);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(139, 23);
            txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(119, 64);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(139, 23);
            txtNom.TabIndex = 4;
            // 
            // txtDdn
            // 
            txtDdn.Location = new Point(119, 111);
            txtDdn.Name = "txtDdn";
            txtDdn.Size = new Size(139, 23);
            txtDdn.TabIndex = 5;
            // 
            // btnAjouterClient
            // 
            btnAjouterClient.Location = new Point(12, 161);
            btnAjouterClient.Name = "btnAjouterClient";
            btnAjouterClient.Size = new Size(104, 27);
            btnAjouterClient.TabIndex = 6;
            btnAjouterClient.Text = "Ajouter client";
            btnAjouterClient.UseVisualStyleBackColor = true;
            btnAjouterClient.Click += btnAjouterClient_Click;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(154, 161);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(104, 27);
            btnRechercher.TabIndex = 7;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 206);
            Controls.Add(btnRechercher);
            Controls.Add(btnAjouterClient);
            Controls.Add(txtDdn);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(lblDdn);
            Controls.Add(lblNom);
            Controls.Add(lblPrenom);
            Name = "Form1";
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrenom;
        private Label lblNom;
        private Label lblDdn;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private TextBox txtDdn;
        private Button btnAjouterClient;
        private Button btnRechercher;
    }
}