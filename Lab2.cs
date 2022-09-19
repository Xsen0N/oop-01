using System;

namespace OOP2
{
    public partial class Phone {
        private readonly int ID;
        private string name;
        public string surname { get; set; }; // можно так инициализировать
        public string patronymic { get; set; }
        public string addres {get; set;}
        private string cardnum;
        public long timeoftalk { get; set; }
        public long kredit { private set; get; }
        private long debit;
        static int counter = 0;
        public const int SpeedOfsound = 300; // m per sec.
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

        public Phone(string n, long calltime, long k))
        {
            n = name;
            k = kredit;
            a = addres;
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

        internal void Balance(long k, long d, out long money)
        {
            money = d - k;
            Console.WriteLine("Balance: " + money);
        }
    }
    class Lab2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Phone.GetInfo());
            Phone[] abonents = new Phone[4];
            abonents[0] = new Phone("Иванова");
            abonents[1] = new Phone(abonents[0]);
            abonents[2] = new Phone("Светлана", "ул. Светлова 36,96", 452);
            abonents[3] = new Phone();
            abonents[1].setcardnum("1234");//некорректный ввод, проверяемый в сеттере
            abonents[1].setname("Екатерина");
            Console.WriteLine(abonents[1].getname());
            Console.WriteLine("Тип созданного объекта" + abonents[1].GetType());
            abonents[0].setDeb(486);
            abonents[0].Balance(45454, 484848, out long resulte);
            abonents[1].setcardnum("1234123412341234");
            abonents[0].setcardnum("4321432143214321");
            abonents[2].setcardnum("1234567899874563");
            abonents[3].setcardnum("7856412398548654");
            Console.WriteLine(abonents[1].getcardnum());
            Console.WriteLine("Заданное время межгородских перпеговоров: ");
            abonents[1].timeoftalk = Convert.ToInt32(Console.ReadLine());
            abonents[0].timeoftalk = 4585325;
            abonents[3].timeoftalk = 2355;
            //внутригородские разговоры
            abonents[1].timeoftalkcity = 21;
            abonents[0].timeoftalkcity = 4585325;
            abonents[2].timeoftalkcity = 0;
            abonents[3].timeoftalkcity = 60;
            Console.WriteLine("Client's ID " + abonents[1].GetHashCode() + "\n");
            Console.WriteLine(abonents[1].ToString());
            int limit = 90;
            Console.WriteLine("Cведения об абонентах, у которых время внутригородских разговоров превышает заданное");
            for (int i = 0; i < 4; i++)
            {
                if (abonents[i].timeoftalkcity > limit)
                {
                    Console.WriteLine(abonents[i].ToString() + "\n");
                }

            }
            Console.WriteLine("Сведения об абонентах, которые пользовались междугородной связью");
            for (int i = 0; i < 4; i++)
            {
                if (abonents[i].timeoftalk > 0)
                {
                    Console.WriteLine(abonents[i].ToString() + "\n");
                }

            }
            var phone = new Phone { surname = "Tomson" };
            Console.WriteLine(phone.surname); // 
            var phone3 = new Phone { surname = "Nekenson" };
            var phone2 = new Phone { surname = "Tomson" };
            bool pEqualsP2 = phone.Equals(phone2);   // false
            bool pEqualsP3 = phone.Equals(phone3);   // true
            Console.WriteLine(pEqualsP2);
            Console.WriteLine(pEqualsP3);
        }
    }
}
