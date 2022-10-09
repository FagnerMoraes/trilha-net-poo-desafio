using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456",modelo: "Modelo 1", imei: "11111111",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Github");
nokia.ReceberLigacao();
nokia.MostrarConfiguracao();


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Nokia(numero: "45678",modelo: "Modelo 2", imei: "2222222",memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
iphone.MostrarConfiguracao();