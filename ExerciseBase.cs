namespace HomeWork1
{
    public abstract class ExerciseBase
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public ExerciseBase (int number, string name)
        {
            Number = number;
            Name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер задания: {Number}; {Name}");
        }
        public abstract void Start();
    }
    
}
