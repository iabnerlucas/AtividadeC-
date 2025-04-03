using System.Security.Authentication;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int diaSemana = Convert.ToInt32(Console.ReadLine());

        if (diaSemana == 1)
        {
            Console.WriteLine("Domingo");
        }
        else if (diaSemana == 2)
        {
            Console.WriteLine("Segunda");
        }
        else if (diaSemana == 3)
        {
            Console.WriteLine("Terça");
        }
        else if (diaSemana == 4)
        {
            Console.WriteLine("Quarta");
        }
        else if (diaSemana == 5)
        {
            Console.WriteLine("Quinta");
        }
        else if (diaSemana == 6)
        {
            Console.WriteLine("Sexta");
        }
        else if (diaSemana == 7)
        {
            Console.WriteLine("Sábado");
        }
        else
        {
            Console.WriteLine("Dia inexixtente");
        }
    }
}