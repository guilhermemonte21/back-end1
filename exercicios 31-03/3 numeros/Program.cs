// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira o primeiro numero");
int first = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo numero");
int second = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o terceiro numero");
int third = int.Parse(Console.ReadLine());


if(first>second && first>third && second<third)
{
    Console.WriteLine($"O {first} é o maior e o menor é o {second}");
    
}
else if (first<second&&first<third&&second<third)
{
    Console.WriteLine($"O {third} é o maior e o menor é o {first} ");
    
}
else if(first>second&&first<third&&second<third)
{
    Console.WriteLine($"O {third} é o maior e o menor é o {second}");
    
}
else if(first<second&&first>third&&second>third)
{
   Console.WriteLine($"O {second} é o maior e o menor é o {third}");
   
}
else if(first>second&&first>third&&second>third)
{
    Console.WriteLine($"O {first} é o maior e o menor é o {third}");
    
}
else if(first<second&&first<third&&second>third)
{
    Console.WriteLine($"O {second} é o maior e o menor é o {first}");
    
}

