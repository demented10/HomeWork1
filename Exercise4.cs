namespace HomeWork1
{
    public class Exercise4 
    {
        private int[] array;
        public Exercise4(int arrayLenght)
        {
            array = new int[arrayLenght];
        }
        private void FillArray()
        {
            Random rand = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
        }
        private int GetMinValue()
        {
            int j = array[0];
            foreach(var i in array)
            {
                j = j < i ? j : i;
            }
            return j;
        }
        private int GetAverageValue()
        {
            int sum = 0;
            foreach(var i in array)
            {
                sum += i;
            }
            return sum / array.Length;
        }
        public void PrintResult()
        {
            FillArray();
            int averageValue = GetAverageValue();
            int minValue = GetMinValue();
            Console.WriteLine("Массив: ");
            foreach(var i in array)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine(String.Format("Минимальное значение в массиве: {0}; Среднее значение в массиве: {1}", minValue, averageValue));
        }
    }

}
