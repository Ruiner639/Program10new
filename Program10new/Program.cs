using System;

namespace Program10new
{
    public class person
    {
        string name;
        string email;
        int age;
        public person(string name, string email, int age)
        {
            name = test1(name);
            this.name = name;
            email = testEmail(email);
            this.email = email;
            age = testAge(age);
            this.age = age;
            PrintAll(name, email, age);
        }
        public person(string name, int age)
        {
            name = test1(name);
            this.name = name;
            age = testAge(age);
            this.age = age;
            PrintNotAll(name, age);
        }
        public string test1(string test)
        {
            while ((String.IsNullOrEmpty(test)) != false)
            {
                Console.WriteLine("Please enter correct information");
                test = Console.ReadLine();
                return test;
            }
            Console.WriteLine();
            return test;
        }
        public string testEmail(string email)
        {
            while (((String.IsNullOrEmpty(email)) || (email.Contains("@"))) != true)
            {
                Console.WriteLine("Please enter correct email");
                email = Console.ReadLine();
            }
            return email;
        }
        public int testAge(int age)
        {
            while (((age >= 1) && (age <= 100)) != true)
            {
                Console.WriteLine("Please enter correct age");
                age = Convert.ToInt32(Console.ReadLine());
                return age;
            }
            return age;
        }
        public void PrintAll(string name, string email, int age)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Age: " + age);
        }
        public void PrintNotAll(string name, int age)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 22;
            string email = "John1998@email.com";
            new person(name, email, age);
            Console.WriteLine();
            new person(name, age);
        }
    }
}
