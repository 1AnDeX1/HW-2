using System;
using System.Text;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть цифру:");

            do
            {
                ForText.MyText2("1 Перше завдання\n2 Друге завдання\n3 Третє завдання\n4 Четверте завдання\n5 Вихід");
                try
                {
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            ForText.MyText("Перше завдання:");
                            FirstExercise.Calculate();
                            break;
                        case 2:
                            ForText.MyText("Друге завдання:");
                            SecondExercise.FindMax();
                            break;
                        case 3:
                            ForText.MyText("Третє завдання:");
                            ThirdExercise.FindMax();
                            break;
                        case 4:
                            ForText.MyText("Четверте завдання:");
                            FourthExercise.FindMax();
                            break;
                        case 5:
                            Console.WriteLine("Вихід...");
                            return;
                        default:
                            Console.WriteLine("Введено не правильне число");
                            break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Помилка вводу");
                }
                
            } while (true);            
        }
    }
}
