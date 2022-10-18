using pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("名前を書いてください");
            //var player = Console.ReadLine();
            //Console.WriteLine("{0}で合っているかな？", player);
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
                player = Console.ReadLine();//書いてもらった内容をplayerに代入
                Console.WriteLine("{0}で合っているかな？\n\nyes  or  no", player);
                var i = Console.ReadLine();//書いてもらった内容をiに代入
                if (i == "yes" ^ i == "no")//iがyesかnoだった場合の処理
                {
                    if (i == "yes")//iがyesだった時の処理
                    {
                        Console.WriteLine("次はライバルのお話だ\n");
                        break;
                    }//一方noだった場合初めから
                }
                else//yesno以外だった場合
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
            List<Enpoke> enp = new List<Enpoke>();//相手ポケモンのlist
            enp.Add(new Enpoke("ガオガエン", 200, 100, 100, 50, "fire"));
            enp.Add(new Enpoke("オーダイル", 100, 180, 100, 50, "water"));
            enp.Add(new Enpoke("ブリガロン", 100, 100, 100, 70, "grass"));



            List<Mapoke> map = new List<Mapoke>();//味方ポケモンのlist
            map.Add(new Mapoke("バクフーン", 130, 120, 100, 80, "fire"));
            map.Add(new Mapoke("ゲッコウガ", 250, 100, 100, 50, "water"));
            map.Add(new Mapoke("ジュナイパー", 150, 130, 100, 50, "grass"));



            Random r = new Random();//ライバルポケモンのランダム抽選
            Console.WriteLine("{0}が勝負を仕掛けてきた！", player1);
            int rn = r.Next(0, 3);
            Console.WriteLine("{0}は{1}を繰り出した！", player1, enp[rn].Name);//!ポケモンの名前が出てこない
            //Console.WriteLine("{0}は{1}を繰り出した！", player1, enp[r.Next(0,4)]);
            Console.WriteLine("ポケモンを選んでください");
            Console.WriteLine("1[{0}]\n2[{1}]\n3[{2}]", map[0].Name, map[1].Name, map[2].Name);
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("いけ！{0}！\n君に決めた！", map[num - 1].Name);
            Console.ReadLine();

            bool turn = false;

            while (true)
            {
                if (turn)
                {
                    enp[rn].Eatt(map[num - 1]);
                    if (!map[num - 1].Check())
                    {
                        Console.WriteLine("{0}よく頑張った！", map[num - 1].Name);
                        map.RemoveAt(num - 1);
                        if (map.Count == 0)
                        {
                            Console.WriteLine("\n{0}は目の前が真っ暗になった\n",player);
                            break;
                        }
                        else
                        {
                            if (map.Count == 2)
                            {
                                Console.WriteLine("次のポケモンを選んでください");
                                Console.WriteLine("1[{0}]\n2[{1}]\n", map[0].Name, map[1].Name);
                                num = int.Parse(Console.ReadLine());
                                Console.WriteLine("{0}！君に決めた！", map[num - 1].Name);
                            }
                            else
                            {
                                num = 1;
                                Console.WriteLine("{0}！君に決めた！", map[num - 1].Name);
                            }
                        }
                    }

                    turn = false;
                }
                else//mainターン
                {
                    map[num - 1].matt(enp[rn]);
                    if (!enp[rn].Check())
                    {
                        Console.WriteLine("{0}の{1}は倒れた！", player1, enp[rn].Name);
                        enp.RemoveAt(rn);
                        if(enp.Count == 0)
                        {
                            Console.WriteLine("\n{0}に勝利した！\n",player1);
                            Console.WriteLine("\n{0}は5,000円手に入れた！\n",player);
                            break;
                        }
                        else
                        {
                            rn = r.Next(0, enp.Count);
                            Console.WriteLine("{0}は次に{1}を繰り出した",player1, enp[rn].Name);
                        }
                    }
                    turn=true;
                }
                Console.WriteLine("\n\n-----turn change-----\n\n");
            }
        }
    }
}