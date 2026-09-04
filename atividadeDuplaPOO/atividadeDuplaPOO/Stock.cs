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

        public Stock()
        {
            id_produto = 0;
            nome = "Produto não encontrado";
            preco = 0;
            quantidade = 0;
            descricao = "Descrição não encontrada";
        }

        public void setProduto(int id_produto, int quantidade, double preco)
        {
            if (id_produto > 0 || preco > 0 || quantidade > 0) {
                this.id_produto = id_produto;
                this.quantidade = quantidade;
                this.preco = preco;

            }

            else
            {
                Console.WriteLine("o id do produto não pode ser negativo!");
                Console.WriteLine("a quantidade não pode ser negativa!");
                Console.WriteLine("o preço não pode ser negativo!");
            }
        }

        // continua aqui ->
        public void setPreco(double preco)
        {

        }
        // ----------
        public double getSaldo()
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
