using ExercicioInterface.Models;

Animal leao = new Leao("Leoa",'F', 13, true, false, "Castanhos", 8, true);
leao.Apresentar();
Console.WriteLine();
Animal chacal = new Chacal("Lobo", 'M', 15, true, false, "Variados", 8, true);
chacal.Apresentar();
Console.WriteLine();
Animal morcego = new Morcego("Morcego", 'F', 40, true, false, "Pretos", 6, false, 200, 39.5);
morcego.Apresentar();
Console.WriteLine();
