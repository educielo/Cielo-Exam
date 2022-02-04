using System;
using System.Threading.Tasks;

namespace ThreadProb
{
    internal class Program
    {
        //Question: A
        //main execution starts
        static void Main(string[] args)
        {
            //Constant Value of pi
            //entry point caller for the asynchronous tasks T1 and t2
            Foo(Math.PI);
            //suspends all thread execution after 10 secs,
            //this means the await for the readline will exit after 10 secs
            //this will cause the program to stop
            System.Threading.Thread.Sleep(10000);
        }
        public static async void Foo(double a)
        {
            //Thread number 1 
            var sinA = Task.Run(() => Math.Sin(a));
            //Another task on the thread pool spawned but evaluated since it is awaited
            var b = double.Parse(await Task.Run(() => Console.ReadLine()));
            //task Number 3 on the thread pool
            var cosB = Task.Run(() => Math.Cos(b));
            //Thread 1 and 3 are awaited on the last part,
            //this returns them to the pool which scalability wise, is not good.
            Console.WriteLine( await sinA +  await cosB);
        }

    }
    
    //Question B:subsequent number of runs for a same number will return same results
    //the methods used are not dependent on any special calculations affected by timing.
    //PI is a constant value in this scenarion and the methods are expected to produce same output

    //Question C: There will be no output after 10 secs. Any inputs under 10 secs will be computed correctly.
    //this scenario is explained on the Question A's answer where the code suspends the thread using thread.Sleep after 10 secs
}
