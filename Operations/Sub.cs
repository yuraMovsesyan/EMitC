namespace GMitC
{
    public class Sub : ICalDuo
    {
        public byte Priority { get; } = 0;

        public double Calculate(double a, double b) => a - b;
    }
}