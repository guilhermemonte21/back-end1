

Console.WriteLine($"Boa tarde! Bem-vindo a lanchonete do marcos, qual bebida voce deseja?");
Console.WriteLine($"1-Coca");
Console.WriteLine($"2-fanta");
Console.WriteLine($"3-pepsi");
Console.WriteLine($"4-Guarana");
int pedido=int.Parse(Console.ReadLine());

Console.WriteLine($"Deseja adicionar gelo a sua bebida");
Console.WriteLine($"1-Sim 2-Não");
int gelo =int.Parse(Console.ReadLine());


bool resultado = bool.Parse(Console.ReadLine());
int opcao = int.Parse(Console.ReadLine());
switch(opcao)
{
    case 1:
    resultado = (pedido ==1 || gelo == 1);
    Console.WriteLine($"Coca com gelo saindo");
    break;

    case 2:
    resultado = (pedido == 2 || gelo == 1);
    Console.WriteLine($"fanta com gelo saindo");
    break;
    case 3:
    resultado = (pedido == 3 || gelo== 1);
    Console.WriteLine($"Pepsi com gelo saindo");
    break;

    case 4:
    resultado = (pedido == 4 || gelo==1);
    Console.WriteLine($"Guarana com gelo saindo");
    break;

    case 5:
    resultado = (pedido==1 || gelo==2);
    Console.WriteLine($"Coca sem gelo saindo");
    break;

    case 6:
    resultado = (pedido==2 || gelo==2);
    Console.WriteLine($"fanta sem gelo saindo");
    break;
    case 7:
    resultado = (pedido==3||gelo==2);
    Console.WriteLine($"Pepsi sem gelo saindo");
    break;
    case 8:
    resultado = (pedido==4||gelo==2);
    Console.WriteLine($"Guarana sem gelo saindo");
    break;
    default:
    Console.WriteLine($"Pedido invalido");
    break;
    
    
}
Console.WriteLine($"Seu pedido e {opcao}");







