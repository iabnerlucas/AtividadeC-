class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Menor de idade");
        } else
        {
            Console.WriteLine("Maior de idade");
        }
    }
}