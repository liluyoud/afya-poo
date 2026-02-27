using static System.Console;
using Aula04;
using System.Runtime.CompilerServices;

// salário é do tipo double
double salario;
// nome é do tipo string
string nome;
// dependentes é do tipo int
int dependentes;

// x é do tipo Celular
// declarar os objetos x, y e z do tipo Celular
Celular x, y, z;

// criar o objeto = alocar espaço na memória = instanciar uma classe
x = new Celular();
y = new Celular();
z = new Celular();

// declarar e criar ao mesmo tempo
int a1 = 5;
var a2 = 5.0;

Celular c1 = new Celular();
var c2 = new Celular();
Celular c3 = new();


Professor p1 = new();
p1.nome = "Lilo";
p1.email = "lilo@mail.com";