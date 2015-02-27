using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inertsect
{
    class Program
    {
        public static void Move(int[] aPosition, int[] aFirstPointX, int[] aSecondPointX)
        {
            int nX = 0;
            int nY = 0;
            int[] aMaintStructX = new int[3];

            IEnumerable<int> firstIntersection;
            IEnumerable<int> secondIntersection;

            var firstPoint = new FirstStruct(aPosition[0], aPosition[1], 15);
            var secondPoint = new SecondStruct(aPosition[2], aPosition[3], 6);
            var mainStruct = new MainStruct(nX, nY);

            try
            {
                firstPoint.Show();
                secondPoint.Show();
                mainStruct.Show();

                while (true)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            nY--;
                            break;
                        case ConsoleKey.DownArrow:
                            nY++;
                            break;
                        case ConsoleKey.LeftArrow:
                            nX--;
                            break;
                        case ConsoleKey.RightArrow:
                            nX++;
                            break;
                    }

                    if (nX < 0) nX = 0;
                    else if (nX > Console.WindowWidth) nX--;

                    if (nY < 0) nY = 0;
                    else if (nY > Console.WindowHeight) nY--;

                    Console.Clear();

                    mainStruct = new MainStruct(nX, nY);

                    for (int i = 0; i < 3; i++)
                        aMaintStructX[i] = nX + i;

                    firstPoint.Show();
                    secondPoint.Show();
                    mainStruct.Show();

                    firstIntersection = aMaintStructX.Intersect(aFirstPointX);
                    secondIntersection = aMaintStructX.Intersect(aSecondPointX);

                    if (firstIntersection.Any())
                        if (nY + 2 >= aPosition[1] && nY < aPosition[1] + firstPoint.nWidth)
                            Console.Beep(2700, 50);

                    if (secondIntersection.Any())
                        if (nY + 2 >= aPosition[3] && nY < aPosition[3] + secondPoint.nWidth)
                            Console.Beep(5000, 50);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Inertsection";

            var random = new Random();
            int[] aFirstPointX = new int[15];
            int[] aSecondPointX = new int[6];

            int[] aPosition = {
                random.Next(0, (Console.WindowWidth - 15)),
                random.Next(0, Console.WindowHeight - 15),
                random.Next(0, (Console.WindowWidth - 6)),
                random.Next(0, Console.WindowHeight - 6)
            };

            for (int i = 0; i < 15; i++)
                aFirstPointX[i] = aPosition[0] + i;

            for (int i = 0; i < 6; i++)
                aSecondPointX[i] = aPosition[2] + i;

            Move(aPosition, aFirstPointX, aSecondPointX);
        }
    }
}
