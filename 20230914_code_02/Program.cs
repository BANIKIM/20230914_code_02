using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230914_code_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnad = new Random();
            int[,] arr = new int[5, 5];
            string[,] arr_string = new string[5, 5];
            int tmep;
            int tmep_big = 0;
            int binggo = 0;
            int a = 1;
            int num = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    arr[y, x] = a;
                    a++;
                }
            }


            for(int i=0; i<10000; i++)
            {
                int num_1 = rnad.Next(0, 5);
                int num_2 = rnad.Next(0, 5);
                int num_3 = rnad.Next(0, 5);
                int num_4 = rnad.Next(0, 5);

                tmep = arr[num_1, num_2];
                arr[num_1, num_2] = arr[num_3, num_4];
                arr[num_3, num_4] = tmep;
            }

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    arr_string[y, x] = Convert.ToString(arr[y, x]);
             
                }
            }

            while (true)
            {
                if (tmep_big < binggo)
                {
                    tmep_big = binggo;
                }
                //화면출력
                Console.Clear();
                Console.WriteLine("=========빙고=========");
                Console.WriteLine($"빙고 : {tmep_big}");
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Console.Write(" "+ arr_string[y, x]+" ");

                    }
                    Console.WriteLine();
                }


                //숫자입력하는 것
                Console.Write("입력하세요");
                num = int.Parse(Console.ReadLine());
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        if (arr[y, x] == num)
                        {
                            arr_string[y,x] = "#";
                        }

                    }
                    Console.WriteLine();
                }

                binggo = 0;// 검사하기 전 초기화를 통해서 3빙고 검사에 버그를 방지

                //가로 빙고 검사
                if (arr_string[0, 0] == "#" && arr_string[0, 1] == "#" && arr_string[0, 2] == "#" && arr_string[0, 3] == "#" && arr_string[0, 4] == "#")
                {
                    binggo++;
                }
                if (arr_string[1, 0] == "#" && arr_string[1, 1] == "#" && arr_string[1, 2] == "#" && arr_string[1, 3] == "#" && arr_string[1, 4] == "#")
                {
                    binggo++;
                }
                if (arr_string[2, 0] == "#" && arr_string[2, 1] == "#" && arr_string[2, 2] == "#" && arr_string[2, 3] == "#" && arr_string[2, 4] == "#")
                {
                    binggo++;
                }
                if (arr_string[3, 0] == "#" && arr_string[3, 1] == "#" && arr_string[3, 2] == "#" && arr_string[3, 3] == "#" && arr_string[3, 4] == "#")
                {
                    binggo++;
                }
                if (arr_string[4, 0] == "#" && arr_string[4, 1] == "#" && arr_string[4, 2] == "#" && arr_string[4, 3] == "#" && arr_string[4, 4] == "#")
                {
                    binggo++;
                }
                //세로 빙고 검사
                if (arr_string[0, 0] == "#" && arr_string[1, 0] == "#" && arr_string[2, 0] == "#" && arr_string[3, 0] == "#" && arr_string[4, 0] == "#")
                {
                    binggo++;
                }
                if (arr_string[0, 1] == "#" && arr_string[1, 1] == "#" && arr_string[2, 1] == "#" && arr_string[3, 1] == "#" && arr_string[4, 1] == "#")
                {
                    binggo++;
                }
                if (arr_string[0, 2] == "#" && arr_string[1, 2] == "#" && arr_string[2, 2] == "#" && arr_string[3, 2] == "#" && arr_string[4, 2] == "#")
                {
                    binggo++;
                }
                if (arr_string[0, 3] == "#" && arr_string[1, 3] == "#" && arr_string[2, 3] == "#" && arr_string[3, 3] == "#" && arr_string[4, 3] == "#")
                {
                    binggo++;
                }
                if (arr_string[0, 4] == "#" && arr_string[1, 4] == "#" && arr_string[2, 4] == "#" && arr_string[3, 4] == "#" && arr_string[4, 4] == "#")
                {
                    binggo++;
                }
                //대각선 검사
                if(arr_string[0, 0] == "#" && arr_string[1, 1] == "#" && arr_string[2, 2] == "#" && arr_string[3, 3] == "#" && arr_string[4, 4] == "#")
                {
                    binggo++;

                }
                if (arr_string[0, 4] == "#" && arr_string[1, 3] == "#" && arr_string[2, 2] == "#" && arr_string[3, 1] == "#" && arr_string[0, 4] == "#")
                {
                    binggo++;

                }

                //3빙고 검사
                if (binggo >= 3)
                {
                    Console.WriteLine($"{binggo}빙고!");
                    break;
                }
              
             
            }




        }
    }


}
