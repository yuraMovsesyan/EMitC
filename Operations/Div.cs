namespace GMitC
{
    public class Div : ICalDuo
    {
        public byte Priority { get; } = 1;
        public double Calculate(double a, double b) => b / a;
    }
}