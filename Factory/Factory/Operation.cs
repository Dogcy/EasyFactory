using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation opera = null;
            switch (operate)
            {
                case "+":
                    opera = new OperationAdd();
                    break;
                case "-":
                    opera = new OperationASub();
                    break;
                case "*":
                    opera = new OperationMul();
                    break;
                case "/":
                    opera = new OperationDiv();
                    break;

            }
            return opera;

        }
    }
    public class Operation
    {
        protected private double _testProtected = 5;
        public double _testPublic = -1;
        private double _numberA = 0;
        private double _numberB = 0;
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;

        }


    }
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {


            double result = 0;
            result = NumberA + NumberB;
            result = _testPublic;
            return base.NumberA;
        }
    }
    public class OperationASub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA / NumberB;
            return result;
        }

    }
}
