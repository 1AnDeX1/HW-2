using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class ThirdExercise
    {

        public static void FindMax()
        {
            Random rnd = new Random();

            int[] numberOfPages = new int[100];

            Console.WriteLine("Кількість сторінок в книгах:");
            Console.WriteLine();

            for (int i = 0; i < numberOfPages.Length; i++)
            {
                numberOfPages[i] = rnd.Next(1501);

                Console.Write(numberOfPages[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Кількість сторінок в найтовстішій книжці: {numberOfPages.Max()}");
        }
    }
}
