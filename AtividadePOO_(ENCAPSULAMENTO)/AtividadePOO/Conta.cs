using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Conta
    {
        public string nome { get; set; }
        public int nrConta { get; set; }
        private double saldo { get; set; }

        public void setSaldo(double saldo)
        {
            if(saldo > 0)
            {
                this.saldo = saldo;
            }

            else
            {
                Console.WriteLine("Erro, valor negativo!");
            }
        }

        public double getSaldo()
        {
            return saldo;
        }
    }
}
