using AulaPOO1_Base;

Pessoa pessoa1 = new Pessoa();


Console.Write("digite seu nome: ");
pessoa1.nome = Console.ReadLine();

Console.Write("digite seu cpf: ");
pessoa1.cpf = Console.ReadLine();

Console.Write("digite sua data de nascimento: ");
pessoa1.dataNascimento = DateOnly.Parse(Console.ReadLine());


Console.Clear();

Console.WriteLine("nome: " + pessoa1.nome);

Console.WriteLine("cpf: " + pessoa1.cpf);

Console.WriteLine("data de nascimento: " + pessoa1.dataNascimento);

Console.ReadKey();