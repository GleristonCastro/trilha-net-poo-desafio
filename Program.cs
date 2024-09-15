using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "123456789", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "987654321", modelo: "Modelo 2", imei: "987654321", memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");