using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeMusicHeranca
{
    public class instrumento
    {
        public string nome { get; set; }
        public double valor { get; set; }

        public void emitirSom()
        {
            Console.WriteLine("O instrumento soltou um som!");
        }
    }

    public class Violao : instrumento
    {
        public void tocarCorda()
        {
            Console.WriteLine("A corda foi tocada!");
        }
    }
}
