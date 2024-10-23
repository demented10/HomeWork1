namespace HomeWork1
{
    public class Exercise7
    {
        private double hours;

        public Exercise7(double minutes)
        { 
            hours = minutes / 60; 
        }

        private double GetInput(string label)
        {
            Console.Write(label);
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        private double CalculateDistance(double V1, double V2, double S)
        {
            double distanceV1 = V1 * hours;
            double distanceV2 = V2 * hours;
            double distance = S + distanceV1 - distanceV2;

            return distance;
        }
        public void PrintResult()
        {
            double V1 = GetInput("Введите скорость первого автомобиля км/ч: ");
            double V2 = GetInput("Введите скорость второго автомобиля км/ч: ");
            double S = GetInput("Введите расстояние между автомобилями в км.: ");
            double distance = CalculateDistance(V1, V2, S);
            Console.WriteLine($"Расстояние между автомобилями через 30 минут: {distance} км");
        }
    }
}
