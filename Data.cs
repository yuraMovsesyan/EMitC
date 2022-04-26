namespace GMitC
{
    public class Data
    {
        public Stack<double> StackNumbers { get; private set; }
        public Stack<ICalDuo> StackOperations { get; private set; }

        public Data()
        {
            StackNumbers = new ();
            StackOperations = new ();

            StackNumbers.Push(2);
            StackNumbers.Push(2);
            StackNumbers.Push(3);

            StackOperations.Push(new Add());
            StackOperations.Push(new Mul());
        }
    }
    
}