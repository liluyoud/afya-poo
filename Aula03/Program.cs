using Aula03;

Console.WriteLine("Testando a classe aluno...");

var aluno = new Aluno();
Console.WriteLine("Informações do aluno:"); 

Console.Write($"Nome: ");
aluno.nome = Console.ReadLine();

Console.Write($"Matrícula: ");
aluno.matricula = Console.ReadLine();

Console.Write($"Email: ");
aluno.email = Console.ReadLine();

Console.WriteLine("Digite as notas do aluno:");
Console.Write($"Nota 1: ");
aluno.n1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Nota 2: ");
aluno.n2 = Convert.ToDouble(Console.ReadLine());

var media = aluno.CalcularMedia();
Console.WriteLine($"A média do aluno {aluno.nome} é: {media}");

if (aluno.EstaAprovado())
{
    Console.WriteLine($"O aluno {aluno.nome} está aprovado.");
}
else
{
    Console.WriteLine($"O aluno {aluno.nome} está reprovado.");
}

Console.ReadKey();