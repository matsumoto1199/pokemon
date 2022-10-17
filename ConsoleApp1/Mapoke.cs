using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
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

        public void matt(Enpoke terget)
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
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, dm);
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= lo;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, lo);
                }
                else if (Type == "grass")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= wn;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, wn);
                }
            }
            else if (Type == "water")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= wn;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, wn);
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= dm;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, dm);
                }
                else if (Type == "grass")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= lo;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, lo);
                }
            }
            else if (Type == "grass")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= lo;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, lo);
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= wn;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, wn);
                }
                else if (Type == "grass")
                {
                    Console.WriteLine("{0}の攻撃！", Name);
                    Hp -= dm;
                    Console.WriteLine("{0}は{1}ダメージを受けた", Name, dm);
                }
            }
        }
    }
}
