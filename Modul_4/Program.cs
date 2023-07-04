class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string LName, string Login, int LoginLenght, bool Pet, double Age, string[] FavColor) User;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Пользователь №{i + 1} ");
            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            User.LName = Console.ReadLine();
            Console.Write("Ввкдите логин: ");
            User.Login = Console.ReadLine();
            User.LoginLenght = User.Login.Length;
            Console.Write("Есть ли у вас животные?(да/нет): ");
            string xp = Console.ReadLine();
            if (xp == "да")
                User.Pet = true;
            else
                User.Pet = false;
            Console.Write("Введите возраст пользователя: ");
            User.Age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите три любимых цвета:");
            User.FavColor = new string[3];
            foreach (string x in User.FavColor)
            {
                Console.ReadLine();
            }
        }
        Console.ReadKey();



    }
}

