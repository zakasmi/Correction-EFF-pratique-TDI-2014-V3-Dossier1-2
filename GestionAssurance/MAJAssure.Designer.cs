namespace GestionAssurance
{
    partial class MAJAssure
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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_Prec = new System.Windows.Forms.Button();
            this.BTN_Suiv = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Matricule = new System.Windows.Forms.TextBox();
            this.TB_Nom_Ass = new System.Windows.Forms.TextBox();
            this.TB_Nb_Enfant = new System.Windows.Forms.TextBox();
            this.TB_Situation_Familiale = new System.Windows.Forms.TextBox();
            this.TB_Total_Remb = new System.Windows.Forms.TextBox();
            this.TB_Mot_DePasse = new System.Windows.Forms.TextBox();
            this.CB_Num_Entreprise = new System.Windows.Forms.ComboBox();
            this.DTP_Date_Naissance = new System.Windows.Forms.DateTimePicker();
            this.DTP_Date_Deces = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(178, 280);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(103, 33);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(308, 280);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(103, 33);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Location = new System.Drawing.Point(429, 280);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(103, 33);
            this.BTN_Enregistrer.TabIndex = 0;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(559, 280);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(103, 33);
            this.BTN_Fermer.TabIndex = 0;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(200, 348);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(54, 28);
            this.BTN_Debut.TabIndex = 0;
            this.BTN_Debut.Text = "<<";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_Prec
            // 
            this.BTN_Prec.Location = new System.Drawing.Point(330, 348);
            this.BTN_Prec.Name = "BTN_Prec";
            this.BTN_Prec.Size = new System.Drawing.Size(54, 28);
            this.BTN_Prec.TabIndex = 0;
            this.BTN_Prec.Text = "<";
            this.BTN_Prec.UseVisualStyleBackColor = true;
            this.BTN_Prec.Click += new System.EventHandler(this.BTN_Prec_Click);
            // 
            // BTN_Suiv
            // 
            this.BTN_Suiv.Location = new System.Drawing.Point(451, 348);
            this.BTN_Suiv.Name = "BTN_Suiv";
            this.BTN_Suiv.Size = new System.Drawing.Size(54, 28);
            this.BTN_Suiv.TabIndex = 0;
            this.BTN_Suiv.Text = ">";
            this.BTN_Suiv.UseVisualStyleBackColor = true;
            this.BTN_Suiv.Click += new System.EventHandler(this.BTN_Suiv_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(581, 348);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(54, 28);
            this.BTN_Fin.TabIndex = 0;
            this.BTN_Fin.Text = ">>";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom_Ass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date_Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nb_Enfant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Num_Entreprise";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total_Remb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date_Deces";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mot_DePasse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Situation_Familiale";
            // 
            // TB_Matricule
            // 
            this.TB_Matricule.Location = new System.Drawing.Point(164, 28);
            this.TB_Matricule.Name = "TB_Matricule";
            this.TB_Matricule.Size = new System.Drawing.Size(100, 20);
            this.TB_Matricule.TabIndex = 2;
            // 
            // TB_Nom_Ass
            // 
            this.TB_Nom_Ass.Location = new System.Drawing.Point(164, 62);
            this.TB_Nom_Ass.Name = "TB_Nom_Ass";
            this.TB_Nom_Ass.Size = new System.Drawing.Size(100, 20);
            this.TB_Nom_Ass.TabIndex = 2;
            // 
            // TB_Nb_Enfant
            // 
            this.TB_Nb_Enfant.Location = new System.Drawing.Point(164, 145);
            this.TB_Nb_Enfant.Name = "TB_Nb_Enfant";
            this.TB_Nb_Enfant.Size = new System.Drawing.Size(100, 20);
            this.TB_Nb_Enfant.TabIndex = 2;
            // 
            // TB_Situation_Familiale
            // 
            this.TB_Situation_Familiale.Location = new System.Drawing.Point(164, 187);
            this.TB_Situation_Familiale.Name = "TB_Situation_Familiale";
            this.TB_Situation_Familiale.Size = new System.Drawing.Size(100, 20);
            this.TB_Situation_Familiale.TabIndex = 2;
            // 
            // TB_Total_Remb
            // 
            this.TB_Total_Remb.Location = new System.Drawing.Point(521, 65);
            this.TB_Total_Remb.Name = "TB_Total_Remb";
            this.TB_Total_Remb.Size = new System.Drawing.Size(121, 20);
            this.TB_Total_Remb.TabIndex = 2;
            // 
            // TB_Mot_DePasse
            // 
            this.TB_Mot_DePasse.Location = new System.Drawing.Point(521, 148);
            this.TB_Mot_DePasse.Name = "TB_Mot_DePasse";
            this.TB_Mot_DePasse.Size = new System.Drawing.Size(121, 20);
            this.TB_Mot_DePasse.TabIndex = 2;
            // 
            // CB_Num_Entreprise
            // 
            this.CB_Num_Entreprise.FormattingEnabled = true;
            this.CB_Num_Entreprise.Location = new System.Drawing.Point(521, 19);
            this.CB_Num_Entreprise.Name = "CB_Num_Entreprise";
            this.CB_Num_Entreprise.Size = new System.Drawing.Size(121, 21);
            this.CB_Num_Entreprise.TabIndex = 3;
            // 
            // DTP_Date_Naissance
            // 
            this.DTP_Date_Naissance.CustomFormat = "dd/MM/yyyy";
            this.DTP_Date_Naissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date_Naissance.Location = new System.Drawing.Point(164, 106);
            this.DTP_Date_Naissance.Name = "DTP_Date_Naissance";
            this.DTP_Date_Naissance.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date_Naissance.TabIndex = 4;
            // 
            // DTP_Date_Deces
            // 
            this.DTP_Date_Deces.CustomFormat = "dd/MM/yyyy";
            this.DTP_Date_Deces.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date_Deces.Location = new System.Drawing.Point(521, 100);
            this.DTP_Date_Deces.Name = "DTP_Date_Deces";
            this.DTP_Date_Deces.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date_Deces.TabIndex = 4;
            // 
            // MAJAssure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 411);
            this.Controls.Add(this.DTP_Date_Deces);
            this.Controls.Add(this.DTP_Date_Naissance);
            this.Controls.Add(this.CB_Num_Entreprise);
            this.Controls.Add(this.TB_Mot_DePasse);
            this.Controls.Add(this.TB_Situation_Familiale);
            this.Controls.Add(this.TB_Total_Remb);
            this.Controls.Add(this.TB_Nb_Enfant);
            this.Controls.Add(this.TB_Nom_Ass);
            this.Controls.Add(this.TB_Matricule);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Suiv);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.BTN_Prec);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Ajouter);
            this.Name = "MAJAssure";
            this.Text = "MAJAssure";
            this.Load += new System.EventHandler(this.MAJAssure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_Prec;
        private System.Windows.Forms.Button BTN_Suiv;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Matricule;
        private System.Windows.Forms.TextBox TB_Nom_Ass;
        private System.Windows.Forms.TextBox TB_Nb_Enfant;
        private System.Windows.Forms.TextBox TB_Situation_Familiale;
        private System.Windows.Forms.TextBox TB_Total_Remb;
        private System.Windows.Forms.TextBox TB_Mot_DePasse;
        private System.Windows.Forms.ComboBox CB_Num_Entreprise;
        private System.Windows.Forms.DateTimePicker DTP_Date_Naissance;
        private System.Windows.Forms.DateTimePicker DTP_Date_Deces;
    }
}