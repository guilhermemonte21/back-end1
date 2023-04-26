// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int contador = 0;



Console.WriteLine($"Telefonou para a vítima?(Responda com true ou false)");
bool bi = bool.Parse(Console.ReadLine());
if (bi==true)
{
    contador++;
}

Console.WriteLine($"Esteve no local do crime?(Responda com true ou false)");
bool ci =bool.Parse(Console.ReadLine());
if (ci==true)
{
    contador++;
}


Console.WriteLine($"Mora perto da vítima?(Responda com true ou false)");
bool di = bool.Parse(Console.ReadLine());
if (di==true)
{
    contador++;
}
Console.WriteLine($"Devia para a vítima?(Responda com true ou false)");
bool ei = bool.Parse(Console.ReadLine());
if (ei==true)
{
    contador++;
}
Console.WriteLine($"Já trabalhou com a vítima?(Responda com true ou false)");
bool ii = bool.Parse(Console.ReadLine());
if (ii==true)
{
    contador++;
}



if( contador==2)
{
    Console.WriteLine($"Suspeita");
    
}
else if(contador==3 &&contador==4)
{
    Console.WriteLine($"Cúmplice");
    
}
else if(contador==5)
{
    Console.WriteLine($"culpado");
    
}
else if(contador==1)
{
    Console.WriteLine($"inocente");
    
}