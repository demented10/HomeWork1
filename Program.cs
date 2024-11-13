using System.Security.Cryptography.X509Certificates;

namespace HomeWork1
{


    internal partial class Program
    {
        static ExerciseBase[] exercises = new ExerciseBase[11]
        {
            new Exercise1(5, 2),
            new Exercise2(5),
            new Exercise3(),
            new Exercise4(5),
            new Exercise5(),
            new Exercise6(5),
            new Exercise7(30),
            new Exercise8(),
            new Exercise9(),
            new Exercise10(),
            new Exercise11()
        };

        static void Main(string[] args)
        {
            int exerciseNumber = 0;

            foreach (var exercise in exercises)
                exercise.PrintInfo();

            Console.WriteLine("Выберите задание: ");

            while (exerciseNumber < 1 || exerciseNumber > 11)
            {
                if (int.TryParse(Console.ReadLine(), out exerciseNumber))
                {
                    if (exerciseNumber < 1 || exerciseNumber > 11) Console.WriteLine("Введеное число должно быть в диапазоне от 1 до 11 включительно.");
                    else
                    {
                        Console.Clear();
                        var exercise = exercises.First(t => t.Number == exerciseNumber);
                        exercise.PrintInfo();
                        exercise.Start();
                        Console.ReadKey();
                    }
                }
            }
        }
    }    
}
