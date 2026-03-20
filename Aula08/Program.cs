
using Aula08;

var contaPoupanca = new ContaBancaria(1234, "Lilo");
var contaEspecial = new ContaBancaria(1234, "Lilo", 1000);
contaEspecial.Depositar(1000); // int
contaEspecial.Depositar(1000.00); // double
contaEspecial.Depositar(1000.00m); // decimal

Console.WriteLine(contaEspecial.GetSaldo());

if (contaEspecial.Sacar(4000))
{
    Console.WriteLine("Saque efetuado com sucesso!");
}
else
{
    Console.WriteLine("Saldo insuficiente");
}

Console.WriteLine(contaEspecial.GetSaldo());
Console.WriteLine(contaEspecial.SaldoTotal);



Console.ReadLine();