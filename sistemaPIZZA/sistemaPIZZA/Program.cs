using System;
using sistemaPIZZA;

int opcoes = 0;
int opcaoSORVETE = 0;
double dinheiroAtual = 250.67;
int idInicial = 1;
int numero, num, opcaoPizza, opcaoBebida;

List<string> pedido = new List<string>();
double totalGeral = 0;

//----- classes importadas -----

peperone pizzaPepe = new peperone(0);
mussarela pizzaMusa = new mussarela(0);
margurrita pizzaMargueri = new margurrita(0);
bacon pizzaBaco = new bacon(0);
Portuguesa pizzaPortugue = new Portuguesa(0);
frangoCtupiry pizzaFrangoPiry = new frangoCtupiry(0);
sorvete_chocolate pizzaSorvChocoRango = new sorvete_chocolate(0);
sorvete_morango pizzaSorvMorango = new sorvete_morango(0);
sorvete_flocos pizzaSorvFloc = new sorvete_flocos(0);
chocolate_morango pizzaChoco = new chocolate_morango(0);

coca_cola cocaCola = new coca_cola(0);
fanta_uva fantaUva = new fanta_uva(0);
fanta_laranja fantaLaranja = new fanta_laranja(0);
guarana_antartida guarana = new guarana_antartida(0);
tubaina tubaina = new tubaina(0);
it_laranja itLaran = new it_laranja(0);
it_limao itLimao = new it_limao(0);
dolly_guarana dollyGua = new dolly_guarana(0);
dolly_limao dollyLima = new dolly_limao(0);

// --------------------------------

do
{
    Console.Clear();
    Console.WriteLine("1 - pedir pizza");
    Console.WriteLine("2 - pedir bebida");
    Console.WriteLine("3 - ver carrinho");
    Console.WriteLine("0 - Sair \n");

    Console.WriteLine("9 - Carteira\n\n");

    Console.Write("Digite sua opção: ");
    while (!int.TryParse(Console.ReadLine(), out opcoes))
    {
        Console.WriteLine("\n Digite apenas Numeros!\n");

        Console.Write("Digite sua opção: ");
    }


    switch (opcoes)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("qual pizza deseja?: \n");

            Console.WriteLine("===== Salgadas =====\n");

            Console.WriteLine("1 - Peperoni: " + pizzaPepe.valor);
            Console.WriteLine("2 - Margurrita: " + pizzaMargueri.valor);
            Console.WriteLine("3 - Mussarela: " + pizzaMusa.valor);
            Console.WriteLine("4 - Bacon: " + pizzaBaco.valor);
            Console.WriteLine("5 - Portuguesa: " + pizzaPortugue.valor);
            Console.WriteLine("6 - Frango com Catupiry: " + pizzaFrangoPiry.valor + "\n");

            Console.WriteLine("===== Doces =====\n");
            Console.WriteLine("7 - Chocolate c/ morango: " + pizzaChoco.valor);
            Console.WriteLine("8 - Sorvetes\n");

            Console.WriteLine("=================\n");

            Console.WriteLine("0 - Sair\n");

            Console.Write("Escolha: ");
            while (!int.TryParse(Console.ReadLine(), out opcaoPizza))
            {
                Console.WriteLine("\nDigite apenas Numeros!\n");
                Console.Write("Escolha: ");
            }

            switch (opcaoPizza)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    peperone pizzaPerone = new peperone(idInicial++);

                    pizzaPerone.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzasPepe = numero;
                    double qtTOTALpepe = qtPizzasPepe * pizzaPerone.valor;

                    Console.WriteLine("\nPela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzasPepe + " x " + pizzaPerone.valor);
                    Console.WriteLine("Total: " + qtTOTALpepe + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    string confirm = Console.ReadLine();

                    if(confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzasPepe + " x " + pizzaPerone.valor + " - R$: " + qtTOTALpepe + " - " + pizzaPerone.nome);
                        totalGeral += qtTOTALpepe;
                        pizzaPerone.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }
                    break;

                case 2:
                    Console.Clear();
                    margurrita pizzaMargue = new margurrita(idInicial++);

                    pizzaMargue.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaMargue = numero;
                    double qtTOTALmargue = qtPizzaMargue * pizzaMargue.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaMargue + " x " + pizzaMargue.valor);
                    Console.WriteLine("Total: " + qtTOTALmargue + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaMargue + " x " + pizzaMargue.valor + " - R$: " + qtTOTALmargue + " - " + pizzaMargue.nome);
                        totalGeral += qtTOTALmargue;
                        pizzaMargue.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }
                    break;

                case 3:
                    Console.Clear();
                    mussarela pizzaMussa = new mussarela(idInicial++);

                    pizzaMussa.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaMussa = numero;
                    double qtTOTALmussa = qtPizzaMussa * pizzaMussa.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaMussa + " x " + pizzaMussa.valor);
                    Console.WriteLine("Total: " + qtTOTALmussa + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaMussa + " x " + pizzaMussa.valor + " - R$: " + qtTOTALmussa + " - " + pizzaMussa.nome);
                        totalGeral += qtTOTALmussa;
                        pizzaMussa.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }
                    break;

                case 4:
                    Console.Clear();
                    bacon pizzaBacon = new bacon(idInicial++);

                    pizzaBacon.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaBacon = numero;
                    double qtTOTALBacon = qtPizzaBacon * pizzaBacon.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaBacon + " x " + pizzaBacon.valor);
                    Console.WriteLine("Total: " + qtTOTALBacon + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaBacon + " x " + pizzaBacon.valor + " - R$: " + qtTOTALBacon + " - " + pizzaBacon.nome);
                        totalGeral += qtTOTALBacon;
                        pizzaBacon.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }

                    break;

                case 5:
                    Console.Clear();
                    Portuguesa pizzaPortu = new Portuguesa(idInicial++);

                    pizzaPortu.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaPortu = numero;
                    double qtTOTALPortu = qtPizzaPortu * pizzaPortu.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaPortu + " x " + pizzaPortu.valor);
                    Console.WriteLine("Total: " + qtTOTALPortu + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaPortu + " x " + pizzaPortu.valor + " - R$: " + qtTOTALPortu + " - " + pizzaPortu.nome);
                        totalGeral += qtTOTALPortu;
                        pizzaPortu.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }
                    break;

                case 6:
                    Console.Clear();
                    frangoCtupiry pizzaFrango = new frangoCtupiry(idInicial++);

                    pizzaFrango.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaFrango = numero;
                    double qtTOTALFrango = qtPizzaFrango * pizzaFrango.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaFrango + " x " + pizzaFrango.valor);
                    Console.WriteLine("Total: " + qtTOTALFrango + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaFrango + " x " + pizzaFrango.valor + " - R$: " + qtTOTALFrango + " - " + pizzaFrango.nome);
                        totalGeral += qtTOTALFrango;
                        pizzaFrango.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }
                    break;

                case 7:
                    Console.Clear();
                    chocolate_morango pizzaChocoRango = new chocolate_morango(idInicial++);

                    pizzaChocoRango.exibirInformacao();

                    Console.Write("Quantas pizzas você deseja?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtPizzaChocorango = numero;
                    double qtTOTALchocorango = qtPizzaChocorango * pizzaChocoRango.valor;

                    Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                    Console.WriteLine(qtPizzaChocorango + " x " + pizzaChocoRango.valor);
                    Console.WriteLine("Total: " + qtTOTALchocorango + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtPizzaChocorango + " x " + pizzaChocoRango.valor + " - R$: " + qtTOTALchocorango + " - " + pizzaChocoRango.nome);
                        totalGeral += qtTOTALchocorango;
                        pizzaChocoRango.Preparacao();

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }

                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("Qual sorvete deseja na pizza: \n");

                    Console.WriteLine("1 - Sorvete de chocolate: " + pizzaSorvChocoRango.valor);
                    Console.WriteLine("2 - Sorvete de morango: " + pizzaSorvMorango.valor);
                    Console.WriteLine("3 - Sorvete de flocos: " + pizzaSorvFloc.valor + "\n");

                    Console.WriteLine("0 - Sair\n");

                    Console.Write("Digite: ");
                    opcaoSORVETE = int.Parse(Console.ReadLine());

                    switch (opcaoSORVETE)
                    {
                        case 1:
                            Console.Clear();
                            sorvete_chocolate pizzaSorvChoco = new sorvete_chocolate(idInicial++);

                            pizzaSorvChoco.exibirInformacao();

                            Console.Write("Quantas pizzas você deseja?: ");

                            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                            {
                                Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                                Console.Write("Quantas pizzas você deseja?: ");
                            }

                            int qtPizzaSorvChoco = numero;
                            double qtTOTALsorvChoco = qtPizzaSorvChoco * pizzaSorvChoco.valor;

                            Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                            Console.WriteLine(qtPizzaSorvChoco + " x " + pizzaSorvChoco.valor);
                            Console.WriteLine("Total: " + qtTOTALsorvChoco + "\n");

                            Console.Write("Quer continuar a compra ?: ");
                            confirm = Console.ReadLine();

                            if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                            {
                                Console.Clear();
                                pedido.Add(qtPizzaSorvChoco + " x " + pizzaSorvChoco.valor + " - R$: " + qtTOTALsorvChoco + " - " + pizzaSorvChoco.nome);
                                totalGeral += qtTOTALsorvChoco;
                                pizzaSorvChoco.Preparacao();

                                Console.ReadKey();
                                break;
                            }

                            else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPedido cancelado!");
                                Console.ReadKey();

                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nCancelado!");
                                Console.ReadKey();
                                continue;
                            }

                            break;
                        case 2:
                            Console.Clear();
                            sorvete_morango pizzaSorvMoran = new sorvete_morango(idInicial++);

                            pizzaSorvMoran.exibirInformacao();

                            Console.Write("Quantas pizzas você deseja?: ");

                            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                            {
                                Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                                Console.Write("Quantas pizzas você deseja?: ");
                            }

                            int qtPizzaSorvMoran = numero;
                            double qtTOTALsorvMoran = qtPizzaSorvMoran * pizzaSorvMoran.valor;

                            Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                            Console.WriteLine(qtPizzaSorvMoran + " x " + pizzaSorvMoran.valor);
                            Console.WriteLine("Total: " + qtTOTALsorvMoran + "\n");

                            Console.Write("Quer continuar a compra ?: ");
                            confirm = Console.ReadLine();

                            if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                            {
                                Console.Clear();
                                pedido.Add(qtPizzaSorvMoran + " x " + pizzaSorvMoran.valor + " - R$: " + qtTOTALsorvMoran + " - " + pizzaSorvMoran.nome);
                                totalGeral += qtTOTALsorvMoran;
                                pizzaSorvMoran.Preparacao();

                                Console.ReadKey();
                                break;
                            }

                            else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPedido cancelado!");
                                Console.ReadKey();

                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nCancelado!");
                                Console.ReadKey();
                                continue;
                            }

                            break;

                        case 3:
                            Console.Clear();
                            sorvete_flocos pizzaSorvFlocos = new sorvete_flocos(idInicial++);

                            pizzaSorvFlocos.exibirInformacao();

                            Console.Write("Quantas pizzas você deseja?: ");

                            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                            {
                                Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                                Console.Write("Quantas pizzas você deseja?: ");
                            }

                            int qtPizzaSorvFlocos = numero;
                            double qtTOTALsorvFlocos = qtPizzaSorvFlocos * pizzaSorvFlocos.valor;

                            Console.WriteLine("Pela quantidade de pizzas e o valor da pizza foi de: \n");
                            Console.WriteLine(qtPizzaSorvFlocos + " x " + pizzaSorvFlocos.valor);
                            Console.WriteLine("Total: " + qtTOTALsorvFlocos + "\n");

                            Console.Write("Quer continuar a compra ?: ");
                            confirm = Console.ReadLine();

                            if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                            {
                                Console.Clear();
                                pedido.Add(qtPizzaSorvFlocos + " x " + pizzaSorvFlocos.valor + " - R$: " + qtTOTALsorvFlocos + " - " +     pizzaSorvFlocos.nome);
                                totalGeral += qtTOTALsorvFlocos;
                                pizzaSorvFlocos.Preparacao();

                                Console.ReadKey();
                                break;
                            }

                            else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPedido cancelado!");
                                Console.ReadKey();

                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nCancelado!");
                                Console.ReadKey();
                                continue;
                            }

                            break;

                        case 0:
                            break;
                    }
                    

                    break;
            }

                break;

        case 2:
            Console.Clear();
            Console.WriteLine("qual Bebida deseja?: \n");

            Console.WriteLine("1 - Coca-Cola: " + cocaCola.valor);
            Console.WriteLine("2 - Fanta Uva: " + fantaUva.valor);
            Console.WriteLine("3 - Fanta Laranja: " + fantaLaranja.valor);
            Console.WriteLine("4 - Guaraná Antartida: " + guarana.valor);
            Console.WriteLine("5 - Tubaina: " + tubaina.valor);
            Console.WriteLine("6 - It laranja: " + itLaran.valor);
            Console.WriteLine("7 - It Limão: " + itLimao.valor);
            Console.WriteLine("8 - Dolly guaraná: " + dollyGua.valor);
            Console.WriteLine("9 - Dolly Limão: " + dollyLima.valor + "\n");

            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            while(!int.TryParse(Console.ReadLine(), out opcaoBebida))
            {
                Console.WriteLine("\nDigite apenas Numeros!\n");
                Console.Write("Escolha: ");
            }

            switch (opcaoBebida)
            {
                case 0:
                    break;

                case 1:
                    Console.Clear();
                    coca_cola coca = new coca_cola(idInicial++);

                    coca.exibirInformacao();

                    Console.WriteLine("Quantas bebidas você deseja ?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtCoca = numero;
                    double qtTOTALCoca = qtCoca * coca.valor;

                    Console.WriteLine("Pela quantidade de Refris e o valor da Total foi de: \n");
                    Console.WriteLine(qtCoca + " x " + coca.valor);
                    Console.WriteLine("Total: " + qtTOTALCoca + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    string confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtCoca + " x " + coca.valor + " - R$: " + qtTOTALCoca + " - " + coca.nome);
                        totalGeral += qtTOTALCoca;

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }

                    break;

                case 2:
                    Console.Clear();
                    fanta_uva fnt_uva = new fanta_uva(idInicial++);

                    fnt_uva.exibirInformacao();

                    Console.WriteLine("Quantas bebidas você deseja ?: ");

                    while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("\nQuantidade inválida! Digite apenas números maiores que zero.");
                        Console.Write("Quantas pizzas você deseja?: ");
                    }

                    int qtfnt_uva = numero;
                    double qtTOTALfnt_uva = qtfnt_uva * fnt_uva.valor;

                    Console.WriteLine("Pela quantidade de Refris e o valor da Total foi de: \n");
                    Console.WriteLine(qtfnt_uva + " x " + fnt_uva.valor);
                    Console.WriteLine("Total: " + qtTOTALfnt_uva + "\n");

                    Console.Write("Quer continuar a compra ?: ");
                    confirm = Console.ReadLine();

                    if (confirm.ToLower() == "sim" || confirm.ToLower() == "s")
                    {
                        Console.Clear();
                        pedido.Add(qtfnt_uva + " x " + fnt_uva.valor + " - R$: " + qtTOTALfnt_uva + " - " + fnt_uva.nome);
                        totalGeral += qtTOTALfnt_uva;

                        Console.ReadKey();
                        break;
                    }

                    else if (confirm.ToLower() == "não" || confirm.ToLower() == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nPedido cancelado!");
                        Console.ReadKey();

                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nCancelado!");
                        Console.ReadKey();
                        continue;
                    }

                    break;
            }

            break;

        case 3:
            Console.Clear();
            Console.WriteLine("=== RESUMO DO PEDIDO ===\n");

            foreach (string item in pedido)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTotal a pagar R$: " + totalGeral);
            Console.WriteLine("Dinheiro atual R$: " + dinheiroAtual + "\n");

            Console.WriteLine("Confirmar pagamento?: ");
            string confirmPagamento = Console.ReadLine();

            if(confirmPagamento.ToLower() == "sim" || confirmPagamento.ToLower() == "s")
            {
                if(totalGeral <= dinheiroAtual)
                {
                    Console.Clear();
                    Console.WriteLine("Pagamento Concluido!");
                    Console.WriteLine("O pedido vai se entregue em breve!\n");
                    dinheiroAtual = dinheiroAtual - totalGeral;

                    idInicial = 1;

                    pedido.Clear();
                    totalGeral = 0;
                    

                    Console.WriteLine("Digite qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("dinheiro Insuficiente!");
                    Console.ReadKey();
                    break;
                }
            }

            else if (confirmPagamento.ToLower() == "não" || confirmPagamento.ToLower() == "n" || confirmPagamento.ToLower() == "nao")
            {
                Console.WriteLine("\nPagamento cancelado!\n");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();

                break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            break;

        case 9:
            Console.Clear();
            Console.WriteLine("======= Carteira =======\n");
            Console.WriteLine("Dinheiro atual R$:" + dinheiroAtual);
            Console.WriteLine("========================\n");

            Console.WriteLine("Pressione qualquer tecla para voltar");

            Console.ReadKey();
            break;

        case 0:
            Console.Clear();
            Console.WriteLine("Até mais!\n");
            Console.WriteLine("Pressione qualquer tecla para sair...");

            Console.ReadKey();
            break;

        default:
            break;
    }
}

while (opcoes != 0);
