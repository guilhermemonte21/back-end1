// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Qual dia voce nasceu?:");
int day = int.Parse (Console.ReadLine());

Console.WriteLine($"Qual a ordem do mes que voce nasceu?");
int mes = int.Parse (Console.ReadLine());

Console.WriteLine($"Qual ano voce nasceu?:");
int ano = int.Parse (Console.ReadLine());

if(day>31 )
{
    Console.WriteLine($"Essa data é invalida, pois os meses não tem mais que 31 dias");
    
}
else if (mes>12)
{
    Console.WriteLine($"Essa data é inválida, pois só existem 12 meses ");
    
}
else if(ano>2013)
{
    Console.WriteLine($"Essa data é invalida, pois estamos em 2013 ");
    
}
else
{
    Console.WriteLine($"Que Legal!!");
    
}
