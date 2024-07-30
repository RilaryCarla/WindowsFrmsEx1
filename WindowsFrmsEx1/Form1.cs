using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrmsEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRenda_TextChanged(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
        }

        private void grbGastos_Enter(object sender, EventArgs e)
        {
            double Ge = double.Parse()
        }
    }
}
