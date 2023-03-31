// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira a letra:");
char letra = char.Parse (Console.ReadLine());



if ( letra=='a'|| letra=='e'||letra== 'i'||letra== 'o'||letra == 'u')
{
    Console.WriteLine($"Essa letra é uma vogal");
    
}
else
{
    Console.WriteLine($"Essa letra é uma consoante");
    
}

