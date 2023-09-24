
Console.Write("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero;

int unidades = restante % 10;
restante /=10;

int dezenas =  restante % 10;
restante /=10;

int centenas = restante;

Console.WriteLine($"\n O número {numero} possui:");
Console.WriteLine($"{unidades, 10} unidade(s)");
Console.WriteLine($"{dezenas, 10} dezenas(s)");
Console.WriteLine($"{centenas, 10} centena(s).");
