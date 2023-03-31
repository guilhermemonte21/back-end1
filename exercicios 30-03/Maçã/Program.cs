// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Oii, quantas maçãs você vai querer?:");
int maçãs = int.Parse(Console.ReadLine());


float resu = ( maçãs * 0.25f );
float valor = ( maçãs * 0.30f );

if( maçãs <= 12 ) 

{

 Console.WriteLine($"Ok, tudo isso vai dar R${valor} reais");
 
}
 else
 {
    
    Console.WriteLine($"OK, tudo isso vai dar R${resu} reais");
    
 }