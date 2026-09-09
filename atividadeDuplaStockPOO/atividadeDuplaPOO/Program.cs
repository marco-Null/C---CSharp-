using atividadeDuplaPOO;
// criar um sistema de controle de stock, que ultilize emcapsulamento e construtor

Stock[] produto = new Stock[67];

double DinheiroAtual = 100.67;

string a, b, c;
bool ativador = true;
int quantidadeProd = 0;

Stock LocalizacaoProduto = null;

while (ativador == true) {

    Console.WriteLine("-----Sistema de STOCK-----");
    Console.WriteLine("");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Comprar");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("\n");

    Console.Write("Digite: ");
    a = Console.ReadLine();

    Console.Clear();

    if(a == "1")
    {
        Console.WriteLine("quantos produtos deseja cadastrar ?");
        Console.Write("Digite: ");
        quantidadeProd = int.Parse(Console.ReadLine());

        if(quantidadeProd > 0)
        {
            for (int i = 1; i < quantidadeProd + 1; i++)
            {
                produto[i] = new Stock();

                produto[i].setID(i);
                Console.Clear();
                Console.Write("Digite o nome do "+ i +"° produto: ");
                produto[i].nome = Console.ReadLine();

                Console.Write("Digite o preço do "+ i +"° produto: ");
                produto[i].setPreco(double.Parse(Console.ReadLine()));

                Console.Write("Digite a quantidade do "+ i +"° produto: ");
                produto[i].setQuantidade(int.Parse(Console.ReadLine()));

                Console.WriteLine("Digite a descrição do "+ i +"° produto: ");
                produto[i].descricao = Console.ReadLine();

            }

            Console.Clear();
        }

        else
        {
            Console.WriteLine("Você não quer cadastrar, ok 👍");
            Console.ReadKey();
            Console.Clear();
            continue;
        }
        

    }

    else if(a == "2")
    {
        if (quantidadeProd <= 0)
        {
            Console.WriteLine("Não possui nenhum produto a venda");
            Console.ReadKey();
            Console.Clear();
            continue;
        }

        else if (a == "2")
        {
            if (quantidadeProd <= 0)
            {
                Console.WriteLine("Não possui nenhum produto a venda");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            for (int z = 1; z < quantidadeProd + 1; z++)
            {
                Console.WriteLine("ID: " + produto[z].getID());
                Console.WriteLine("Nome: " + produto[z].nome);
                Console.WriteLine("Preço: R$ " + produto[z].getPreco());
                Console.WriteLine("Quantidade: " + produto[z].getQuantidade());
                Console.WriteLine("Descrição: " + produto[z].descricao);
                Console.WriteLine("---------------------------\n");
            }

            Console.WriteLine("\nDigite o nome do produto que você quer:");
            Console.WriteLine("- sair -> 0 -");
            Console.Write("Produto: ");
            b = Console.ReadLine();

            if (b == "0")
            {
                Console.WriteLine("\nVocê saiu");
                Console.Clear();
                continue;
            }

            LocalizacaoProduto = null;

            for (int i = 1; i < quantidadeProd + 1; i++)
            {
                if (produto[i] != null && produto[i].nome == b)
                {
                    LocalizacaoProduto = produto[i];
                    break;
                }
            }

            if (LocalizacaoProduto == null)
            {
                Console.WriteLine("Produto não encontrado!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            Console.Clear();

            Console.WriteLine("Produto encontrado!");
            Console.WriteLine("ID: " + LocalizacaoProduto.getID());
            Console.WriteLine("Nome: " + LocalizacaoProduto.nome);
            Console.WriteLine("Preço: R$ " + LocalizacaoProduto.getPreco());
            Console.WriteLine("Quantidade: " + LocalizacaoProduto.getQuantidade());

            Console.WriteLine("\nVocê possui: R$ " + DinheiroAtual);
            Console.WriteLine("Você irá gastar: R$ " + LocalizacaoProduto.getPreco());

            Console.WriteLine("\nConfirme a compra");
            Console.WriteLine("Sim / Não");
            c = Console.ReadLine();

            if (c == "Sim" || c == "SIM" || c == "sim" ||
                c == "s" || c == "ss" || c == "S" || c == "SS")
            {
                if (DinheiroAtual >= LocalizacaoProduto.getPreco())
                {
                    DinheiroAtual -= LocalizacaoProduto.getPreco();
                    int novaQuantidade = LocalizacaoProduto.getQuantidade() - 1;
                    LocalizacaoProduto.setQuantidade(novaQuantidade);

                    Console.WriteLine("\nCompra feita!");
                    Console.WriteLine("Você gastou: R$ " + LocalizacaoProduto.getPreco());
                    Console.WriteLine("Você possui: R$ " + DinheiroAtual);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Dinheiro insuficiente!");
                    Console.Clear();
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao início");
            Console.ReadKey();
            Console.Clear();
        }
    }

    else if(a == "3")
    {
        ativador = false;

        Console.WriteLine("até a proxima");
        break;
    }



}




Console.ReadKey();