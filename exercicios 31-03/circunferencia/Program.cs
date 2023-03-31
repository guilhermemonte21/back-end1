// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira o raio da circunferencia:");
double raio = int.Parse(Console.ReadLine());

double area = Math.PI * (Math.Pow(raio, 2));

double comprimento = 2*Math.PI*raio;

Console.WriteLine($"O comprimento dessa cincunferencia é {comprimento} e a area é {area}");


