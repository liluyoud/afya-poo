using static System.Console;
using Aula02;

Clear();

// var objeto = new Classe(); // Exemplo de criação de um objeto a partir de uma classe
var celular = new Celular();
celular.marca = "Samsung";
celular.modelo = "Galaxy S21";  
celular.preco = 4999.99;
WriteLine($"Informações do celular: {celular.ToString()}\n\n");

var conta = new Conta();
conta.numero = 12345;
conta.titular = "João Silva";       
conta.ativa = true;
conta.Depositar(100); // Chamada do método para depositar dinheiro na conta
WriteLine($"Informações da conta:\n{conta.ToString()}\n");
conta.Sacar(30); // Chamada do método para sacar dinheiro da conta
WriteLine($"Informações da conta após o saque:\n{conta.ToString()}");

ReadKey();