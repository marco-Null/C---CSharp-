using System;
using sobrecarga_de_construtores;

Frutas fruta1 = new Frutas();
Frutas fruta2 = new Frutas("banana");
Frutas fruta3 = new Frutas("banana", 67);

Console.WriteLine(fruta1.nomeFruta);
Console.WriteLine(fruta1.quantidadeFruta);

Console.WriteLine();

Console.WriteLine(fruta2.nomeFruta);
Console.WriteLine(fruta2.quantidadeFruta);

Console.WriteLine();

Console.WriteLine(fruta3.nomeFruta);
Console.WriteLine(fruta3.quantidadeFruta);
Console.ReadKey();