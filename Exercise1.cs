namespace HomeWork1
{
    class Exercise1 : ExerciseBase
    {
        private int a, b;
        private int quotient,reminder;
        public Exercise1(int a, int b) : base(1, "Задача остаток от деления")
        {
            this.a = a;
            this.b = b;
        }
        private void GetResult()
        {
            quotient = a / b;
            reminder = a % b;
        }
        public override void Start()
        {
            GetResult();
            Console.WriteLine(String.Format("При условии что a = {0} и b = {1}: {0}/{1} = {2} остаток {3}", a, b, quotient, reminder));

        }
    }
}
