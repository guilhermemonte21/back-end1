// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Qual é o seu nome?");
string name = Console.ReadLine();

Console.WriteLine($"Qual é o seu orçamento?");
int money = int.Parse (Console.ReadLine());

Console.WriteLine($"Qual o seu gasto mensal?");
int gastos = int.Parse (Console.ReadLine());

if ( money >= gastos ) 
{
    Console.WriteLine($"Gastos dentro do orçamento");
    
}

else if ( money < gastos)
{
    Console.WriteLine($"Orçamento estourado");
    
}


