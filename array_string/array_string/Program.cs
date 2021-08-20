using System;
using static System.Console;
using System.Linq;
using System.Text;

namespace array_string
{
    class Program
    {
        static void PrintArr<T>(string PassString, T[] arr)
        {
            WriteLine(PassString);
            foreach (var el in arr) { Write(el); Write('\t'); }
            WriteLine();
        }
        static void Main(string[] args)
        {
            //
            //Console.WriteLine("\nМассивы\n");
            //var rnd = new Random();
            //int[] mas1 = new int[] { 1, 2, 3, 4, 5 };
            //int k = (int)mas1.GetValue(3);
            //WriteLine("\n" + k + ' ' + mas1[3] + '\n');
            //foreach (int el in mas1) { Write(el); Write('\t'); }
            //WriteLine("\nmas2:\n");
            //int[,] mas2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //foreach (int el in mas2) { Write(el); Write('\t'); }
            //WriteLine("\nmas2 new:\n");
            //int i;
            //for (i = 0; i < 2; i++) mas2[i, 0] = rnd.Next(11, 20);
            //for (i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++) Write(mas2[i, j] + " ");
            //    WriteLine();
            //}

            ////2 2 2 2
            //int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.Resize(ref myArr1, 12);
            //myArr1[10] = 11;
            //WriteLine(myArr1.Length);
            //myArr1.Append(i);
            //PrintArr("Массив myArr1", myArr1);
            //int[] tempArr = (int[])myArr1.Clone();
            //Array.Reverse(myArr1, 3, 4);
            //PrintArr("\nМассив myArr1 после реверсирования", myArr1);
            //myArr1 = tempArr;
            //PrintArr("\nМассив myArr1 после восстановления", myArr1);
            //int[] myArr2 = new int[20];
            //PrintArr("\nМассив myArr2 до копирования", myArr2);
            //myArr1.CopyTo(myArr2, 5);
            //PrintArr("\nМассив myArr2 после копирования", myArr2);
            //Array.Clear(myArr2, 0, myArr2.GetLength(0));
            //PrintArr("Массив myArr2 после чистки: ", myArr2);
            //Array.Resize(ref myArr2, 10);
            //PrintArr("Массив myArr2 после изменения размера:", myArr2);
            //myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            //PrintArr("Несортированый массив myArr2: ", myArr2);
            //Array.Sort(myArr2);
            //PrintArr("Массив myArr2 после сортировки: ", myArr2);
            //WriteLine("Число 5 находится в массиве на " + Array.BinarySearch(myArr2, 5) + " позиции");
            //WriteLine("Максимальный элемент в массиве myArr2: " + myArr2.Max());
            //WriteLine("Минимальный элемент в массиве myArr2: " + myArr2.Min());
            //WriteLine("Среднее арифметическое элементов myArr2: " + myArr2.Average());



            //int[,,] myArr3 = { { { 1, 2, 3 }, { 4, 5, 6 } } };
            //WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);

            //3 3 3  Зубчатые массивы
            int size = 5, i;
            int[][] arr = new int[size][]; //объявление вложенного массива
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[i + 1]; //создание внутренних массивов
            }
            for (i = 0; i < arr.Length; i++) // Length -количество строк
            {
                for (int j = 0; j < arr[i].Length; j++) //Length - количество элементов текущего внутреннего массива
                {
                    arr[i][j] = i + j + 1; //заполнение внутренних массивов
                    Write(arr[i][j] + " "); //вывод на экран элементов
                }
                WriteLine();
            }

            int RemRow = Convert.ToInt32(ReadLine());

            Array.Copy(arr, RemRow, arr, RemRow + 1, 3/*arr.Length - 1 - RemRow*/); Array.Resize(ref arr, arr.Length - 1);
            WriteLine("\n After\n");
            for (i = 0; i < arr.Length; i++) // Length -количество строк
            {
                for (int j = 0; j < arr[i].Length; j++) //Length - количество элементов текущего внутреннего массива
                {
                    arr[i][j] = i + j + 1; //заполнение внутренних массивов
                    Write(arr[i][j] + " "); //вывод на экран элементов
                }
                WriteLine();
            }
            //arr[0].Append(66);
            //foreach (int[] el in arr) PrintArr("\nстрока = ", el);
            //
            //WriteLine("Строки");
            //string str1 = "Простая строка";
            //char[] chrArr ={'П','р','о','с','т','а','я',' ','с','т','р','о','к','а'};
            //string str2 = new string(chrArr);

            //string str3 = new string(chrArr, 8, 6);
            //string str4 = new string('$', 10);
            //WriteLine("str1: " + str1);
            //WriteLine("str1: " + str1);
            //WriteLine("str2: " + str2);
            //WriteLine("str3: " + str3);
            //WriteLine("str4: " + str4);
            //char[] chrArrCopy = new char[6];
            //str1.CopyTo(8,chrArrCopy,0,6);
            //WriteLine(chrArrCopy);
            //string strPath1 = "D:\\Student\\MyProjects\\Strings\\";
            //string strPath2 = @"D:\Student\MyProjects\Strings\";  //verbatim-string,  буквальная строка
            //Console.WriteLine(strPath1);
            //Console.WriteLine(strPath2);

            //str1 = "Простая строка";
            //str2 = "Строка";
            //str3 = "строка";
            //string[] strArr = { "ШАГ", "шагаем", "бежим", "ем", "Играем" };
            //Console.WriteLine("\"" + str1 + "\" equal \"" + str2 + "\" : " + str1.Equals(str2));
            //Console.WriteLine("\"" + str2 + "\" == \"Строка\" : " + (str2 == "Строка"));
            //Console.WriteLine("\"" + str2 + "\".CompareTo(\"" +  str3 + "\") : " + str2.CompareTo(str3));
            //Console.WriteLine("Сравнение без учета регистра:");
            //Console.WriteLine("\"" + str2 + "\" equal \"" + str3 + "\" : " + str2.Equals(str3, StringComparison.CurrentCultureIgnoreCase));
            //Console.Write("Слова начинающиеся на \"шаг\": ");
            //foreach (string s in strArr)
            //    if (s.StartsWith("шаг", StringComparison.CurrentCultureIgnoreCase)) Console.Write(s + " ");
            //Console.Write("\nСлова заканчивающиеся на  \"ем\": ");
            //foreach (string s in strArr)
            //   if (s.EndsWith("ем", StringComparison.CurrentCultureIgnoreCase)) Console.Write(s + " ");
            //Console.WriteLine();
            //str1 = "Простая строка - это строка";
            //Console.WriteLine("Первое вхождение символа \'о\': " + str1.IndexOf('о'));
            //Console.WriteLine("Первое вхождение подстроки  \"строка\" : " + str1.IndexOf("строка"));
            //Console.WriteLine("Последнее вхождение символа \'р\': " + str1.LastIndexOf('р'));
            //str2 = "тяа";
            //Console.WriteLine("Последнее вхождение любого из символов строки " + "\"тяа\" : " + str1.LastIndexOfAny(str2.ToCharArray()));
            //Console.WriteLine("Подстрока начиная с 11 символа по 16 - й : " + str1.Substring(11, 16));
            //str2 = " символов";
            //str3 = str1 + "  " + str2;
            //str3=str3.Insert(8, " символьная ");
            //WriteLine(str3);
            //str3=str3.Replace("строка", "string").ToUpper();
            //WriteLine(str3);

            //WriteLine("StringBuilder");
            //StringBuilder sb = new StringBuilder("hello",10);
            ////sb = "hello"; Error
            //sb.Append("hello"); // добавление строки к существующей
            //sb.AppendLine(); // добавление пустой строки к существующей
            //sb.AppendLine();
            //sb.Append("world");
            //Console.WriteLine("\n\tИсходная строка");
            //Console.WriteLine(sb);
            //Console.WriteLine("Максимальное количество символов " + sb.Capacity);
            //Console.WriteLine("Длина текущего объекта " + sb.Length);
            //for (int ii = 0; ii < sb.Length; ii++)
            //    Write(""+sb[ii] + '\t');
            //WriteLine("\n"+(sb[6] == '\n'));
            //WriteLine(sb[7] == '\r');
            //Console.WriteLine("Длина текущего объекта " + sb.Length);
            //Console.WriteLine("\n\tВставка строки");
            //sb.Insert(7, "abracadabra"); //вставка строки в заданную позицию
            //Console.WriteLine(sb);
            //Console.WriteLine("Максимальное количество символов " + sb.Capacity);
            //Console.WriteLine("Длина текущего объекта " + sb.Length);
            //Console.WriteLine("\n\tЗамена символов 'a' на 'z'");
            //sb.Replace('a', 'z'); // замена символов строки
            //Console.WriteLine(sb);
            //Console.WriteLine("\n\tУдаление 10 символов начиная с 3");
            //sb.Remove(3, 10); // удаление символов из строки
            //Console.WriteLine(sb);
            //Console.WriteLine("Максимальное количество символов " +
            //sb.Capacity);
            //Console.WriteLine("Длина текущего объекта " + sb.Length);

            //float[,] masFloat = { { 1.2f, 4.3f, 2.4f, 3.5f }, { 5.7f, 2.1f, 9.7f, 7.7f }, { 1.1f, 3.2f, 7.8f, 34.5f } };
            //int[] masInt = { 3, 78, 12, 45, 100 };

            ////float max = masInt.Max() > masFloat.Max() ? masInt.Max() : masFloat.Max();
            //WriteLine();
            //int size = masFloat.Length + masInt.Length;
            //float[] Rez = new float[size]; int i = 0;
            //foreach (float el in masFloat) Rez[i++] = el;
            //masInt.CopyTo(Rez, masFloat.Length);
            //PrintArr("ff", Rez);
            //WriteLine(Rez.Max());
            //Rez.Append<float>(1000);
            //Array.Sort(Rez);
            //PrintArr("ff", Rez);
            //foreach (float el in masFloat) Write(el+" ");
            //string ss="dfg hjk rty qwe";
            //string[] sl = ss.Split(' ');
            //foreach (var el in sl) WriteLine(el);
            int v = 345;
            char[] vs =Convert.ToString(v).ToCharArray();
            Array.Reverse(vs);//,0, vs.Length);
            int vRez =  Convert.ToInt32(new string(vs));
            WriteLine("v={0}, vRez={1}", v, vRez);
            char c = ReadKey().KeyChar;
            Console.Clear();
            Console.SetBufferSize(5, 10);
            WriteLine(c);

        }
    }
}

            
            
           
