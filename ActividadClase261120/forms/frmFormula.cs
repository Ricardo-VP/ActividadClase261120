using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadClase261120.forms
{
    public partial class frmFormula : Form
    {
        public frmFormula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtI.Text);
            int n = Convert.ToInt32(txtN.Text);
            txtRes.Text = Convert.ToString(clases.Formula.ejFormula(i, n));
        }
    }
}
