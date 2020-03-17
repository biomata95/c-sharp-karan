using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    abstract class Conta
    {
        public double saldo;

        public double getSaldo(){
            return saldo;
        }

        public void setDeposito(double saldo){
            this.saldo += saldo;
        }

        public void setSaque(double saque){
            if(this.saldo < saque)
                Console.WriteLine("Saldo insuficiente para saque.");
            else
                this.saldo -= saque;
        }

    }
}