using System;

namespace StructsYEnum
{

    class Program
    {
        static void Main(string[] args)
        {
            Bonus Antonio = Bonus.bueno;
            Console.WriteLine(Antonio);


        }
    }

    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 }

}
