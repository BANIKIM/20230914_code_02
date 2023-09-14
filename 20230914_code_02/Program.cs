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
                        Console.Write(" "+arr[y, x]+" ");

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
                            arr[y, x] = 0;
                        }

                    }
                    Console.WriteLine();
                }

                binggo = 0;// 검사하기 전 초기화를 통해서 3빙고 검사에 버그를 방지

                //가로 빙고 검사
                if (arr[0, 0] == 0 && arr[0, 1] == 0 && arr[0, 2] == 0 && arr[0, 3] == 0 && arr[0, 4] == 0)
                {
                    binggo++;
                }
                if (arr[1, 0] == 0 && arr[1, 1] == 0 && arr[1, 2] == 0 && arr[1, 3] == 0 && arr[1, 4] == 0)
                {
                    binggo++;
                }
                if (arr[2, 0] == 0 && arr[2, 1] == 0 && arr[2, 2] == 0 && arr[2, 3] == 0 && arr[2, 4] == 0)
                {
                    binggo++;
                }
                if (arr[3, 0] == 0 && arr[3, 1] == 0 && arr[3, 2] == 0 && arr[3, 3] == 0 && arr[3, 4] == 0)
                {
                    binggo++;
                }
                if (arr[4, 0] == 0 && arr[4, 1] == 0 && arr[4, 2] == 0 && arr[4, 3] == 0 && arr[4, 4] == 0)
                {
                    binggo++;
                }
                //세로 빙고 검사
                if (arr[0, 0] == 0 && arr[1, 0] == 0 && arr[2, 0] == 0 && arr[3, 0] == 0 && arr[4, 0] == 0)
                {
                    binggo++;
                }
                if (arr[0, 1] == 0 && arr[1, 1] == 0 && arr[2, 1] == 0 && arr[3, 1] == 0 && arr[4, 1] == 0)
                {
                    binggo++;
                }
                if (arr[0, 2] == 0 && arr[1, 2] == 0 && arr[2, 2] == 0 && arr[3, 2] == 0 && arr[4, 2] == 0)
                {
                    binggo++;
                }
                if (arr[0, 3] == 0 && arr[1, 3] == 0 && arr[2, 3] == 0 && arr[3, 3] == 0 && arr[4, 3] == 0)
                {
                    binggo++;
                }
                if (arr[0, 4] == 0 && arr[1, 4] == 0 && arr[2, 4] == 0 && arr[3, 4] == 0 && arr[4, 4] == 0)
                {
                    binggo++;
                }
                //대각선 검사
                if(arr[0, 0] == 0 && arr[1, 1] == 0 && arr[2, 2] == 0 && arr[3, 3] == 0 && arr[4, 4] == 0)
                {
                    binggo++;

                }
                if (arr[0, 4] == 0 && arr[1, 3] == 0 && arr[2, 2] == 0 && arr[3, 1] == 0 && arr[0, 4] == 0)
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
