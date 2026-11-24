using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPIZZA
{
    public abstract class bebidas
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public int tamanho { get; set; } // por ml

        public abstract void exibirInformacao();

    }

    public class coca_cola : bebidas
    {
        public coca_cola(int IDvio)
        {
            id = IDvio;
            nome = "Coca-Cola";
            valor = 14.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Bebida : " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class fanta_uva : bebidas
    {
        public fanta_uva(int IDvio)
        {
            id = IDvio;
            nome = "Fanta Uva";
            valor = 10.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Bebida : " + nome);
            Console.WriteLine("Tamanho (em ML): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class fanta_laranja : bebidas
    {
        public fanta_laranja(int IDvio)
        {
            id = IDvio;
            nome = "Fanta Laranja";
            valor = 10.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class guarana_antartida : bebidas
    {
        public guarana_antartida(int IDvio)
        {
            id = IDvio;
            nome = "Guaraná Antartida";
            valor = 11.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class tubaina : bebidas
    {
        public tubaina(int IDvio)
        {
            id = IDvio;
            nome = "Tubaina";
            valor = 8.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class it_laranja : bebidas
    {
        public it_laranja(int IDvio)
        {
            id = IDvio;
            nome = "IT Laranja";
            valor = 7.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class it_limao : bebidas
    {
        public it_limao(int IDvio)
        {
            id = IDvio;
            nome = "IT Limão";
            valor = 7.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Bebida : " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class dolly_guarana : bebidas
    {
        public dolly_guarana(int IDvio)
        {
            id = IDvio;
            nome = "Dolly Guaraná";
            valor = 6.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Bebida : " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }
    public class dolly_limao : bebidas
    {
        public dolly_limao(int IDvio)
        {
            id = IDvio;
            nome = "Dolly Limão";
            valor = 6.90;
            tamanho = 2000;
        }
        public override void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Bebida : " + nome);
            Console.WriteLine("Tamanho(ml): " + tamanho);
            Console.WriteLine("R$: " + valor + "\n");
        }
    }


}
