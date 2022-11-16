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
        public int PosY;
        public char Symbol;
        
        public void Draw()
        {
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Symbol);
        }
        public Manager(int x,int y,char sym)
        {
            PosX = x;
            PosY = y;
            Symbol = sym;
        }
    }
}
