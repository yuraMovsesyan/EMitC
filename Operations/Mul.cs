namespace GMitC
{
    public class Mul : ICalDuo
    {
        public byte Priority { get; } = 1;
        public double Calculate(double a, double b) => a * b;
    }
}