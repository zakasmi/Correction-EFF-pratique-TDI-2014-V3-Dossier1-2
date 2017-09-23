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
    public partial class Q4Etat : Form
    {
        public Q4Etat()
        {
            InitializeComponent();
        }
        public Q4Etat(string s)
        {
            InitializeComponent();
            x = s;
        }
        string x;
        private void Q4Etat_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetParameterValue("@Matricule", x);
            crystalReportViewer1.ReportSource = rpt;
            dataGridView1.DataSource = Provider.ds.Tables["Dossier"];
        }
    }
}
