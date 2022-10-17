using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static pokemon.Mapoke;
using System.Xml.Linq;

namespace pokemon
{
    public class Enpoke : Monster
    {
        public string Type;

        public Enpoke(string name, int hp, int a, int s, int d, string type)
        {
            this.Name = name;
            this.Hp = hp;
            this.A = a;
            this.S = s;
            this.D = d;
            this.Type = type;
        }
        public void Eatt(Enpoke terget)
        {
            int dm = A - D;
            int wn = dm * 2;
            int lo = dm / 2;
            if (Type == "fire")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= dm;
                    


                }
                else if (terget.Type == "water")
                {

                }
                else
                {

                }
            }
            else if (Type == "water")
            {

                if (terget.Type == "fire")
                {

                }
                else if (terget.Type == "water")
                {

                }
                else
                {

                }
            }
            else
            {

                if (terget.Type == "fire")
                {

                }
                else if (terget.Type == "water")
                {

                }
                else
                {

                }
            }
        }
    }
}
