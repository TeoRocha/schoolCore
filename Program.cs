using System;
using schoolCore.Entity;
using static System.Console;
using System.Collections.Generic;
using schoolCore.Util;

namespace schoolCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var SchoolEngine = new SchoolEngine();
            SchoolEngine.Init();
            
            Printer.WriteTitle("School courses");
        }

    }
}
