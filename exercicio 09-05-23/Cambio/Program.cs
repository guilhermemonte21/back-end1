using Cambio;

Console.WriteLine($@"
    Menu:
    [1] dólar para real
    [2] real para dólar
    [3] sair");
    string option=Console.ReadLine();

    if(option=="3")
    {
        Console.WriteLine($"Encerrando sistema");
        
    }

    

    
    


    switch(option)
    {
        case "1" :
        Console.WriteLine($"Insira o Valor:");
        Cambi.value = double.Parse(Console.ReadLine());
        Console.WriteLine($"{Cambi.DolartoReal(20)}");
        
        break;
        case "2":
        Console.WriteLine($"Insira o Valor:");
        Cambi.value = double.Parse(Console.ReadLine());
        Console.WriteLine($"{Cambi.Realtodolar(5)}");
        break;
        
        default:
        Console.WriteLine($"Error 404");
        break;
        

        
    }








    double valor1=Cambi.Realtodolar(5);
    double valor2=Cambi.DolartoReal(20);

