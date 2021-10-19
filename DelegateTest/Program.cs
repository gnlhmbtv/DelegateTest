using System;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> test = Fullname;
            Predicate<int> salary = Salary;
            Action<string, string> favmusic = FavMusic;
            Console.WriteLine(test("Gunel","Humbatova"));
            Console.WriteLine(salary(1500));
            favmusic("Jeferrson Airplane","White Rabbit");
        }
        public static string Fullname(string name,string surname) //func
        {
            return $"{name} {surname}";
        }
        public static bool Salary(int salary)  //predicate
        {
            return salary > 1000;
        }
        public static void FavMusic(string singer,string music)
        {
            Console.WriteLine($"{singer}-{music}");
        }
        
    }
}
