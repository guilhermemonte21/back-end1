// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira a medida em cm do primeiro lado do triangulo:");
int first = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida em cm do segundo lado do triangulo");
int second = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida em cm do terceiro lado do triangulo");
int third = int.Parse(Console.ReadLine());

if((first==second )&&( second==third) )
{
    Console.WriteLine($"Triangulo Equilatero");
    
}
else if((first != second && second!=third && first!=third))
{
    Console.WriteLine($"triangulo isosceles");
    
}
else
{
    Console.WriteLine($"triangulo escaleno");
    
}



