using System;

namespace boots
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Class_Boots firstone = new Class_Boots(rand.Next(1, 4));
        }
    }
}
