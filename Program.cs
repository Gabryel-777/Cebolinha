string cebola;
Console.Clear();
Console.Write("Escreva uma frase que você goste (de preferencia uma frase que contenha R, r.) :");

cebola = Console.ReadLine()!
.Replace("r","l")
.Replace("R","L");
Console.Write("ANALISANDO");
Thread.Sleep(1500);
Console.Write(" .");
Thread.Sleep(1500);
Console.Write(".");
Thread.Sleep(1500);
Console.Write(".");
Console.WriteLine("");
Console.WriteLine($"Cebolinha repetiu sua frase : {cebola}");
