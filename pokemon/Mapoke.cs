using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static pokemon.Mapoke;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

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
            int dm = A - D;
            int wn = dm * 2;
            int lo = dm / 2;
            if (Type == "fire")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= dm;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, dm);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= lo;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, lo);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if (terget.Type == "grass")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= wn;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, wn);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
            }
            else if (Type == "water")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= wn;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, wn);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= dm;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, dm);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if(terget.Type == "grass")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= lo;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, lo);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
            }
            else if (Type == "grass")
            {
                if (terget.Type == "fire")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= lo;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, lo);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if (terget.Type == "water")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= wn;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, wn);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp, terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
                else if(terget.Type == "grass")
                {
                    Console.WriteLine("\n{0}の攻撃！\n", Name);
                    terget.Hp -= dm;
                    terget.Check();
                    Console.WriteLine("\n{0}は{1}ダメージを受けた！\n", terget.Name, dm);
                    Console.WriteLine("\n{1}\nHP：{0}\n", terget.Hp,terget.Name);
                    Console.WriteLine("\n------------------------------------------------------------\n");
                }
            }
        }
        public bool Check()
        {
            if (this.Hp <= 0)
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
