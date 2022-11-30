using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Sargis_Andreasyan
{
    internal abstract class Animal
    {
        public int PosX { set; get; }
        public int PosY { set; get; }
        public char Symbol = 'X';
        public int Speed { set; get; }
        public ConsoleColor Color { set; get; }

        virtual public void Draw()
        {
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Symbol);
        }
        abstract public void Move(int x, int y);
    }
}
