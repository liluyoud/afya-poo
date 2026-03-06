using static System.Console;
using Aula07;

WriteLine("Aprendendo métodos");

Produto produto = new();
produto.descricao = "TV LCD Samsung 55";
produto.quantidade = 3;
produto.valor = 2199.99;

WriteLine(produto.quantidade);
produto.comprar(); // 4
WriteLine(produto.quantidade); // 4
WriteLine(produto.valorEstoque); // 4 * 2199.99
if (produto.vender(10))
{
    WriteLine("Venda realizada");
} 
else
{
    WriteLine("Estoque Insuficiente");
}
; // 1
WriteLine(produto.quantidade);


ReadLine();
