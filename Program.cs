//Part-1
//using System;
//namespace Day_16_Assignment_19
//{
//    delegate int ArithmeticOperation(int num1, int num2);
//    class Program
//    {
//        static int Add(int num1, int num2)
//        {
//            return num1 + num2;
//        }

//        static int Subtract(int num1, int num2)
//        {
//            return num1 - num2;
//        }

//        static int Multiply(int num1, int num2)
//        {
//            return num1 * num2;
//        }

//        static int Divide(int num1, int num2)
//        {
//            if (num2 != 0)
//                return num1 / num2;
//            else
//            {
//                Console.WriteLine("Error: Division by zero is not allowed.");
//                return 0;
//            }
//        }

//        static void Main(string[] args)
//        {
//            ArithmeticOperation addDelegate = Add;
//            ArithmeticOperation subtractDelegate = Subtract;
//            ArithmeticOperation multiplyDelegate = Multiply;
//            ArithmeticOperation divideDelegate = Divide;


//            Console.Write("Enter the first integer: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter the second integer: ");
//            int num2 = int.Parse(Console.ReadLine());


//            Console.WriteLine("Choose an arithmetic operation:");
//            Console.WriteLine("1. Addition");
//            Console.WriteLine("2. Subtraction");
//            Console.WriteLine("3. Multiplication");
//            Console.WriteLine("4. Division");
//            Console.Write("Enter your choice (1/2/3/4): ");
//            int choice = int.Parse(Console.ReadLine());


//            int result = 0;
//            switch (choice)
//            {
//                case 1:
//                    result = addDelegate(num1, num2);
//                    break;
//                case 2:
//                    result = subtractDelegate(num1, num2);
//                    break;
//                case 3:
//                    result = multiplyDelegate(num1, num2);
//                    break;
//                case 4:
//                    result = divideDelegate(num1, num2);
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice!");
//                    return;
//            }

//            Console.WriteLine($"Result: {result}");
//            Console.ReadKey();
//        }

//    }


//}


//Part-2
using System;
namespace GenericArithmeticOperations
{
    
    delegate T Operation<T>(T num1, T num2);

    class Program
    {

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            
            Operation<int> addOperation = Add;
            Operation<int> subtractOperation = Subtract;
            Operation<int> multiplyOperation = Multiply;
            Operation<int> divideOperation = Divide;

           
            Console.Write("Enter the First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            int num2 = int.Parse(Console.ReadLine());

          
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition of {num1} and {num2}  : {addOperation(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction of  {num1}  and  {num2}   :  {subtractOperation(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of {num1} and {num2} = {multiplyOperation(num1, num2)}");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"Division of {num1} and {num2} = {divideOperation(num1, num2)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
