namespace ExampleClasses
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void SetName(string name) { this.name = name; }
        public void SetAge(int age) { this.age = age; }
        public string GetName() { return name; }
        public int GetAge() { return age; }
        public void SayHello()
        {
            Console.WriteLine($"Дароу, меня обзывают {name}, мне {age} годиков");
        }
    }
    class NewPerson
    {
        private string name {get; set;} // Автоматическая генерация get, set (Не рекомендуется)
        private int age {get; set;}
        public NewPerson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age // По этому названию методу будет вызываться get и set автоматически
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
               if (value.Length > 3) name = value;
            }
        }
        public void SayHello()
        {
            Console.WriteLine($"Дароу, меня обзывают {name}, мне {age} годиков");
        }
    }
    class BankAccount
    {
        private string owner;
        private int balance;
        public void SetOwner(string owner) { this.owner = owner; }
        public void SetBalance(int balance) { this.balance = balance; }
        public string GetOwner() { return owner; }
        public int GetBalance() { return balance; }
        public BankAccount(string owner, int balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Количество для пополнения не может быть меньше 0");
            }
            SetBalance(GetBalance() + amount);
        }
        public void Withdraw(int amount)
        {
            if (GetBalance() < amount)
            {
                Console.WriteLine("Вы не можете списать больше, чем имеете");
            }
            if (amount <= 0)
            {
                Console.WriteLine("Количество для списания не может быть меньше 0");
            }
            SetBalance(GetBalance() - amount);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Owner - {GetOwner()}, balance - {GetBalance()}");
        }
    }
    class Program
    {
        static void PrintInfo(string name, int age)
        {
            Console.WriteLine($"name={name}");
            Console.WriteLine($"age={age}");
        }
        static int FindThirdAngle(int angle1, int angle2)
        {
            int angle3 = 180 - angle1 - angle2;
            return angle3;
        }
        static string ConToString(string str1, string str2)
        {
            return str1 + str2;
        }
        static List<int> SquareAllElements(List<int> lst)
        {
            var result = new List<int>();
            foreach(var i in lst)
            {
                result.Add(i*i);
            }
            return result;
        }
        static void Main(string[] args)
        {
            // PrintInfo("misha", 16);
            // PrintInfo(ConToString("Python", " is best"), 0);
            // var elem = SquareAllElements([1, 2, 3, 4]);
            // foreach(var i in elem)
            // {
            //     Console.WriteLine(i);
            // }
            // Person per1 = new Person("Дэбил", 24);
            // per1.SayHello();
            
            // NewPerson per2 = new NewPerson("Дэбилыч", 67);
            
            // Console.WriteLine(per2.Age);
            // per2.Age = 20;

            // per2.SayHello();
            BankAccount ban = new BankAccount("misha", 1000);
            ban.ShowInfo();
            ban.Deposit(500);
            ban.ShowInfo();
            ban.Withdraw(1000);
            ban.ShowInfo();
        }
    }
}