namespace GestionAssurance
{
    partial class Form1
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
            this.BTN_MAJAssure = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MAJAssure
            // 
            this.BTN_MAJAssure.Location = new System.Drawing.Point(155, 81);
            this.BTN_MAJAssure.Name = "BTN_MAJAssure";
            this.BTN_MAJAssure.Size = new System.Drawing.Size(148, 48);
            this.BTN_MAJAssure.TabIndex = 0;
            this.BTN_MAJAssure.Text = "Q2 MAJ Assure";
            this.BTN_MAJAssure.UseVisualStyleBackColor = true;
            this.BTN_MAJAssure.Click += new System.EventHandler(this.BTN_MAJAssure_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Q3 Chercher Assure Matricule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 226);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_MAJAssure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_MAJAssure;
        private System.Windows.Forms.Button button2;
    }
}

