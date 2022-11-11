using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            //самый быстрый вариант
            var task1 = Task.Run(() =>
            {
                for (int i = 0; i < 100000000; i++)
                {
                    x++;
                }
            });


            task1.Wait();

            var task2 = Task.Run(() =>
            {
                for (int i = 0; i < 100000000; i++)
                {
                    x++;
                }
            });

            task2.Wait();

            Console.WriteLine(x);

            /////////////////////////////////////////////////////////////////////////////////
            //int x = 0;
            ////Semaphore
            ////Semaphore semaphore = new Semaphore(1,1);
            ////Mutex - 5 способ(супер медленный);
            //Mutex mutex = new Mutex();
            //Task[] tasks = new Task[2];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    tasks[i] = Task.Run(() =>
            //    {
            //        for (int i = 0; i < 100000000; i++)
            //        {
            //            mutex.WaitOne();
            //            Console.WriteLine(x);
            //            x++;
            //            mutex.ReleaseMutex();
            //        }
            //    });
            //}
            //Task.WaitAll(tasks);  
            //Console.WriteLine(x);
            
            ///////////////////////////////////////////////////////////////////////////////////
            //int x = 0;
            ////Locker - 4 способ;
            //object a = new object();
            //Task[] tasks = new Task[2];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    tasks[i] = Task.Run(() =>
            //    {
            //        for (int i = 0; i < 100000000; i++)
            //        {
            //            lock (a)
            //            {
            //            x++;
            //            }
            //        }
            //    });
            //}
            //Task.WaitAll(tasks);  
            //Console.WriteLine(x);
            
            //////////////////////////////////////////////////////////////////////////
            //int x = 0;
            ////Monitor - 3 способ;
            //object locker = new object();
            //Task[] tasks = new Task[2];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    tasks[i] = Task.Run(() =>
            //    {
            //        for (int i = 0; i < 100000000; i++)
            //        {
            //            Monitor.Enter(locker);
            //            x++;
            //            Monitor.Exit(locker);
            //        }
            //    });
            //}
            //Task.WaitAll(tasks);  
            //Console.WriteLine(x);
            
            ////////////////////////////////////////////////////////////////////////////
           // int x = 0;
           // //Interlog - 2 способ;
           // var task1 = Task.Run(() =>
           // {
           //     for (int i = 0; i < 100000000; i++)
           //     {
           //         Interlocked.Increment(ref x);
           //     }
           // });
           // //Task.WaitAll(task1);
           //var task2 = Task.Run(() =>
           // {
           //     for (int i = 0; i < 100000000; i++)
           //     {
           //         Interlocked.Increment(ref x);
           //     }
           // });
           ////Task.WaitAll(task2);
           // Task.WaitAll(task1, task2);
           // //Thread.Sleep(20000);
           // Console.WriteLine(x);

            //////////////////////////////////////////////////////////////////////////////////
           // int x = 0;
           // //Task.WaitAll(task1) - 1 способ;
           // var task1 = Task.Run(() =>
           // {
           //     for (int i = 0; i < 100000000; i++)
           //     {
           //         x++;
           //     }
           // });
           // //Task.WaitAll(task1);
           //var task2 = Task.Run(() =>
           // {
           //     for (int i = 0; i < 100000000; i++)
           //     {
           //         x++;
           //     }
           // });
           ////Task.WaitAll(task2);
           // //Task.WaitAll(task1, task2);
           // //Thread.Sleep(20000);
           // Console.WriteLine(x);

            ///////////////////////////////////////////////////////////////
            //int x = 0;
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 100000000; i++)
            //    {
            //        //Thread.Sleep(500);
            //        x++;
            //    }
            //});
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 100000000; i++)
            //    {
            //        //Thread.Sleep(500);
            //        x++;
            //    }
            //});
            ////Console.ReadKey();
            ////Thread.Sleep(20000);


            //Console.WriteLine(x);
        }
    }
}
