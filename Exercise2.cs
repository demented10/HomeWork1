namespace HomeWork1
{
    internal partial class Program
    {
        public class Exercise2
        {
            private int[] originArray, copiedArray;
            public Exercise2(int arrayLenght)
            {
                originArray = new int[arrayLenght];
                copiedArray = new int[arrayLenght];
            }
            private void FillArray()
            {
                Random random = new Random();
                for (int i = 0; i < originArray.Length; i++)
                {
                    originArray[i] = random.Next(0, 10);
                }
            }
            private void CopyArray()
            {
                for(int i = 0; i < originArray.Length; i++)
                {
                    copiedArray[i] = originArray[i];
                }
            }
            public void PrintResult()
            {
                FillArray();
                CopyArray();
                for(int i = 0; i < originArray.Length; i++)
                {
                    Console.WriteLine($"[{i}] origin: {originArray[i]} copied: {copiedArray[i]}");
                }
            }
        }
    }
}
