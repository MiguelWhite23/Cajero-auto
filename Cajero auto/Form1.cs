using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double[] demonimaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantifdad.Text);
            sbyte N = 0;
            string answer = "RESPUESTA:\n ";
            foreach (double denominacion in demonimaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    N++;
                    cantidad -= denominacion;
                }
                if (N > 0)
                {
                    answer += N + (denominacion > 1 ? " BILLETES " : " MONEDAS ") + denominacion + "\n";
                }
                N = 0;
            }
            lblrespuesta.Text = answer;
        }
    
