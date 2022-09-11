using System;
//директивa using  сообщает компилятору, где он должен искать классы (типы), не
//определенные в данном пространстве имен.

namespace lab1
{
    class Types
    {
        static void Main(string[] args)
        {
            bool valueBool = true; 
            Console.WriteLine(valueBool ? "Checked" : "Not checked" + " " + valueBool.GetType());
            Console.WriteLine(true ? "Checked" : "Not checked" );

            sbyte valueSByte = 110; //От -128 до 127. Знаковое 8-битное целое число
            Console.WriteLine(valueSByte + " " + valueSByte.GetType() + "\n");

            byte valueByte = 255; // От 0 до 255. Беззнаковое 8-битное целое число
            Console.WriteLine(valueByte + " " + valueByte.GetType());
            Console.WriteLine(valueByte + " " + Convert.ToInt32(valueByte).GetType()); //явное преобразование 
            Console.WriteLine(valueByte + " " + valueByte.GetType() + "\n");

            short valueShort = 31700;//От -32 768 до 32 767. Знаковое 16-битное целое число
            Console.WriteLine(valueShort + " " + valueShort.GetType() + "\n");

            ushort valueUShort = 65535;//От 0 до 65 535. Беззнаковое 16-битное целое число
            Console.WriteLine(valueUShort + " " + valueUShort.GetType() + "\n");

            int valueInt = -2147483647;//От - 2 147 483 648 до 2 147 483 647. 32 - битное целое со знаком
            Console.WriteLine(valueInt + " " + valueInt.GetType() + "\n");

            uint valueUInt = 0;//От 0 до 4 294 967 295. Беззнаковое 32-битное целое число
            Console.WriteLine(valueUInt + " " + valueUInt.GetType() + "\n");

            long valueLong = -930492842343423; //От -9,223,372,036,854,775,808 до 9,223,372,036,854,775,807.	64-битное целое число со знаком
            Console.WriteLine(valueLong + " " + valueLong.GetType() + "\n");

            ulong valueUlong = 2322222222222245; //От 0 до 18 446 744 073 709 551 615. Беззнаковое 64-битное целое число
            Console.WriteLine(valueUlong + " " + valueUlong.GetType() + "\n");

            char valueChar = 'A'; // хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            char valueChar1 = '\u0420'; // \u - юникод, четырехсимвольное шестнадцатеричное представление символьного кода; \x - шестнадцатиричное значение
            Console.WriteLine(valueChar + " " + valueChar.GetType() + " " + valueChar1 + " " + valueChar1.GetType() + "\n");

            double valueDouble = 12.3;
            Console.WriteLine(valueDouble + " " + valueDouble.GetType() + "\n");

            decimal valueDecimal = 0.251m;
            Console.WriteLine(valueDecimal + " " + valueDecimal.GetType() + "\n");

            float valueFloat = 3.1456789234f;
            Console.WriteLine(valueFloat + " " + valueFloat.GetType() + "\n");

            object valueObject = "Hello";
            object valueObject1 = 3.14;
            Console.WriteLine($"Объект 1: {valueObject}\nОбъект 2: {valueObject1}");
            Console.WriteLine(valueObject.GetType() + "   " + valueObject1.GetType() + "\n");

            var valueVar = 93;
            Console.WriteLine(valueVar + " " + valueVar.GetType());
            valueVar = 100;
            Console.WriteLine(valueVar + " " + valueVar.GetType());
            Console.WriteLine(valueVar + " " + Convert.ToString(valueVar).GetType());
            Console.WriteLine(valueVar + " " + valueVar.GetType() + "\n");

            dynamic valueDynamic = "Hi";
            Console.WriteLine(valueDynamic + " " + valueDynamic.GetType());
            valueDynamic = 93;
            Console.WriteLine(valueDynamic + " " + valueDynamic.GetType() + "\n");

            dynamic dyn = 1;
            dyn = dyn + 3;
            Console.WriteLine(dyn + "\n");

            //-------------------явное и неявное преобразование---------------------
            int changable_first = 2147483647;
            double changable_second = 1234.7;
            sbyte changable_third = 125;
            short changable_fourth = 31767;
            ushort changable_fifth = 64535;
            uint changable_sixth = 429496295;
            long changable_seventh = 9223372036854775807;
            byte changable_eight = 25;   
            short changable_nine = 30;
            int changable_ten = 1000;

            int conspicuous_first = (int)changable_second; //явное преобразование
            Console.WriteLine(changable_second.GetType()); //было double 
            Console.WriteLine(conspicuous_first.GetType()+"\n");//стало int
            byte conspicuous_second = (byte)changable_third; // явное преобразование
            ulong conspicuous_third = (ulong)changable_seventh; // явное преобразование
            ushort conspicuous_fourth = (ushort)changable_nine; //явное преобразование
            uint conspicuous_fifth = (uint)changable_ten; // явное преобразование
            int inconspicuous_second = changable_fourth; // неявное преобразование 
            int inconspicuous_third = changable_fifth; //неявное преобразование
            long inconspicuous_fourth = changable_sixth; //неявное преобразование
            long inconspicuous_first = changable_first; //неявное преобразование
            int inconspicuous_fifth = changable_eight; // неявное преобразование

            byte a = 4; //расширяющее преобразование
            int b = a + 70;

            byte c = 4;
            byte d = (byte)(c + 70);

            ushort e = 4;
            byte f = (byte)e; // для сужающего преобразования

            Console.WriteLine(valueVar + " " + valueVar.GetType() + "\n");
            Console.WriteLine(valueVar + " " + Convert.ToSingle(valueVar).GetType()+ "\n") ;

            int n = Convert.ToInt32("46");

            string dateString = "08/09/2022";
            Convert.ToDateTime(dateString);

            Console.WriteLine($"n = {n} и dateString = {dateString} и при конвертации " + Convert.ToDateTime(dateString));

            //------------------------- упаковка/распаковка значимых типов ----------------------
            int alfa = 1; // упаковка единицы в переменную alfa

            object beta = alfa; // копируем значение в управляемую кучу, взамен получая ссылку на эти данные

            int omega = (int)beta; // происходит операция распаковки
                                   // операция очень малоэффективна, из-за вызова сборщика мусора а также огромного количества различных действий


            double eco = 2.93;
            Object obj2 = eco;
            eco = (Int32)eco; //пример распаковки в int - округление в меньшую сторону
            Console.WriteLine(eco);
            Console.WriteLine(eco.GetType() + "\n");

            //------------------------ неявно типизированная переменная ----------------------
            // var -- не тип данных, синтаксис указывающий языку на то что ему необходимо самостоятельно определить тип данных 
            var notADataType = new float[10];
            // notADataType = 4; // ошибка, т.к. сторгая типизация
            Console.WriteLine(notADataType.GetType());

            var notADataType2 = 32;
            var notADataType3 = 2;

            Console.WriteLine(notADataType2 + notADataType3);

            //var notADataType4 = null; // null - такое значение принимает ссылочный тип или nullable, но какая переменная?)) не понятно!
            var notADataType5 = "String";
            notADataType5 = null;
            // или var notADataType = (string)null;
            Console.WriteLine(notADataType5);

            //---------------------- пример работы с nullable -----------------

            int? n1 = null;
            bool? n2 = null;
            Nullable<bool> n3 = true;
            n3 = null;

            Console.WriteLine(n1 + " - nullable int;" + n2 + " - nullable bool;" + n3 + " - nullable bool после инициализации;");

            int x1 = 4;
            int? x2 = x1;
            x2 = null;
            Console.WriteLine(x2 + " - nullable неявное преобразование к null");

            //-------------------

            var hello = 2;
            Console.WriteLine(hello);
           // hello = "Привет";// - исключение

        }
    }
 }

