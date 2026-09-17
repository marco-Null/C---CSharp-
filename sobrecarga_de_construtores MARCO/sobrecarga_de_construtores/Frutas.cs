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


        public Frutas()
        {
            nomeFruta = "Nula";
            quantidadeFruta = 0;
        }

        public Frutas(string nomeFruta)
        {
            this.nomeFruta = nomeFruta;
            quantidadeFruta = 0;
        }

        public Frutas(string nomeFruta, int quantidadeFruta)
        {
            this.nomeFruta = nomeFruta;
            this.quantidadeFruta = quantidadeFruta;
        }



    }
}
