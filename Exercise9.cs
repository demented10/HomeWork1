namespace HomeWork1
{

        class Exercise9 : ExerciseBase
        {


            public Exercise9() : base(9, "Задача вклады") { }
            double initialDeposit = 1000;
            double monthlyIncrease = 0.02;
            double CalculateDeposit(double initialDeposit, double monthlyIncrease, int months)
            {
                if (months == 0)
                {
                    return initialDeposit;
                }
                else
                {
                    return CalculateDeposit(initialDeposit, monthlyIncrease, months - 1) * (1 + monthlyIncrease);
                }
            }
            public override void Start()
            {
                Console.Write("Введите количество месяцев: ");
                _ = int.TryParse(Console.ReadLine(), out int months);

                Console.WriteLine("Прирост суммы вклада за каждый месяц:");

                for (int i = 1; i <= months; i++)
                {
                    double deposit = CalculateDeposit(initialDeposit, monthlyIncrease, i);
                    double increase = deposit - CalculateDeposit(initialDeposit, monthlyIncrease, i - 1);
                    Console.WriteLine($"Месяц {i}: {increase:F2}");
                }

                Console.WriteLine("Сумма вклада через каждый месяц:");
                for (int i = 3; i <= months; i++)
                {
                    double deposit = CalculateDeposit(initialDeposit, monthlyIncrease, i);
                    Console.WriteLine($"Месяц {i}: {deposit:F2}");
                }
            }


        
    }
    
}
