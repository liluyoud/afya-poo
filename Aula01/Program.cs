using static System.Console;

Clear();
ResetColor();

WriteLine("-------------------------------");
WriteLine("     Primeiro Programa C#     ");
WriteLine("-------------------------------\n");
WriteLine(" [1] Dizer Alo, Mundo!");
WriteLine(" [2] Calcular média!");
WriteLine(" [3] Mostrar o dobro de um número!");
WriteLine(" [4] Dizer se é par ou impar!\n");
WriteLine("-------------------------------");

ForegroundColor = ConsoleColor.Yellow;
Write(" Selecione uma opção: ");
var opcao = ReadLine();
ResetColor();

WriteLine("\n Você escolheu a opção: " + opcao);
WriteLine("\n Pressione qualquer tecla para finalizar...");
ReadKey();