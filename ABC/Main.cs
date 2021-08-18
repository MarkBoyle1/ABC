using System;

namespace ABC
{
    public class Program
    { 
        static void Main(string[] args)
        {
            ABC abc = new ABC();
            Console.WriteLine("ABC Kata results:");
            Console.WriteLine("A: " + abc.CanMakeWork("A"));
            Console.WriteLine("BARK: " + abc.CanMakeWork("BARK"));
            Console.WriteLine("BOOK: " + abc.CanMakeWork("BOOK"));
            Console.WriteLine("TREAT: " + abc.CanMakeWork("TREAT"));
            Console.WriteLine("COMMON: " + abc.CanMakeWork("COMMON"));
            Console.WriteLine("SQUAD: " + abc.CanMakeWork("SQUAD"));
            Console.WriteLine("CONFUSE: " + abc.CanMakeWork("CONFUSE"));
        }
    }
}
