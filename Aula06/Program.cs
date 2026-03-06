using Aula06;
using static System.Console;

ContaBancaria conta = new();
WriteLine(conta.numero);
WriteLine(conta.titular);
WriteLine(conta.saldo);
WriteLine(conta.ativo);

if (conta.titular == null)
{
    WriteLine("a string é nula");
}

ReadKey();
