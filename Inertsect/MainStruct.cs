using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inertsect
{
    struct MainStruct
    {
        private int nX;
        private int nY;

        public MainStruct(int nX, int nY)
        {
            this.nX = nX;
            this.nY = nY;
        }

         public void Show()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(nX, nY + i + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                }
                Console.ResetColor();
            }
        }
    }
}
