using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Sargis_Andreasyan
{
    internal class Manager
    {
        public int PosX;
        public char Symbol;

        public void Draw()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(PosX, i);
                Console.Write(Symbol);
            }
        }
        public Manager(int x,char sym)
        {
            PosX = x;
            Symbol = sym;
        }
    }
}
