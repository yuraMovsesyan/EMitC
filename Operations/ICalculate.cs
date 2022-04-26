namespace GMitC
{
        public interface ICalUno
        {
                double Calculate(double a);
        }
        public interface ICalDuo 
        {
                byte Priority { get; }
                double Calculate(double a, double b);
        }
}