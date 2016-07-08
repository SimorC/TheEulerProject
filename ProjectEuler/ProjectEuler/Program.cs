using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerCode.Helper;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            EulerProblems();
        }

        private static void EulerProblems()
        {
            int qNumber = 0;

            while (true)
            {
                Console.WriteLine("Type the number of the question {0} (or any invalid number to exit):",
                    ReflectionHelper.GetMethodsNumberString());
                if (!int.TryParse(Console.ReadLine(), out qNumber)) break;

                try
                {
                    Console.WriteLine("=======================\n");
                    var answer = ReflectionHelper.CallProblemMethod(qNumber);
                    Console.WriteLine(answer);
                    Console.WriteLine("\n=======================");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Could not find the question");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
