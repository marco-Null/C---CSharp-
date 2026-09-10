using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeDuplaPOO
{
    public class Stock
    {
        private int id_produto { get; set; }
        public string nome { get; set; }
        private double preco { get; set; }
        private int quantidade { get; set; }
        public string descricao { get; set; }
        public string erroPreco { get; set; }

        public Stock()
        {
            id_produto = 0;
            nome = "Produto não encontrado";
            preco = 0;
            quantidade = 0;
            descricao = "Descrição não encontrada";
            erroPreco = "";
        }


        // continua aqui ->
        public void setPreco(double preco)
        {
            if (preco > 0)
            {
                this.preco = preco;
            }

            else
            {
                this.preco = 0;
            }
        }

        public void setQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                this.quantidade = quantidade;
            }

            else
            {
                this.quantidade = 0;
            }
        }

        public void setID(int ID)
        {
            if (ID > 0)
            {
                this.id_produto = ID;
            }

            else
            {
                this.id_produto = 0;
            }
        }


        //---------------------

        public double getPreco()
        {
            return preco;
        }

        public int getID()
        {
            return id_produto;
        }

        public int getQuantidade()
        {
            return quantidade;
        }

        
    }
}
