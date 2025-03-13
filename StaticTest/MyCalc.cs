//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace StaticTest
//{
//    // 인스턴스 멤버 X, 처음 사용 될 때 초기화 됨
//    static class MyCalc
//    {
//        //  Static Method
//        public static int Sum(int[] number)
//        {
//            int _sum = 0;
//            foreach (var i in number)
//            {
//                _sum += i;
//            }
//            return _sum;
//        }

//        public static double Avg(int[] number)
//        {
//            double _avg = Sum(number) / (double)number.Count();
//            return _avg;
//        }

//        //  Static field
//        private static int counter;

//        //  Static Constructor, 생성자는 인스턴스 생성시 호출되는 메소드이다.
//        static MyCalc()
//        {
//            counter = 0;
//        }

//        //private static object objectLock = new object();
//        public static int NextCount
//        {
//            get
//            {
//                //lock (objectLock)
//                //{
//                //    counter++;
//                //    return counter;
//                //}
//                return Interlocked.Increment(ref counter);
//            }
//        }
//    }
//}