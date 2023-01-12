using ExercicioPOOClasseAbstrata.Models;

Console.WriteLine("Smartphone IPHONE: \n");
Smartphone iphone = new Iphone("(51)123333", "Iphone 17", "423432", 128);
iphone.Ligar();
Console.WriteLine();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n====================================================================");

Console.WriteLine("Smartphone MOTOROLA:\n ");
Smartphone nokia = new Motorola("(19)12341234", "MOTO G15", "321312", 32);
nokia.ReceberLigacao();
Console.WriteLine();
nokia.InstalarAplicativo("WhatsApp Business");
Console.ReadKey();
