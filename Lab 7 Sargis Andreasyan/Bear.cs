using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Sargis_Andreasyan
{
    internal class Bear:Animal
    {
        public Bear(char a,int speed)
        {
            Symbol = a;
            Speed = speed;
        }
        public override void Move(int x, int y)
        {
            PosX += Speed;
            PosY = y;
        }
    }
}
