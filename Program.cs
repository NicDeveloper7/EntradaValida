    //By NicholasDev
    int number;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--- Entrada Válida ---");
    Console.ResetColor();

    //Solicitação do número ao usuário
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    number = int.Parse(Console.ReadLine()!);

    //Loop para continuar solicitando números até que seja digitado o valor 0
    while (number != 0)
    {
        //Solicitação do número ao usuário
        Console.WriteLine($"Digite um número entre 1 e 9 (ou 0 para cancelar)...:{number}");
        number = int.Parse(Console.ReadLine()!);
    }

    //Verifica se o número digitado é igual a 0
    if (number == 0)
    {
     
        Console.WriteLine("Operação cancelada");
        Console.WriteLine();

    
        Console.WriteLine("Volte sempre!");
    }
