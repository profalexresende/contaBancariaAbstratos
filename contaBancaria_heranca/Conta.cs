using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaBancaria_heranca
{
    abstract class Conta
    {
        public double saldo { get; set; }

        public Conta()
        {
            saldo = 0;
        }

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public virtual void debitar(double valor)
        {
            this.saldo -= valor;
            MessageBox.Show("Saque efetuado");
        }

        public void creditar(double valor)
        {
            this.saldo += valor;
            MessageBox.Show("Depósito Efetuado");
        }
        
        public abstract void atualizarSaldos();//MÉTODO ABSTRATO, SOMENTE CONTÉM ASSINATURA
    }
}
