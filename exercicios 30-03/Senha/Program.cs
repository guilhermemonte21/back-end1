// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Qual a senha?:");
int senha = int.Parse (Console.ReadLine());

if (senha == 1234 )
{
    Console.WriteLine($"Senha correta");
}


else
{
    Console.WriteLine($"Senha incorreta");
    
}
