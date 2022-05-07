using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter First Number :");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Second Number :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose :");
            Console.WriteLine("Press 0 for Addition ");
            Console.WriteLine("Press 1 for Subtraction ");
            Console.WriteLine("Press 3 for Multiplication ");
            Console.WriteLine("Press 4 for Division ");
            Console.WriteLine("Press 5 for Remainder ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = program.Calculate(num1, num2, (MathType)operation);
            Console.WriteLine("Result :"+result);

            Console.ReadKey();
        }

        public double Calculate(double num1,double num2,MathType mathType)
        {
            double output;
            output = mathType switch
            {
                MathType.Addition => num1 + num2,
                MathType.Subtraction => num1 - num2,
                MathType.Multiplication => num1 * num2,
                MathType.Division => num1 / num2,
                MathType.Modulus => num1 % num2,
                _ => throw new NotImplementedException(),
            };

            return output;
        }
        public enum MathType
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Modulus
        }
    }
}
