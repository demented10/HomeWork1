namespace HomeWork1
{
    class Exercise10 : ExerciseBase
    {

        public Exercise10() : base(10, "Задача дни месяца") { }

        public override void Start()
        {
            Console.Write("Введите номер месяца (1-12): ");
            string inputMonth = Console.ReadLine();
            int month;
            while (!int.TryParse(inputMonth, out month) || month < 1 || month > 12)
            {
                Console.Write("Некорректный ввод. Введите номер месяца (1-12): ");
                inputMonth = Console.ReadLine();
            }

            Console.Write("Введите год: ");
            string inputYear = Console.ReadLine();
            int year;
            while (!int.TryParse(inputYear, out year))
            {
                Console.Write("Некорректный ввод. Введите год: ");
                inputYear = Console.ReadLine();
            }

            int days = GetDaysInMonth(month, year);
            Console.WriteLine($"Количество дней в месяце {GetMonthName(month)} {year} года: {days}");
        }

        static int GetDaysInMonth(int month, int year)
        {
            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "января";
                case 2: return "февраля";
                case 3: return "марта";
                case 4: return "апреля";
                case 5: return "мая";
                case 6: return "июня";
                case 7: return "июля";
                case 8: return "августа";
                case 9: return "сентября";
                case 10: return "октября";
                case 11: return "ноября";
                case 12: return "декабря";
                default: return "";
            }
        }
    }

}
