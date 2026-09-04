using atividadeDuplaPOO;
// criar um sistema de controle de stock, que ultilize emcapsulamento e construtor

Stock[] produto = new Stock[67];

for (int i = 1; i < 2; i++)
{
    produto[i] = new Stock();



    Console.Write("Digite o nome do produto: ");
    produto[i].nome = Console.ReadLine();

    Console.Write("Digite o preço do produto: ");
    produto[i].preco = double.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade do produto: ");
    produto[i].quantidade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descrição do produto: ");
    produto[i].descricao = Console.ReadLine();


}

Console.Clear();

for (int z = 1; z < 2; z++)
{
    Console.WriteLine("o nome do produto " + z + "°: " + produto[z].nome);
    Console.WriteLine("o valor do produto " + z + "°: " + produto[z].setProduto);
    Console.WriteLine("a quantidade do produto " + z + "°: " + produto[z].quantidade);
    Console.WriteLine("a descrição do produto " + z + "°: " + produto[z].descricao);

}

Console.ReadKey();