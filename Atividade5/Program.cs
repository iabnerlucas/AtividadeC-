class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Negativo");
        } else if(numero == 0)
        {
            Console.WriteLine("Zero");
        } else
        {
            Console.WriteLine("Positivo");
        }
    }
}