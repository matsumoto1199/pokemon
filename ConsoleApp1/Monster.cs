using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int A { get; set; }
        public int S { get; set; }
        public int D { get; set; }

        public bool Chack()
        {
            if (Hp <= 0)
            {
                this.Hp = 0;

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
