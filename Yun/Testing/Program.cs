using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATLYR;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            dbConnect cn = new dbConnect();
            Console.WriteLine(cn.connect());
            Console.Read();
        }
    }
}
