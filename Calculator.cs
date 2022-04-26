using System;

namespace GMitC
{
    public class Calculator : Data
    {
        private ICalDuo? Operation;
        public bool IsOperation() => Operation is not null;
        public void DelOperation() => Operation = null;
        public void SetOperation(ICalDuo operation) => Operation = operation;
        public double CalRes(double a, double b)
        {
            if (Operation is null)
                return -1;//TODO add error @_@

            return System.Math.Round(Operation.Calculate(a, b), 2);
        }
        public (double, string) CalText(string arg)
        {
            while (StackOperations.Count != 0) 
                StackNumbers.Push(CalResDuo(StackOperations.Pop(), StackNumbers.Pop(), StackNumbers.Pop()));
            return (StackNumbers.Pop(), "OK");
        }
        public double CalResUno(ICalUno op, double a) => op.Calculate(a);
        public double CalResDuo(ICalDuo op, double a, double b) => op.Calculate(a, b);
    }
    
}