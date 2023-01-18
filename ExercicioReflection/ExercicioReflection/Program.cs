using System.Runtime.Intrinsics.X86;

using ExercicioReflection;
using System.Reflection;
//Crie uma aplicação Console que contenha uma cópia da classe abaixo.
//    public class Student
//{
//    public string Name { get; set; }
//    public string University { get; set; }
//    public int RollNumber { get; set; }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"{Name} - {University} - {RollNumber}");
//    }
//}
//Em seguida, na classe Program, crie um método chamado DisplayPublicProperties que, usando Reflection, exiba todas as Propriedades Públicas da classe Student. No método Main da classe Program, coloque uma chamada para o método DisplayPublicProperties.
//Agora, adicione na classe Program um outro método chamado CreateInstance que
//Use Reflection para criar uma instância (objeto) da classe Student e, em seguida;
//Use Reflection para preencher as propriedades públicas do objeto. Não é necessário se preocupar com a adição de novas propriedades, isto é, sempre serão preenchidos apenas o Name, University e RollNumber.
//Use Reflection para chamar o método DisplayInfo do objeto criado no item 2.1.


Student student = new Student();
Console.Write("Propriedades públicas da classe: ");
DisplayPublicProperties(student);


Console.WriteLine();

Type type = student.GetType();
object ins = Activator.CreateInstance(type);

PropertyInfo propName = type.GetProperty("Name");
propName.SetValue(ins, "Kaio Mazzotti", null);

PropertyInfo propUniversity = type.GetProperty("University");
propUniversity.SetValue(ins, "UFRGS", null);

PropertyInfo propRollNumber = type.GetProperty("RollNumber");
propRollNumber.SetValue(ins, 208081, null);

MethodInfo mostrarMetodo = type.GetMethod("DisplayInfo");

object resultado = mostrarMetodo.Invoke(ins, null);


void DisplayPublicProperties(object obj)
{
    Type type = obj.GetType();
    Console.WriteLine($"{obj}\n");
    foreach (PropertyInfo prop in type.GetProperties())
    {
        Console.WriteLine(prop.Name);
    }
}