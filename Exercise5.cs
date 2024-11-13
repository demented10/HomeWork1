namespace HomeWork1
{
    public class Exercise5 : ExerciseBase
    {
        public Exercise5() : base(5, "Задача перечисление месяцев") { }

        private enum MonthsOfYear
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }
        
        
        private void SelectMonth(int monthNumber)
        {
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                MonthsOfYear month = (MonthsOfYear)monthNumber;
                Console.WriteLine($"Выбранный месяц: {month}");
            }
            else Console.WriteLine("Введеное число должно быть в диапазоне от 1 до 12 включительно.");
        }
        public override void Start()
        {
            Console.Write("Введите номер месяца: ");
            if (int.TryParse(Console.ReadLine(), out int value)) SelectMonth(value);
            else Console.WriteLine("Введеная строка не является числом.");
        }
    }
}
