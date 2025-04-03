class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a operação que deseja realizar: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão");
        int operacao = Convert.ToInt32(Console.ReadLine());

        int resultado;

        if (operacao == 1)
        {
            resultado = numero1 + numero2;
            Console.WriteLine("Resultado: " + resultado); 
        } else if (operacao == 2)
        {
            resultado = numero1 - numero2;
            Console.WriteLine("Resultado: " + resultado); 
        } else if(operacao == 3) { 
            resultado = numero1 * numero2;
            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            resultado=numero1 / numero2;
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}