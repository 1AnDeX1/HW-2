using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class SecondExercise
    {
        public static void FindMax()
        {
            string text = Console.ReadLine();
            int maxDigit = -1;
            int maxDigitIndex = -1;
            bool isDigitFound = false;

            int spaceIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {

                    if (char.IsDigit(text[i]))
                    {
                        int digit = int.Parse(text[i].ToString());
                        if (digit > maxDigit)
                        {
                            maxDigit = digit;
                            maxDigitIndex = i;
                            
                        }
                        isDigitFound = true;
                    }
                }
                else if (text[i] == ' ')
                {
                    if (isDigitFound == false)
                    {
                        spaceIndex = i;
                    }
                }
            }

            Console.WriteLine("Порядковый номер максимальной цифры: " + (maxDigitIndex + 1 - spaceIndex));
        }
    }
}
