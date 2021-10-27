using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper= OperationFactory.CreateOperate("/");
            oper.NumberA = 5;
            oper.NumberB = 7;
            var result= oper.GetResult();
            Console.WriteLine(result);
        }
    }
}
