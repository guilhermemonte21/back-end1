// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Insira sua frenquencia em porcetagem:");
float frenquencia = float.Parse (Console.ReadLine());

Console.WriteLine($"Insira sua primeira nota:");
float nota1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Insira sua segunda nota:");
float nota2 = int.Parse (Console.ReadLine());

Console.WriteLine($"Insira sua terceira nota:");
float nota3 = int.Parse (Console.ReadLine());


float media = ( (nota1 + nota2 + nota3) / 3);

if ((frenquencia>=75)&&(media>=7))
{
    Console.WriteLine($"aprovado");
    
}

else if((frenquencia>=75)&&(media>=3 && media<7) )
{
    Console.WriteLine($"Recuperação");
    
}
else if((frenquencia<75)&&(media < 3))
{
    Console.WriteLine($"Reprovado");
    
}




