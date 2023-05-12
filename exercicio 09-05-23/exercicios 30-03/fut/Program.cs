// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Quantos Gols a equipe 1 fez?:");
int team1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Quantos Gols a equipe 2 fez?:");
int team2 = int.Parse (Console.ReadLine());

if ( team1 > team2 )
{
    Console.WriteLine($"A equipe 1 venceu");
    
}
else if( team1 == team2 )
{
    Console.WriteLine($"A partida empatou");
    
}
else 
{
    Console.WriteLine($"A equipe 2 venceu");
    
}




