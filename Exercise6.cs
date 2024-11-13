namespace HomeWork1
{

        public class Exercise6 : ExerciseBase
        {
            private int arrayLenght;
            public Exercise6(int arrayLenght) : base(6, "Задача переворот массива")
            {
                this.arrayLenght = arrayLenght;
            }
            private int[] GenerateNumbers(int lenght)
            {
                Random rand = new Random();
                int[] array = new int[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    array[i] = rand.Next(0, 10);
                }
                return array;
            }
            private void PrintNumbers(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"[{i}]: {array[i]}; ");
                }
            }
            private int[] Reverse(int[] array)
            {
                int[] reversedArr = new int[array.Length];
                for(int i = 0; i < array.Length; i++)
                {
                    reversedArr[i] = array[(array.Length - 1) - i];
                }
                return reversedArr;
            }
            public override void Start()
            {
                int[] baseArray = GenerateNumbers(arrayLenght);
                int[] reversedArray = Reverse(baseArray);
                Console.WriteLine("Базовый массив:");
                PrintNumbers(baseArray);
                Console.WriteLine("\nПеревернутый массив:");
                PrintNumbers(reversedArray);
            }
        }
    
}
