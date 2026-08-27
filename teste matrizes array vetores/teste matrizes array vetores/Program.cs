using System;
using teste_matrizes_array_vetores;

pessoa[] pessoas = new pessoa[5];

for (int i = 0; i < 5; i++)
{
    pessoas[i] = new pessoa();

    Console.Write("digite o nome da pessoa: ");
    pessoas[i].nome = Console.ReadLine();

    Console.Write("Digite a idade dessa pessoa: ");
    pessoas[i].idade = int.Parse(Console.ReadLine());
}

Console.Clear();

for(int z = 0; z < 5; z++)
{
    Console.WriteLine(pessoas[z].nome);
    Console.WriteLine("o " + pessoas[z].nome + " possui " + pessoas[z].idade + " anos");
    Console.WriteLine();
}




Console.ReadKey();



