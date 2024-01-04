using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Apple");
Iphone iphone = new Iphone("1234","Iphone 14 Pro Max", "BHS825D", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("56789","Modelo 1", "KHDNF4572", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
