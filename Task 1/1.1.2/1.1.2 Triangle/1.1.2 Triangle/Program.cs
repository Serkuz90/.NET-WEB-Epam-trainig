using System;

namespace Triangles
{

    class Triangles 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите задачу");
            int taskNumber = ReadAndParce();
            switch (taskNumber)
            {
                    case 1:
                    {
                        Console.WriteLine("Введите число N");
                        int N = ReadAndParce();
                        Triangle2(N);
                    }
                    break;
                    case 2:
                    {
                        Console.WriteLine("Введите число N");
                        int N = ReadAndParce();
                        AnotherTriangle(N);
                    }
                    break;
                    case 3:
                    {
                        Console.WriteLine("Введите число N");
                        int N = ReadAndParce();
                        XmasTree(N);
                    }
                    break;
                    case 4:
                    {
                        SumOfNumbers();
                    }
                    break;
                    case 5:
                    {
                        FontAdjustment();
                    }
                    break;
                    case 6:
                    {
                        ArrayProcessing();
                    }break;
                case 7:
                    {
                        NoPositive();
                    }break;

                case 8:
                    {
                        NonNegativeSum();
                    }break;

                case 9:
                    {
                        Array2D();
                    }break;
            }

        }

        static bool Check(int x) => x > 0;
        static int ReadAndParce()
        {
            string N = Console.ReadLine() ?? string.Empty;

            int number;

            if (int.TryParse(N, out number) && Check(number)) return number;
            else
            {
                Console.WriteLine("Введите значение заново");
                return ReadAndParce();
            }
        }

        static void Triangle2(int N)
        {
            for (int i = 0; i <= N; i++)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }
        }

        static void AnotherTriangle(int N)
        {

            int g = -1;
            for (int i = 1; i <= N; i++)
            {

                g = g + 2;
                string str1 = new string(' ', N-i);
                string str2 = new string('*', g);
                string str3 = str1 + str2 + str1;
                Console.WriteLine(str3);

            }

        }
        static List<string> AnotherTriangleXmasTree(int N)
        {
            List<string> listString = new List<string>();
            int g = -1;
            for (int i = 0; i <= (N - 1); i++)
            {

                g = g + 2;
                string str1 = new string(' ', N - i - 1);
                string str2 = new string('*', g);
                string str3 = str1 + str2 + str1;

                listString.Add(str3);
            }

            return listString;

        }

        static void XmasTree(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                string str1 = new string(' ', N - i);
                List<string> listString = AnotherTriangleXmasTree(i);
                
                int count = listString.Count;

                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine(str1 + listString[j]);
                }
            }
        }

        static void SumOfNumbers()
        {
            int length = 1000;

            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                if ((i % 5 == 0) || (i % 3 == 0))
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Сумма цифр кратных трем и пяти равна " + sum);
        }

        static void FontAdjustment()
        {
            string fontsList = "";
            List<string> fonts = new List<string>();
            string strEnv = Environment.NewLine;

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Введите номер параметра надписи");
                Console.WriteLine();
                Console.WriteLine("1: Bold" + strEnv + "2: Italic" + strEnv + "3: Underline" + strEnv + "4: Выход");
                int fontNumber = ReadAndParce();

                switch (fontNumber)
                {
                    case 1:
                        {
                            string strFont = " Bold";
                            if (fonts.Contains(strFont))
                            {
                                fonts.Remove(strFont);
                            }
                            else
                            {
                                fonts.Add(strFont);
                            }


                        } break;

                    case 2:
                        {
                            string strFont = " Italic";
                            if (fonts.Contains(strFont))
                            {
                                fonts.Remove(strFont);
                            }

                            else
                            {
                                fonts.Add(strFont);
                            }
                        } break;

                    case 3:
                        {
                            string strFont = " Underline";
                            if (fonts.Contains(strFont))
                            {
                                fonts.Remove(strFont);
                            }
                            else
                            {
                                fonts.Add(strFont);
                            }
                            
                        } break;

                    case 4:
                        {
                            exit = true;
                        } break;
                    default:
                        {
                            Console.WriteLine("Такого шрифта нет, введите заного");
                            fontNumber = ReadAndParce();

                        } break;

                }
                Console.WriteLine("Параметры надписи");
                int count = fonts.Count;
                for (int i = 0; i < count; i++)
                {
                    Console.Write(fonts[i]);
                }
                Console.WriteLine(strEnv);


            }
        }



        static void ArrayProcessing()
        {
            int length = 50;
            int[] somenumbers = new int[length];

            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                somenumbers[i] = r.Next(100);
                //Console.WriteLine(somenumbers[i]);
            }

            int[] sortedNumbers = QuickSort(somenumbers, 0, length - 1);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(sortedNumbers[i]);
            }

            FindMaxAndMin(length, somenumbers);
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }    
            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }

        static void FindMaxAndMin(int length, int[] array)
        {
            int max = array[0];
            for (int i = 0; i < length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Максимальное значение = " + max);

            int min = array[0];
            for (int i = 0; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Максимальное значение = " + min);
        }

        static void NoPositive()
        {
            Random rnd = new Random();
            int[,,] array3D = new int[5, 5, 5];
            for (int x = 0; x<5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    for (int z = 0; z < 5; z++)
                    {
                        array3D[x, y, z] = rnd.Next(-20, 20);
                        
                        if (array3D[x,y,z] > 0)
                        {
                            array3D[x, y, z] = 0;
                        }
                        Console.WriteLine(array3D[x, y, z]);
                    }         
                }
            }


        }

        static void NonNegativeSum()
        {
            Random rnd = new Random();
            int[] justArray = new int[100];
            int sum = 0;
            for (int x = 0; x < 100; x++)
            {
                justArray[x] = rnd.Next(-200, 200);
                if (justArray[x] >= 0)
                {
                    sum = sum + justArray[x];
                }
            }
            Console.WriteLine(sum);
        }

        static void Array2D()
        {
            Random rnd = new Random();
            int[,] array2D = new int[10, 10];
            int sum = 0;
            for (int x = 0; x< 10; x++)
            {
                for (int y = 0;y< 10; y++)
                {
                    array2D[x, y] = rnd.Next(100);
                    if (((x+y)%2) == 0)
                    {
                        sum = sum + array2D[x, y];
                    }
                }

            }
            Console.WriteLine(sum);
        }

    }


}

