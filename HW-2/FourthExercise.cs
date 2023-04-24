using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class FourthExercise
    {
        public static void FindMax()
        {
            Random rnd = new Random();

            int[] speedOfCar = new int[40];

            int maxSpeed = speedOfCar[0];
            int maxSpeedIndex = 0;

            Console.WriteLine("Швидкості автомобілів:");
            Console.WriteLine();

            for (int i = 0; i < speedOfCar.Length; i++)
            {
                speedOfCar[i] = rnd.Next(321);
                if (speedOfCar[i] >= maxSpeed)
                {
                    maxSpeed = speedOfCar[i];
                    maxSpeedIndex = i;
                }
                Console.Write(speedOfCar[i] + ", ");
            }

            //for (int i = 1; i < speedOfCar.Length; i++)
            //{
            //    if (speedOfCar[i] >= maxSpeed)
            //    {
            //        maxSpeed = speedOfCar[i];
            //        maxSpeedIndex = i;
            //    }
            //}

            int firstMaxSpeedIndex = maxSpeedIndex;
            for (int i = 0; i < speedOfCar.Length; i++)
            {
                if (speedOfCar[i] == maxSpeed)
                {
                    firstMaxSpeedIndex = i;
                    break;
                }
            }
            Console.WriteLine();
            if (firstMaxSpeedIndex == maxSpeedIndex)
            {
                Console.WriteLine($"Порядковий номер максимальної швидкості: {maxSpeedIndex + 1}");
            }
            else
            {
                Console.WriteLine($"Порядковий номер першої максимальної швидкості: {firstMaxSpeedIndex + 1}");
                Console.WriteLine($"Порядковий номер останньої максимальної швидкості: {maxSpeedIndex + 1}");
            }
        }

    }
}
