using System;


namespace methodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select a number to add");
            int z = math.MyAdd(8, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Addition result is : " + z);
            Console.WriteLine("Please select a number to substract");
            int a = math.MySub(2, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Substraction result is : " + a);
            Console.WriteLine("Please select a number to multiply");
            int b = math.MyMult(3, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Multiplication result is : " + b);

            Console.ReadLine();
        }
    }
}