using System;

namespace ConsoleLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLog conlog =new ConsoleLog();
            conlog.LogInConsole(Lvl.Warning,"Wow");
            conlog.LogInConsole(Lvl.Message,"Now");
            conlog.LogInConsole(Lvl.Error,"Now");
        }
    }
}
