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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_MAJAssure_Click(object sender, EventArgs e)
        {
            MAJAssure M = new MAJAssure();
            M.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Q3ChercherAssureMatricule M = new Q3ChercherAssureMatricule();
            M.ShowDialog();
        }

      
    }
}
