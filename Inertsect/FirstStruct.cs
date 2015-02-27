using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inertsect
{
    struct FirstStruct
    {
        private int nX;
        private int nY;
        public int nWidth;

        public FirstStruct(int nX, int nY, int nWidth)
        {
            this.nX = nX;
            this.nY = nY;
            this.nWidth = nWidth;
        }

        public void Show()
        {
            for (int i = 0; i < nWidth; i++)
            {
                Console.SetCursorPosition(nX, nY + i + 1);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int j = 0; j < nWidth; j++)
                {
                    Console.Write(".");
                }
                Console.ResetColor();
            }
        }
    }
}
