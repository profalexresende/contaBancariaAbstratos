using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace contaBancaria_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente cc1=new ContaCorrente(500,1000);
        ContaPoupanca cp1 = new ContaPoupanca(5000, 0.01);

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            switch (cmbTipoConta.SelectedIndex)
            {
                case 0:
                    cc1.creditar(valor);
                    break;
                case 1:
                    cp1.creditar(valor);
                    break;
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            switch (cmbTipoConta.SelectedIndex)
            {
                case 0:
                         cc1.debitar(valor);
                    break;
                case 1:
                    if (valor <= cp1.saldo)
                    {
                        cp1.debitar(valor);
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }
                    break;
            }
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            switch (cmbTipoConta.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Saldo em CC: R$" + cc1.saldo.ToString());
                    break;
                case 1:
                    MessageBox.Show("Saldo em Poupança: R$" + cp1.saldo.ToString());
                    break;
            }
        }

        private void btnAtualizaSaldo_Click(object sender, EventArgs e)
        {
            switch (cmbTipoConta.SelectedIndex)
            {
                case 0:
                    cc1.atualizarSaldos();
                    break;
                case 1:
                    double reajuste = Convert.ToDouble(Interaction.InputBox("Digite a taxa de reajuste"));
                    cp1.atualizarSaldos(reajuste);
                    break;
            }
        }
    }
}
