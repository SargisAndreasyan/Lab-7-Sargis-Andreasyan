using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Sargis_Andreasyan
{
    internal class Rabbit:Animal
    {
        public override void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
