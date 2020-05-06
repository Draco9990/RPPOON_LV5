using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class ConsoleLogger
    {

        public static ConsoleLogger instance;

        public static ConsoleLogger GetInstance()
        {
            if(instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void Log(string msg)
        {
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(msg);
        }
    }
}
