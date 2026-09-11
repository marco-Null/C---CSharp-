using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga_de_construtores
{
    public class Frutas
    {
        public string nomeFruta { get; set; }
        public int quantidadeFruta { get; set; }


        public Frutas(string nome = "Vazio", int quantidade = 0)
        {
            nomeFruta = nome;
            quantidadeFruta = quantidade;
        }

        public void Fruteira()
        {
            Console.WriteLine("O nome da fruta é: " + nomeFruta);
            return;
        }

        public void Fruteira(int quantidadeFruta)
        {
            Console.WriteLine("A quantidade da fruta é: " + quantidadeFruta);
            return;
        }

    }
}
