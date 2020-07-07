//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace UnderstandingLINQ
//{
//    class LearningTasks
//    {
//        public static void Main(string[] args)
//        {
//            var t1 = new Task(() => DoWork(1, 2000));
//            var t2 = new Task(() => DoWork(2, 3000));
//            var t3 = new Task(() => DoWork(3, 1500));
//            var watch = System.Diagnostics.Stopwatch.StartNew();
//            Console.WriteLine(watch.Elapsed);
            
//        }
//        static void DoWork(int id, int sleep)
//        {
//            Console.WriteLine("task {0} started", id);
//            Thread.Sleep(sleep);
//            Console.WriteLine("task {0} ending", id);
//        }
//    }
//}
