using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPIZZA
{
    public abstract class pizzas
    {
        public string nome { get; set; }
        public int id { get; set; }
        public double valor { get; set; }

        public virtual void pizza()
        {
            Console.WriteLine("A pizza" + nome + "custa: " + valor);
        }

        protected ingredientes ingre = new ingredientes();

        public abstract void Preparacao();
    }

    public class ingredientes
    {
        public string Molho { get; set; } = "Molho";
        public string Mussarela { get; set; } = "Mussarela";
        public string Presunto { get; set; } = "Presunto";
        public string Milho { get; set; } = "Milho";
        public string Peperoni { get; set; } = "Peperoni";
        public string Cebola { get; set; } = "Cebola";
        public string Azeitonas { get; set; } = "Azeitonas";
        public string Oregano { get; set; } = "Orégano";
        public string Manjericao { get; set; } = "Manjericão";
        public string Bacon { get; set; } = "Bacon";
        public string Frango { get; set; } = "Frango";
        public string Catupiry { get; set; } = "Catupiry";
        public string Tomate { get; set; } = "Tomate";
        public string Ervilha { get; set; } = "Ervilha";


        public string sorvete_chocholate { get; set; } = "Sorvete de Chocolate";
        public string sorvete_morango { get; set; } = "Sorvete de morango";
        public string sorvete_flocos { get; set; } = "Sorvete de flocos";
        public string chocolate { get; set; } = "Chocolate";
        public string morango { get; set; } = "Morango";

    }

    public class peperone : pizzas
    {
        public peperone(int idvio)
        {
            id = idvio;
            nome = "Peperoni";
            valor = 26.99;
        }

        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Peperoni);
            Console.WriteLine("- " + ingre.Oregano);
            Console.WriteLine("- " + ingre.Cebola);
            Console.WriteLine("- " + ingre.Azeitonas);
        }
    }
    public class mussarela : pizzas
    {
        public mussarela(int idvio)
        {
            id = idvio;
            nome = "Calabresa";
            valor = 22.50;
        }

        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Mussarela);
            Console.WriteLine("- " + ingre.Tomate);
            Console.WriteLine("- " + ingre.Oregano);
            Console.WriteLine("- " + ingre.Cebola);
            Console.WriteLine("- " + ingre.Azeitonas);
        }
    }
    public class margurrita : pizzas
    {
        public margurrita(int idvio)
        {
            id = idvio;
            nome = "Margurrita";
            valor = 27.50;
        }

        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Mussarela);
            Console.WriteLine("- " + ingre.Tomate);
            Console.WriteLine("- " + ingre.Oregano);
            Console.WriteLine("- " + ingre.Manjericao);
            Console.WriteLine("- " + ingre.Azeitonas);
        }
    }
    public class bacon : pizzas
    {
        public bacon(int idvio)
        {
            id = idvio;
            nome = "Bacon";
            valor = 29.99;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Mussarela);
            Console.WriteLine("- " + ingre.Tomate);
            Console.WriteLine("- " + ingre.Oregano);
            Console.WriteLine("- " + ingre.Bacon);
            Console.WriteLine("- " + ingre.Cebola);
        }
    }
    public class Portuguesa : pizzas
    {
        public Portuguesa(int idvio)
        {
            id = idvio;
            nome = "Portuguesa";
            valor = 31.99;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Mussarela);
            Console.WriteLine("- " + ingre.Presunto);
            Console.WriteLine("- " + ingre.Oregano);
            Console.WriteLine("- " + ingre.Cebola);
            Console.WriteLine("- " + ingre.Ervilha);
            Console.WriteLine("- " + ingre.Milho);
        }
    }
    public class frangoCtupiry : pizzas
    {
        public frangoCtupiry(int idvio)
        {
            id = idvio;
            nome = "Frango com Catupiry";
            valor = 25.50;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.Molho);
            Console.WriteLine("- " + ingre.Mussarela);
            Console.WriteLine("- " + ingre.Frango);
            Console.WriteLine("- " + ingre.Manjericao);
            Console.WriteLine("- " + ingre.Catupiry);
        }
    }

    public class sorvete_chocolate : pizzas
    {
        public sorvete_chocolate(int idvio)
        {
            id = idvio;
            nome = "Sorvete de chocolate";
            valor = 55.90;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.sorvete_chocholate);
        }
    }
    public class sorvete_morango : pizzas
    {
        public sorvete_morango(int idvio)
        {
            id = idvio;
            nome = "Sorvete de morango";
            valor = 55.90;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.sorvete_morango);
        }
    }
    public class sorvete_flocos : pizzas
    {
        public sorvete_flocos(int idvio)
        {
            id = idvio;
            nome = "Sorvete de flocos";
            valor = 58.90;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.sorvete_flocos);
        }
    }
    public class chocolate_morango : pizzas
    {
        public chocolate_morango(int idvio)
        {
            id = idvio;
            nome = "Chocolate c/ morango";
            valor = 55.90;
        }
        public void exibirInformacao()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Pizza de: " + nome);
            Console.WriteLine("R$: " + valor + "\n");
        }

        public override void Preparacao()
        {
            Console.WriteLine("Preparando a pizza de " + nome + ", adicionando: ");
            Console.WriteLine("- " + ingre.chocolate);
            Console.WriteLine("- " + ingre.morango);
        }
    }
}
