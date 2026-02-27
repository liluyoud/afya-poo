using Aula05;
using static System.Console;

var aluno = new Aluno();

WriteLine("Calculando a média");
Write("Nome: ");
aluno.nome = ReadLine();

Write("N1: ");
aluno.n1 = Convert.ToDouble(ReadLine());

Write("N2: ");
aluno.n2 = Convert.ToDouble(ReadLine());

WriteLine(aluno);
ReadKey();
