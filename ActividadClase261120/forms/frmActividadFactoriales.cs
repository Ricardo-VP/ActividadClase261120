﻿using System;
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
    public partial class frmActividadFactoriales : Form
    {
        public frmActividadFactoriales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);
            textBox1.Text = Convert.ToString(clases.Factorial.ejFact(numero));
        }
    }
}
