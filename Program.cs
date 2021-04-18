using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork211
{
    public static class Program
    {
        public class TestCase
        {
            public int NUMBER { get; set; }
            public int D { get; set; }
            public int Excpected { get; set; }
            public Exception ExcpectedException { get; set; }
        }
        
        static void TestNumber(TestCase testCase)
        {
            try
            {
                var actual = CheckNumber(testCase.D, testCase.NUMBER); 
                
                if (actual==testCase.Excpected)
                {
                    Console.WriteLine("действительный тест");
                }
                else
                {
                    Console.WriteLine("недействительный тест");
                }
            }
            
            catch (Exception ex)
            {
                if (testCase.ExcpectedException!=null)
                {
                    Console.WriteLine("действительный тест");
                }
                else
                {
                    Console.WriteLine("недействительный тест");
                }
            }
            
        }
        
        
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                D = 0,
                NUMBER = 5,
                Excpected = 5,
                ExcpectedException = null,
            };
            TestNumber(testCase1);
        }



        static int CheckNumber(int number, int d)
        {
            number = int.Parse(Console.ReadLine());
            d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine("d-простое число");
                }
                else
                {
                    Console.WriteLine("d-непростое число");
                }
                break;
            }
            return number;
        }
    }
}
