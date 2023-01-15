// See https://aka.ms/new-console-template for more information
using ExercicioPessoaMaisVelhaCsharp;

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
string nomeDaPrimeira = Console.ReadLine();
Console.Write("Idade: ");
int idadeDaPrimeira = int.Parse(Console.ReadLine());
Pessoa primeira = new Pessoa(nomeDaPrimeira, idadeDaPrimeira);

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
string nomeDaSegunda = Console.ReadLine();
Console.Write("Idade: ");
int idadeDaSegunda = int.Parse(Console.ReadLine());
Pessoa segunda = new Pessoa(nomeDaSegunda, idadeDaSegunda);

primeira.MaisVelha(primeira,segunda);
