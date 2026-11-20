using System;
/*
class Program
{
    static void greetings()
    {
        Console.WriteLine("Hello, Welcome to  today lecture");
    }

    static void Main(string[] args)
    {
        greetings();
    }
}
*/

//with default parameter
/*
class Program
{
    static void MyWorld(string country = "Kenya")
    {
        Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
        MyWorld("Tanzania");
        MyWorld();
    }
}
*/
class Program
    {   

    static int MyAge(int age)
        {
            return age;
        }

    static void Main(string[] args)
        {
            Console.WriteLine(MyAge(22));
        }
    }
