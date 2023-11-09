using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Enter yourname:");
            string yourname=Console.ReadLine();
            Console.WriteLine("yourname is "+ yourname);
            double myDouble= 9.22;
            int myInt= (int) myDouble; //Explicit type casting
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine(); //to print username in run time
            Console.WriteLine("Username is: " + userName); // to print username is: aboveusername
            Console.Write("Hello bujji "); // to print in sameline
            Console.Write("welcome to vegas");
            int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);
            int x= 2;
            int y= 3;
            int z = x + y;
            Console.WriteLine(z);
            string luck = "mummy";
            Console.WriteLine(luck);

        }
    }
}
