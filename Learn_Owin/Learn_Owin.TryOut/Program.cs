using Learn_Owin.Infrastructure;
using System;

namespace Learn_Owin.TryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }


        private static string TestException()
        {
            throw new NotImplementedCustomException();
        }
    }
}
