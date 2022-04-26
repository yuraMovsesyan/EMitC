namespace GMitC
{
    public class Percent : ICalUno, ICalDuo
    {
        public byte Priority { get; } = 2;
        public double Calculate(double a) => a / 100;
        public double Calculate(double a, double b) => (a * b) / 100;
    }
}