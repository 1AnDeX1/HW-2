using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_2
{
    class FirstExercise
    {
        public static void Calculate()
        {
            string text = Console.ReadLine();
            double sum = text.Where(Char.IsDigit).Sum(Char.GetNumericValue);
            double max = text.Where(Char.IsDigit).Max(Char.GetNumericValue);
            Console.WriteLine($"Сумма = {sum}");
            Console.WriteLine($"Максимальна цифра: = {max}");
        }
    }
}
