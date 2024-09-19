public class Program
{
    public static void Main()
    {
        const string AVG = "El promig de les notes es: ", INTRO = "Introdueix la nota ", APPROVED = "Aprovat", NOTAPPROVED = "Suspès";
        int nota1 = 0, nota2 = 0, nota3 = 0;
        float avg;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(INTRO + (i + 1));
            int nota = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                nota1 = nota;
            }
            else if (i == 1)
            {
                nota2 = nota;
            }
            else if (i == 2)
            {
                nota3 = nota;
            }
        }
        avg = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine(AVG + avg);

        if (avg >= 5)
        {
            Console.WriteLine(APPROVED);
        }
        else
        {
            Console.WriteLine(NOTAPPROVED);
        }
    }
}

