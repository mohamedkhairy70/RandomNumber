using System;
using System.Text;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World!  {GenerateInvoiceNo()} :  {GenerateBarcodeNo()}");
            }
           
            Console.ReadKey();
        }
        public static string GenerateInvoiceNo()
        {
            while (true)
            {
                var _numbers = "0123456789asdfghqwertyuio";
                var random = new Random();

                var builder = new StringBuilder(14);
                var numbers = "";
                for (var i = 0; i < 7; i++) builder.Append(_numbers[random.Next(0, _numbers.Length)]);
                numbers = builder.ToString();

                if (numbers != null)
                {
                    return numbers;
                }
            }
        }

        public static string GenerateBarcodeNo()
        {
            while (true)
            {
                var _numbers = "0123456789asdfghqwertyuio";
                var random = new Random();

                var builder = new StringBuilder(14);
                var numbers = "";
                for (var i = 0; i < 7; i++) builder.Append(_numbers[random.Next(0, _numbers.Length)]);
                numbers = builder.ToString();

                if (numbers != null)
                {
                    return numbers;
                }
            }
        }
    }
}
