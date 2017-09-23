using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurance
{
    public partial class MAJAssure : Form
    {
        public MAJAssure()
        {
            InitializeComponent();
        }
        int Pos = 0;
        private void MAJAssure_Load(object sender, EventArgs e)
        {
            try
            {
                Provider.Remplire("select *from Assure", "Assure");
                Provider.Remplire("select *from Entreprise", "Entreprise");
                if (Provider.ds.Tables.Contains("Entreprise"))
                {
                    CB_Num_Entreprise.DataSource = Provider.ds.Tables["Entreprise"];
                    CB_Num_Entreprise.DisplayMember = "Nom_Entreprise";
                    CB_Num_Entreprise.ValueMember = "Num_Entreprise";
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);


            }
        }

        public void Navig()
        {
            try
            {
                if (Provider.ds.Tables["Assure"].Rows[Pos].RowState != DataRowState.Deleted)
                {
                    DataRow dr = Provider.ds.Tables["Assure"].Rows[Pos];
                    TB_Matricule.Text   =   dr[0].ToString();
                    TB_Nom_Ass.Text   =    dr[1].ToString();
                    DTP_Date_Naissance.Text= dr[2].ToString();
                    TB_Nb_Enfant.Text     =   dr[3].ToString();
                    TB_Situation_Familiale.Text  =   dr[4].ToString();
                    CB_Num_Entreprise.SelectedValue =dr[5].ToString();
                    TB_Total_Remb.Text  =   dr[6].ToString();
                    DTP_Date_Deces.Text   = dr[7].ToString();
                    TB_Mot_DePasse.Text  =  dr[8].ToString();

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
              
            }

        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Assure"].Rows.Count;

            if (count >0 )
            {
                Pos = 0;
                Navig();

            }
        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Assure"].Rows.Count;

            if (count > 0)
            {
                Pos = count-1;
                Navig();

            }
        }

        private void BTN_Suiv_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Assure"].Rows.Count;

            if (count > 0 && Pos < count-1)
            {
                Pos++;
                Navig();

            }
        }

        private void BTN_Prec_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Assure"].Rows.Count;

            if (count > 0 && Pos > 0)
            {
                Pos--;
                Navig();

            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Provider.ds.Tables["Assure"].NewRow();
                dr[0] = TB_Matricule.Text;
                dr[1] = TB_Nom_Ass.Text;
                dr[2] = DTP_Date_Naissance.Value;
                dr[3] = TB_Nb_Enfant.Text;
                dr[4] = TB_Situation_Familiale.Text;
                dr[5] = CB_Num_Entreprise.SelectedValue.ToString();
                dr[6] = float.Parse(TB_Total_Remb.Text);
                dr[7] = DTP_Date_Deces.Value;
                dr[8] = TB_Mot_DePasse.Text;
                Provider.ds.Tables["Assure"].Rows.Add(dr);
                MessageBox.Show("L assure est Ajoute avec succes");

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);


            }

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Matricule.Text))
            {
                try
                {
                    Provider.ds.Tables["Assure"].Rows.Find(TB_Matricule.Text).Delete();
                    MessageBox.Show("L assure est supprime avec succes");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);


                }
            }
            else MessageBox.Show("Saisie Une Matricule ");
        }

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                Provider.Enregistrer("select *from Assure", "Assure");
                    MessageBox.Show("Les Modification sont Enregistrer avec succes");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);


            }

        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
