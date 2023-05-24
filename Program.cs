namespace Calculator;

internal static class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - MULTIPLICAÇÃO");
        Console.WriteLine("4 - DIVISÃO");
        Console.WriteLine("--------------------");
        Console.WriteLine("0 - SAIR");
        Console.Write("DIGITE A SUA OPÇÃO: ");


        var res = short.Parse(Console.ReadLine()!);

        switch (res)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Multiplicacao();
                break;
            case 4:
                Divisao();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("SELECIONE UMA OPÇÃO VÁLIDA");
                Menu();
                break;
        }
    }

    private static void Soma()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);

        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);
        Console.Write("");
        var resultado = v1 + v2;
        Console.Write("O resultado da soma é: " + resultado);
        Console.ReadKey();
        Menu();
    }

    private static void Subtracao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);
        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);
        Console.Write("");
        var resultado = v1 - v2;
        Console.Write("O resultado da subtração é: " + resultado);
        Console.ReadKey();
        Menu();
    }

    private static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);
        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);
        Console.Write("");
        var resultado = v1 * v2;
        Console.Write("O resultado da multiplicação é: " + resultado);
        Console.ReadKey();
        Menu();
    }

    private static void Divisao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        var v1 = float.Parse(Console.ReadLine()!);
        Console.Write("Segundo valor: ");
        var v2 = float.Parse(Console.ReadLine()!);
        Console.Write("");
        var resultado = v1 / v2;
        Console.Write("O resultado da divisão é: " + resultado);
        Console.ReadKey();
        Menu();
    }
}