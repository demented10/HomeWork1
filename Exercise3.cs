namespace HomeWork1
{
    public class Exercise3
    {
        private string CheckFizzBuzzState(int value)
        {
            if ((value % 3 == 0) && (value % 5 == 0)) return "FizzBuzz";
            else if (value % 3 == 0) return "Fizz";
            else if (value % 5 == 0) return "Buzz";
            else return value.ToString();
        }
        public void PrintResult()
        {
            for(int i = 1; i<=100; i++)
            {
                Console.WriteLine(CheckFizzBuzzState(i));
            }
        }
    }
}
