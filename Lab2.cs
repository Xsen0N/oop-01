using System;

namespace OOP2
{
    public partial class Phone {
        private readonly int ID;
        private string name;
        private string surname { get; set; }; // можно так инициализировать
        private string patronymic { get; set; }
        private string addres {get; set;}
        private string cardnum;
        private long timeoftalk { get; set; }
        public long kredit { private set; get; }
        private long debit;
        static int counter = 0;
        private static string about = "Класс, для представления данных об обладателе телефона";

                                //       private Phone(){}// не допускает других конструкторов по умолчанию
        public static int Counter => counter; //для подсчета создпнных объектов

        public Phone(Phone phone)
        {
            ID = phone.GetHashCode();
            Console.WriteLine("Client's ID: " + ID);
        }
        public Phone(string surname) => this.surname = surname;

        public Phone( string name, string cardnum) {
            this.name = name;
            this.cardnum = cardnum;
        }

        public Phone(string n, long calltime)
        {
            n = name;
            calltime = timeoftalk;
        }
        public Phone()
        {
            name = "Noname";
            surname = "Nosuname";
            patronymic = "Nopatronymic";
            addres = "aaaaaaaaaaaaaaaa";
            timeoftalk = 0;
            counter++;
        }
        public void setname(string name)
        {
            if (name.Length > 0)
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
        public string getname()
        {
            return name;
        }

        public void setcardnum(string cardnum) {
            if (cardnum.Length == 16){
                this.cardnum = cardnum;
            } else {
                Console.WriteLine("Некорректный ввод");
            }           
        }       
        public string getcardnum() {
            return  cardnum;
        }
        public void setDeb(long debit)
        {
            if (debit > 0)
            {
                this.debit = debit;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
        public long getDeb()
        {
            return debit;
        }

        public static string GetInfo() { return about; }
    }
    class Lab2
    {
        static void Main(string[] args)
        {
            // Phone phone = new Phone(10, "Катя", "Иванова", "12345678");    
            Phone phone = new Phone();
            phone.setcardnum("1234");
            phone.setcardnum("1234123412341234");
            Console.WriteLine(phone.getcardnum());
            //int n = 3;
            //Phone[] abonents = new Phone[n];
            Console.WriteLine("Заданное время межгородских перпеговоров: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Client's ID " + phone.GetHashCode());
        }
    }
}
