using System;
using System.Collections.Generic;

namespace interviewTraning
{
    class Program
    {
         private static Object syncObject = new Object();
    private static void Write()
    {
        lock (syncObject)
        {
            Console.WriteLine("test");
        }
    }
        static void Main(string[] args)
        {
            #region   List  
//             List<Action> actions = new List<Action>();
// for(var count=0; count<10; count++)
// {
//     actions.Add(() => Console.WriteLine(count));
// }
// foreach(var action in actions)
// {
//     action();
// }
#endregion
        #region String Compare
//         var s1 = string.Format("{0}{1}", "abc", "cba");
// var s2 = "abc" + "cba";
// var s3 = "abccba";
 
// Console.WriteLine(s1 == s2);
// Console.WriteLine((object)s1==(object)s2);
// Console.WriteLine(s2==s3);
// Console.WriteLine((object)s2==(object)s3);
        #endregion
        #region 
        lock (syncObject)
        {
            Write();
        }
        #endregion
        }
    }
}
