public class Program
{
    public static void Main()
    {
        const string AVG = "El promig de les notes es: ", INTRO = "Introdueix la nota ", APPROVED = "Aprovat", NOTAPPROVED = "Suspès";
        int sum = 0;
        float avg;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(INTRO + (i + 1));
            sum += Convert.ToInt32(Console.ReadLine());
        }
        avg = sum / 3;

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

