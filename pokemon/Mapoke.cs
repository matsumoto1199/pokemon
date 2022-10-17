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
    public class Mapoke : Monster
    {
        public string Type;

        public Mapoke(string name, int hp, int a, int s, int d, string type)
        {
            this.Name = name;
            this.Hp = hp;
            this.A = a;
            this.S = s;
            this.D = d;
            this.Type = type;
        }

        public void matt(pokemon.Enpoke terget)
        {
            if (Type == "fire")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);


                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
                else
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
            }
            else if (Type == "water")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
                else
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
            }
            else
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
                else
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                }
            }
        }
    }
}
