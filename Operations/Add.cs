namespace GMitC
{
    public class Add : ICalDuo
    {
        public byte Priority { get; } = 0;

        public double Calculate(double a, double b) => a + b;
    }
}