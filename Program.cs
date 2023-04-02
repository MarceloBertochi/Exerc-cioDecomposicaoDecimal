int numero; // criado uma variável para trablhar com números inteiros do tipo inteiro


Console.WriteLine("*-- Decomposição Decimal --*\n"); // informando o nome do exercicio - \n pula linha
Console.WriteLine("Digite um número inteiro"); // informando para dig
numero = Convert.ToInt32 (Console.ReadLine()); // converte a string numérica digitada em número inteiro
Console.WriteLine(); // Console.WriteLine() sem valor faz uma quebra de linha. 
Console.WriteLine("O número que você digitou possui:");

/* CONSEGUI FAZER SOZINHO ATÉ AQUI */

int restante = numero; // Não consegui entender esse restante

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.WriteLine($"\nO número {numero} possui:");
Console.WriteLine($"{unidades,10} unidade(s)");
Console.WriteLine($"{dezenas,10} dezenas(s)");
Console.WriteLine($"{centenas,10} centena(s).");