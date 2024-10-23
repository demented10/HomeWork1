namespace HomeWork1
{


    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задача остаток от деления");
            Exercise1 ex1 = new Exercise1(5, 2);
            ex1.PrintResult();

            Console.WriteLine("\nЗадача копирование массива");
            Exercise2 ex2 = new Exercise2(5);
            ex2.PrintResult();

            Console.WriteLine("\nЗадача FizzBuzz");
            Exercise3 ex3 = new Exercise3();
            ex3.PrintResult();
            
            Console.WriteLine("\nЗадача минимальное и среднее значение");
            Exercise4 ex4 = new Exercise4(5);
            ex4.PrintResult();

            Console.WriteLine("\nЗадача перечисление месяцев");
            Exercise5 ex5 = new Exercise5();
            ex5.PrintResuslt();

            Console.WriteLine("\nЗадача перевернуть массив");
            Exercise6 ex6 = new Exercise6(5);
            ex6.PrintResult();

            Console.WriteLine("\nЗадача два автомобиля");
            Exercise7 ex7 = new Exercise7(30);
            ex7.PrintResult();
        }
    }
}
