// using System;
// public sealed class Singleton
// {




//     private static int Counter = 0;

//     private static Singleton Instance = null;

//     public static Singleton GetInstance()
//     {

//         if (Instance == null)
//         {

//             Instance = new Singleton();
//         }
//         return Instance;
//     }

//     private Singleton()
//     {
//         Counter++;
//         Console.WriteLine("Counter Value " + Counter.ToString());

//     }
//     public void Printde(string message)
//     {
//         Console.WriteLine(message);
//     }
// }


// class program
// {

//     static void Main(string[] args)
//     {
//         Singleton uio = Singleton.GetInstance();
//         uio.Printde("hello");
//         Singleton ert = Singleton.GetInstance();
//         ert.Printde("ghgffghhgf");
//     }
// }


