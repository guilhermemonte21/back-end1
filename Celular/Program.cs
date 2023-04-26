using Celular;

Celulari cel = new Celulari();
do{
Console.WriteLine($@"
[1] Ligar
[2] manter desligado");

 cel.Ligar = Console.ReadLine();

switch(cel.Ligar)
{
    case "1":
    cel.ligado=true;
    
    break;
    case "2":
    Console.WriteLine($"...");
    break;

}
}while (cel.ligado != true);


do{
Console.WriteLine($@"
O que deseja fazer no celular
[1] Fazer uma ligacao
[2] Enviar uma mensagem
[3] Desligar");

cel.servico = Console.ReadLine();

switch(cel.servico)
{
    case "1":
    Console.WriteLine($"Fazendo a ligacao");
    break;
    case "2":
    Console.WriteLine($"Envie sua mensagem");
    string msg = Console.ReadLine();
    break;
    case "3":
    Console.WriteLine($"...");
    break;
    
    
    
}
}while (cel.servico != "0");
