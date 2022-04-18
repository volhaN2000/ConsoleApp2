
using System;
using System.Collections.Generic;
using Dangl.Calculator;

namespace calc
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите выражение для вычисления");
          var expression = Console.ReadLine();
            while (expression.Contains("/0")) 
            { 
                Console.WriteLine("Нельзя делить на ноль. Попробуйте ещё раз");
                expression = Console.ReadLine();
            }
            var result=Calculator.Calculate(expression);
            Console.WriteLine("{0}={1}",expression,(result.Result));
            Console.ReadKey();

        }
    }
}


        
    


    



                 
    


