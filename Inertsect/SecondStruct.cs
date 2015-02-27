using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inertsect
{
    struct SecondStruct
    {
        private int nX;
        private int nY;
        public int nWidth;

        public SecondStruct(int nX, int nY, int nWidth)
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < nWidth; j++)
                {
                    Console.Write(".");
                }
                Console.ResetColor();
            }
        }
    }
}
