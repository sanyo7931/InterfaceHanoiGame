using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    public class HanoiGame:IGame
    {
        private int disk;
        private int from;
        private int to;
        private int aux = 0;
        public void Setup()
        {
            Console.WriteLine("======遊戲開始======");
        Setup:
            try
            {
                //輸入高度
                Console.WriteLine("請輸入河內塔的高度：");
                string input = Console.ReadLine();
                disk = int.Parse(input);
                if (disk < 1)
                {
                    Console.Write("高度要大於或等於1");
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("起始地的柱子:(1,2,3)");
                input = Console.ReadLine();
                from = int.Parse(input);
                if (from < 1 || from > 3)
                {
                    Console.Write("輸入不在範圍內!");
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("目的地的柱子：(1,2,3)");
                input = Console.ReadLine();
                to = int.Parse(input);
                if (to < 1 || to > 3)
                {
                    Console.Write("輸入不在範圍內!");
                    throw new ArgumentOutOfRangeException();
                }

                if (from == to)
                {
                    Console.Write("起始與目的地不能相同!");
                    throw new ArgumentOutOfRangeException();
                }
                #region // 取得 第三柱子
                /* 例如 輸入 1 3  得到  2
                 *      輸入 1 2  得到  3
                 *      輸入 2 3  得到  1
                 */

                int[] temp = { 1, 2, 3 };
                foreach (int item in temp)
                {
                    if (item != from && item != to)
                    {
                        aux = item;
                        break;
                    }
                }
                #endregion
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正整數!!  請重新輸入");
                goto Setup;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("  請重新輸入");
                goto Setup;
            }
            catch (Exception ex)
            {
                Console.WriteLine("發生無法預期之錯誤");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
        public void Play()
        {
            Hanoi(disk, from, to, aux);
            Exit();
        }
        private void Exit()
        {
            Console.WriteLine("======遊戲結束======");
            Console.WriteLine("===再玩一次?<Y/N>===");
        Exit:
            string mes = Console.ReadLine();
            try
            {
                if (mes == "Y" || mes == "y")
                {
                    Setup();
                    Play();
                }
                else if (mes == "N" || mes == "n")
                {
                    Console.WriteLine("---掰掰---");
                }
                else
                {
                    Console.WriteLine("輸入錯誤!!請輸入<Y/N>");
                    goto Exit;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                System.Environment.Exit(0);
            }
        }
        private void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
            //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
            try
            {
                if (Disk == 1)
                {
                    Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                }
                else
                {
                    Hanoi(Disk - 1, Src, Aux, Dest);
                    Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                    Hanoi(Disk - 1, Aux, Dest, Src);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("發生無法預期之錯誤");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}
