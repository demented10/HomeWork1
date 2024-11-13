namespace HomeWork1
{

        class Exercise8 : ExerciseBase
        {
            public Exercise8() : base(8, "Задача зарплата") { }
            
            int[,] salaries = new int[7, 12]
            {
            {100, 150, 120, 130, 170, 140, 160, 180, 190, 110, 120, 130},
            {200, 250, 220, 230, 270, 240, 260, 280, 290, 210, 220, 230},
            {300, 350, 320, 330, 370, 340, 360, 380, 390, 310, 320, 330},
            {400, 450, 420, 430, 470, 440, 460, 480, 490, 410, 420, 430},
            {500, 550, 520, 530, 570, 540, 560, 580, 590, 510, 520, 530},
            {600, 650, 620, 630, 670, 640, 660, 680, 690, 610, 620, 630},
            {700, 750, 720, 730, 770, 740, 760, 780, 790, 710, 720, 730}
            };

            private double CalculateTotalSalary(int month)
            {
                double totalSalary = 0;
                for (int i = 0; i < 7; i++)
                {
                    totalSalary += salaries[i, month];
                }
                return totalSalary;
            }

            public override void Start()
            {
                int month;
                
                do
                {
                    Console.Clear();
                    Console.Write("Введите номер месяца (1-12): ");
                    _ = int.TryParse(Console.ReadLine(), out month);
                } while (month < 1 || month > 12);

                Console.WriteLine($"Общая зарплата за {month} месяц: {CalculateTotalSalary(month - 1)}");

            }

        }
    
}
