using Aula06;
using static System.Console;

var produto = new Produto("TV LCD", 1999.99);

// o que pode ser feito nesse produto
//produto.quantidade = -1000;
WriteLine("Comprar");
produto.comprar();
WriteLine(produto);
ReadKey();

WriteLine("Comprar");
produto.comprar();
WriteLine(produto);ReadKey();

WriteLine("Vender");
produto.vender();
WriteLine(produto);ReadKey();

WriteLine("Vender");
produto.vender();
WriteLine(produto);ReadKey();

WriteLine("Vender");
produto.vender();
WriteLine(produto);ReadKey();


WriteLine(produto);
ReadKey();
