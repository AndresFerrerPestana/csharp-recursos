int opcao;

do
{
    Console.WriteLine("1 - Mostrar mensagem");
    Console.WriteLine("2 - Contar de 1 a 5");
    Console.WriteLine("0 - Terminar");
    Console.Write("Opcao: ");

    bool leituraValida = int.TryParse(Console.ReadLine(), out opcao);

    if (!leituraValida)
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("O menu esta a funcionar.");
            break;

        case 2:
            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine(contador);
            }
            break;

        case 0:
            Console.WriteLine("Programa terminado.");
            break;

        default:
            Console.WriteLine("Opcao invalida. Escolha 0, 1 ou 2.");
            break;
    }

} while (opcao != 0);