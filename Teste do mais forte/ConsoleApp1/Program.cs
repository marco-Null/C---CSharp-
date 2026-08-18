using System;
using ConsoleApp1;

bool ativador = true;

while (ativador)
{
    Mais_forte pessoa1 = new Mais_forte();

    Console.Write("Digite o nome da pessoa mais forte atualmente: ");
    pessoa1.nome = Console.ReadLine();

    Console.Clear();

    Console.Write("digite a idade do mais forte: ");
    pessoa1.idade = int.Parse(Console.ReadLine());

    Console.Clear();

    Console.WriteLine("a pessoa mais forte Lidera os outros ?");

    Console.WriteLine();

    Console.Write("se Sim, Escreva 'true', se não, escreva 'false': ");
    pessoa1.lideranca = bool.Parse(Console.ReadLine());

    Console.Clear();

    Console.WriteLine("NOME DO MAIS FORTE: " + pessoa1.nome);
    Console.WriteLine("IDADE DO MAIS FORTE: " + pessoa1.idade);
    Console.WriteLine("O MAIS FORTE LIDERA?: " + pessoa1.lideranca);

    Console.WriteLine();

    if (pessoa1.lideranca == true || pessoa1.lideranca == false)
    {
        if (pessoa1.nome == "MARCO" || pessoa1.nome == "Marco" || pessoa1.nome == "marco")
        {
            pessoa1.titulo = "você desbloqueou o titulo do *mais FORTE do CSHARP*!";

            Console.WriteLine("Titulos: " + pessoa1.titulo);

            Console.WriteLine();

            Console.WriteLine("pressione ESPAÇO para sair");
        }

    }

    ConsoleKeyInfo tecla = Console.ReadKey(true);


    if (tecla.Key == ConsoleKey.Spacebar)
    {
        ativador = false;
    }
    

    Console.Clear();
}