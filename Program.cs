using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Iphone12");
Iphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);
iphone.Ligar();
iphone.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");


Console.WriteLine("\n");


Console.WriteLine("Testando Nokia3310");
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");


