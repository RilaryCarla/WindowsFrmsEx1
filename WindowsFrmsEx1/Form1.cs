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
        }

        private void grbGastos_Enter(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
            double Ge = double.Parse(txtEnergia.Text);
            double Ga = double.Parse(txtAgua.Text);
            double Gt = double.Parse(txtTV.Text);
            double GA = double.Parse(txtAlimentacao.Text);
            double Go = double.Parse(txtOutros.Text);

            double gas = Ge + Ga + Gt + Go + GA;

            double cal = renda - gas;

            lblGastos.Text = gas.ToString();

            lblSaldo.Text = cal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();
        }

    }
}
