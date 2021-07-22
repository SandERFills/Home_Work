using System;

namespace ConsoleLogging
{
    class ConsoleLog : Ilogger
    {
      public void LogInConsole(Lvl lvl,string message){
           
           switch (lvl)
           {
               case Lvl.Warning:Console.ForegroundColor=ConsoleColor.Yellow;
               break;
                case Lvl.Error:Console.ForegroundColor=ConsoleColor.Red;
               break;
               case Lvl.Message:Console.ForegroundColor=ConsoleColor.Blue;
               break;
               default:System.Console.WriteLine("Dosen't work");
               break;
           }
               
           
           System.Console.WriteLine($"{lvl} {message}");
           Console.ResetColor();
       }
    }
}

