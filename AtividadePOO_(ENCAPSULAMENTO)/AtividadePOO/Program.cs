using AtividadePOO;

Conta conta1 = new Conta();

conta1.nome = "Luccas";
conta1.nrConta = 147569;
conta1.setSaldo(10);

Console.WriteLine(conta1.nome + "\n");

Console.WriteLine(conta1.nrConta + "\n");

Console.WriteLine(conta1.getSaldo() + "\n");

Console.ReadKey();