using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = true;
            bool uncorrect = false;

            byte bnum = 127;
            sbyte sbnum = -127;

            short snum = -15;
            ushort usnum = 15;

            int inum = -6;
            uint unum = 6;

            long lnum = -789;
            ulong ulnum = 789;

            float fnum = 123.4f;

            double dnum = 456.864;

            decimal denum = 0.485m;

            char a = 'A';

            string hello = "Hello";

            object obj = 456;

            Console.WriteLine(hello);

            Console.WriteLine($"Целое положительное число: {unum}");

            Console.WriteLine($" Трехзначное число {obj}, {dnum}, {ulnum}");

            Console.WriteLine("Число больше 0: {0}  Буква : {2}  Меньше 0 : {1}", bnum, sbnum, a);
            Console.Write("Введите свое любтиое блюдо: ");
            string dish = Console.ReadLine();
            Console.WriteLine($"Отлично! {dish} - это вкусно)");
            //part b
            int changable_first = 2147483647;

            long inconspicuous_first = changable_first; //неявное преобразование

            double changable_second = 1234.7;

            int conspicuous_first = (int)changable_second; //явное преобразование

            sbyte changable_third = 125;

            byte conspicuous_second = (byte)changable_third; // явное преобразование

            short changable_fourth = 31767;

            int inconspicuous_second = changable_fourth; // неявное преобразование 

            ushort changable_fifth = 64535;

            int inconspicuous_third = changable_fifth; //неявное преобразование

            uint changable_sixth = 429496295;

            long inconspicuous_fourth = changable_sixth; //неявное преобразование

            long changable_seventh = 9223372036854775807;

            ulong conspicuous_third = (ulong)changable_seventh; // явное преобразование

            byte changable_eight = 25;

            int inconspicuous_fifth = changable_eight; // неявное преобразование

            short changable_nine = 30;

            ushort conspicuous_fourth = (ushort)changable_nine; //явное преобразование

            int changable_ten = 1000;

            uint conspicuous_fifth = (uint)changable_ten; // явное преобразование

            //part c 
            // стек и куча это области оперативной памяти, для стека выделяется маленькая область, 
            // для кучи большая, для стека выделяется 1мб памяти, для каждого потока, т.е каждый поток имеет свой собственный стек, 
            // используется для хранения данных и методов, т.е для выполнения логики работы программы, это мало, соответственно используется куча, размер зависит от разрядности платформы,
            // для стека доступ к памяти быстрый и эффективный, для кучи нет, также для кучи используется сборщик мусора
            int alfa = 1; // упаковка единицы в переменную alfa

            object beta = alfa; // копируем значение в управляемую кучу, взамен получая ссылку на эти данные

            int omega = (int)beta; // происходит операция распаковки
                                   // операция очень малоэффективна, из-за вызова сборщика мусора а также огромного количества различных действий
                                   // part d
                                   // var -- не тип данных, синтаксис указывающий языку на то что ему необходимо самостоятельно определить тип данных 
            var t = new float[10];

            Console.WriteLine(t.GetType()); // вывод: System.Single[], указывающий на то что это массив типа float
                                            // part e
                                            // Nullable -- фича которая позволяет присвоить значения null значимым типам данных
            string str = null; // ссылочный тип данных может носить значение null

            int? absorb = null; // явный пример применения этой фичи

            Console.WriteLine($"{absorb}");

            //part f
            var example = "Hello world";
            //example = 186;
            //g
            bool expected = true;
            bool unexpected = false;

            if (expected == unexpected)
            {
                Console.WriteLine("Не по плану");
            }
            else
            {
                Console.WriteLine("По плану");
            }
        }
    }
}