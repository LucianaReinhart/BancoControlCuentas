using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoControlCuentas
{
    public partial class Form1 : Form
    {
        private int saldo = 0;
        private int contDeposito = 0;
        private int contExtraccion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            try
            {
                int extraccion = int.Parse(textBoxMonto.Text);
                if(extraccion > 0)
                {
                    if(saldo - extraccion >= -50000)
                    {
                        saldo -= extraccion;
                        lblSaldo.Text = saldo.ToString();
                        contExtraccion++;
                        lblCantidadExtraccion.Text = "Cantidad de extracciones: " + contExtraccion;
                        textBoxMonto.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese correctamente el monto");

            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                int deposito = int.Parse(textBoxMonto.Text);
                if(deposito > 0)
                {
                    saldo += deposito;
                    lblSaldo.Text = saldo.ToString();
                    contDeposito++;
                    lblCantidadDepositos.Text = "Cantidad de depositos: " + contDeposito;
                    textBoxMonto.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese correctamente el monto");
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCantidadDepositos_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
