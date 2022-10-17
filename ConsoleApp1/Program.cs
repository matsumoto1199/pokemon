using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Console.WriteLine("名前を書いてください");
            //    var player = Console.ReadLine();
            //    Console.WriteLine("{0}で合っているかな？", player);
            //var i = Console.ReadLine();
            //if (i == "no")
            //{
            //    Console.WriteLine("名前を書いてください");
            //    var player = Console.ReadLine();
            //    Console.WriteLine("{0}で合っているかな？", player);
            //}
            //else if (i == "yes")
            //{
            //    Console.WriteLine("それでは君の物語を始めよう");
            //}
            //else
            //{
            //    Console.WriteLine("yes or noで入力してください");
            //}
            var player = "";//主人公の名前を定義
            while (true)
            {
                Console.WriteLine("名前を書いてください\n");
                player = Console.ReadLine();
                Console.WriteLine("{0}で合っているかな？\n\nyes  or  no", player);
                var i = Console.ReadLine();
                if (i == "yes" ^ i == "no")
                {
                    if (i == "yes")
                    {
                        Console.WriteLine("次はライバルのお話だ\n");
                        break;
                    }
                    else if (i == "no")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("yes or noで入力してください\n");
                }
            }
            var player1 = "";//ライバルの名前を定義
            while (true)
            {
                Console.WriteLine("ライバルの名前は何だったかな\n");
                player1 = Console.ReadLine();
                Console.WriteLine("{0}で合っているかな？\n\nyes  or  no", player1);
                var i = Console.ReadLine();
                if (i == "yes" ^ i == "no")
                {
                    if (i == "yes")
                    {
                        Console.WriteLine("それでは君の物語を始めよう\n");
                        break;
                    }
                    else if (i == "no")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("yes or noで入力してください\n");
                }
            }
            List<Enpoke> enp = new List<Enpoke>();
            enp.Add(new Enpoke("ガオガエン", 100, 100, 100, 100, "fire"));
            enp.Add(new Enpoke("オーダイル", 100, 100, 100, 100, "water"));
            enp.Add(new Enpoke("ブリガロン", 100, 100, 100, 100, "grass"));
            List<Mapoke> map = new List<Mapoke>();
            map.Add(new Mapoke("バクフーン", 100, 100, 100, 100, "fire"));
            map.Add(new Mapoke("ゲッコウガ", 100, 100, 100, 100, "water"));
            map.Add(new Mapoke("ジュナイパー", 100, 100, 100, 100, "grass"));
            Random r = new Random();
            Console.WriteLine("{0}が勝負を仕掛けてきた！", player1);
            Console.WriteLine("{0}は{1}を繰り出した！", player1, enp[r.Next(0,4)].Name);
            //Console.WriteLine("{0}は{1}を繰り出した！", player1, enp[r.Next(0,4)]);
            Console.WriteLine("ポケモンを選んでください");
            int num = int.Parse(Console.ReadLine());
            map = map[(num-1)];

        }
    }
}
