//Escreva um programa orientado a objetos com as seguintes características:

//Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade; Uma classe Aluno 
//    derivada da classe Pessoa, com um método IrParaEscola; Uma classe Professor derivada da classe Pessoa,
//    com um método Explicar que recebe como parâmetro um assunto; Na classe principal:

//Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
//Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
//Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.

using ExercícioRevisãoPOO.Models;

Pessoa pessoa1 = new Pessoa("João", 25);
pessoa1.Cumprimentar();
pessoa1.DizerIdade();
Console.WriteLine("\n------------------\n");
Aluno a1 = new Aluno("Kaio", 21);
a1.IrParaEscola();
a1.Cumprimentar();
a1.DizerIdade();
Console.WriteLine("\n------------------\n");
Professor p1 = new Professor("Michael", 30);
p1.Cumprimentar();
p1.DizerIdade();
p1.Explicar("POO");
