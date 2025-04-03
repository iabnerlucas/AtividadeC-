using System;

class Program
{
    public static void Main()
    {
       Console.Write("Digite um número inteiro: ");
       int numero = Convert.ToInt32(Console.ReadLine());

    if (numero%2 == 0)
        {
            Console.WriteLine("Par");
        }
    else
        {
            Console.WriteLine("Ímpar");
        }
    }


}
