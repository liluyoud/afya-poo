using static System.Console;
using Aula02;

Clear();

// var objeto = new Classe(); // Exemplo de criação de um objeto a partir de uma classe
var celular = new Celular();
celular.marca = "Samsung";
celular.modelo = "Galaxy S21";  
celular.preco = 4999.99;

WriteLine("Informações do celular:");
WriteLine($"Marca: {celular.marca}");
WriteLine($"Modelo: {celular.modelo}");
WriteLine($"Preço: {celular.preco}");

var conta = new Conta();
conta.numero = 12345;
conta.titular = "João Silva";       
conta.ativa = true;

WriteLine("Informações da conta:");
WriteLine($"Número: {conta.numero}");
WriteLine($"Titular: {conta.titular}");
WriteLine($"Ativa: {conta.ativa}");