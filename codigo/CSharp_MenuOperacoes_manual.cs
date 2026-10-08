int opcao;

do
{
    Console.WriteLine("1 - Somar os numeros de 1 a 5");
    Console.WriteLine("2 - Mostrar os pares de 2 a 10");
    Console.WriteLine("0 - Terminar");
    Console.Write("Opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            int soma = 0;

            for (int numero = 1; numero <= 5; numero++)
            {
                soma += numero;
            }

            Console.WriteLine($"Soma: {soma}");
            break;

        case 2:
            for (int numero = 2; numero <= 10; numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            break;

        case 0:
            Console.WriteLine("Programa terminado.");
            break;

        default:
            Console.WriteLine("Opcao invalida.");
            break;
    }

} while (opcao != 0);