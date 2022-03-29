string frasecomR, frasecomL;

Console.Write("Digite uma frase: ");
frasecomR = Console.ReadLine()!;

frasecomL = frasecomR 
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine(frasecomL); 