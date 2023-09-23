using DesafioPOO.Models;

Console.WriteLine("Teste do Iphone");
Smartphone iphone = new Iphone("123456789", "Iphone 12 Pro", "123123123", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Teste do Nokia");
Smartphone nokia = new Nokia("987654321", "Nokia tijolão", "321321321", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");