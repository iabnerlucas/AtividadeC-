class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe sua nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 9)
        {
            Console.WriteLine("A");
        }
        else if (nota >= 7 && nota < 9)
        {
            Console.WriteLine("B");
        }
        else if (nota >= 5 && nota < 7)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }
    }
}
