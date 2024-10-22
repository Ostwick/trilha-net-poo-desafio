using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Criando um celular Nokia
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "111222333444", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine(); // Quebra de linha para separação

// Criando um celular iPhone
Smartphone iphone = new Iphone(numero: "987654321", modelo:  "iPhone 14", imei: "555666777888", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
