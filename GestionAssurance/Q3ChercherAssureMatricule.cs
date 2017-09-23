using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurance
{
    public partial class Q3ChercherAssureMatricule : Form
    {
        public Q3ChercherAssureMatricule()
        {
            InitializeComponent();
        }

        private void BTN_Chercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_MatriculeCHerchr.Text))
            {
                Provider.Remplire("select *from Assure where Matricule= '"+ TB_MatriculeCHerchr.Text + "'","Assure");
                if (Provider.ds.Tables["Assure"].Rows.Count > 0) {
                    DataRow dr = Provider.ds.Tables["Assure"].Rows[0];
                    TB_Matricule.Text = dr[0].ToString();
                    TB_Nom_Ass.Text = dr[1].ToString();
                    DTP_Date_Naissance.Text = dr[2].ToString();
                    TB_Nb_Enfant.Text = dr[3].ToString();
                    TB_Situation_Familiale.Text = dr[4].ToString();
                    CB_Num_Entreprise.SelectedValue = dr[5].ToString();
                    TB_Total_Remb.Text = dr[6].ToString();
                    DTP_Date_Deces.Text = dr[7].ToString();
                    TB_Mot_DePasse.Text = dr[8].ToString();
                    groupBox1.Enabled = true;

                }else { MessageBox.Show("Pas d assure avec ce Matricule");
                    groupBox1.Enabled = false;
                }
            }
            else MessageBox.Show("Saisie Matricule");
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TB_Matricule.Text))
                {
                    float x = 0;
                    if (!float.TryParse(TB_Total_Remb.Text, out x))
                    {
                        TB_Total_Remb.Text = "0";
                    }
                        DataRow dr = Provider.ds.Tables["Assure"].Rows[0];
                        dr[0] = TB_Matricule.Text;
                        dr[1] = TB_Nom_Ass.Text;
                        dr[2] = DTP_Date_Naissance.Value;
                        dr[3] = TB_Nb_Enfant.Text;
                        dr[4] = TB_Situation_Familiale.Text;
                        dr[5] = CB_Num_Entreprise.SelectedValue.ToString();
                        dr[6] = float.Parse(TB_Total_Remb.Text);
                        dr[7] = DTP_Date_Deces.Value;
                        dr[8] = TB_Mot_DePasse.Text;


                        Provider.Enregistrer("select *from Assure where Matricule = '" + TB_Matricule.Text + "'", "Assure");
                        MessageBox.Show("L assure est Modifier avec succes");
                    
                 

                }
                else MessageBox.Show("CHercher puis Modifier");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message); 
            }
        }

        private void Q3ChercherAssureMatricule_Load(object sender, EventArgs e)
        {
            Provider.Remplire("select *from Entreprise", "Entreprise");
            if (Provider.ds.Tables.Contains("Entreprise"))
            {
                CB_Num_Entreprise.DataSource = Provider.ds.Tables["Entreprise"];
                CB_Num_Entreprise.DisplayMember = "Nom_Entreprise";
                CB_Num_Entreprise.ValueMember = "Num_Entreprise";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Q4Etat q4 = new Q4Etat(TB_Matricule.Text);
                Provider.Remplire("SELECT dbo.Dossier.* FROM  dbo.Dossier where Matricule = '" + TB_Matricule.Text + "' and (Montant_Remboursement > '0' and Montant_Remboursement is not null) and year(Date_Traitement) = year(GetDate()) ", "Dossier");
                q4.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                Q4Etat q4 = new Q4Etat(TB_Matricule.Text);
                Provider.Remplire("SELECT dbo.Dossier.* FROM  dbo.Dossier where Matricule = '" + TB_Matricule.Text + "' and (Montant_Remboursement <= '0' or Montant_Remboursement is null ) ", "Dossier");
                q4.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM  Dossier where  ( Montant_Remboursement > '0' and Montant_Remboursement is not null)  and year(Date_Traitement) = year(GetDate())", Provider.cnx);
                Provider.cnx.Open();
                label14.Text = cmd.ExecuteScalar().ToString();
                Provider.cnx.Close();
                cmd = new SqlCommand("SELECT count(*) FROM  Dossier where  ( Montant_Remboursement <= '0' or Montant_Remboursement is null)  and year(Date_Traitement) = year(GetDate())", Provider.cnx);
                Provider.cnx.Open();
                label16.Text = cmd.ExecuteScalar().ToString();
                Provider.cnx.Close();
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT sum(Montant_Remboursement) FROM  Dossier where  ( Montant_Remboursement > '0' and Montant_Remboursement is not null)  and year(Date_Traitement) = year(GetDate())", Provider.cnx);
                Provider.cnx.Open();
                label12.Text = cmd.ExecuteScalar().ToString()+" DH";
                Provider.cnx.Close();
       
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }
    }
}
