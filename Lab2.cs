using System;

namespace OOP2
{
    public partial class Phone {
        private int id; 
        private string name;
        public readonly string surname = "Undefined"; // можно так инициализировать
        private string patronymic;
        private string addres {get; set;}
        private string cardnum;
        private long timeoftalk;
        private long kredit;/* {get; set;}*/
        private long debit;
        static int nums = 7;
        private static string about = "Класс, для представления данных об обладателе телефона";
    public readonly string ID;  // можно так инициализировать
      //       private Phone(){}// не допускает других конструкторов по умолчанию
    public Phone(Phone phone )
        { //// в конструкторе также можно присвоить значение полю для чтения, а через метод - нет
            phone.GetHashCode();
        }
        public Phone(string surname)
        { //// в конструкторе также можно присвоить значение полю для чтения, а через метод - нет
            this.surname = surname;
        }
        public Phone(int id, string name, string cardnum) {
            this.id = id;
            this.name = name;
            this.cardnum = cardnum;
        }
        static Phone(){
            if (DateTime.Now.Year == 2022)
                nums = 7;
            else
                nums = 2;
        }
        public Phone(int id) : this()
        {
        }

        public Phone(string n, long calltime)
        {
            n = name;
            calltime = timeoftalk;
        }
        public Phone()
        {
            id = 0;
            name = "Noname";
            surname = "Nosuname";
            patronymic = "Nopatronymic";
            addres = "aaaaaaaaaaaaaaaa";
            timeoftalk = 0;
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
        public void settId(int id)
        {
            if (id > 0)
            {
                this.id = id;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
        public int getid() {
            return id;
        }
        public string getcardnum() {
            return  cardnum;
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
            phone.GetHashCode();
        }
    }
}
