//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StaticTest
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            StaticRun();

//            // static안에서 , 인스턴스 메소드를 호출하기 위해서는 객체를 생성해야 한다.
//            var _p = new Program();
//            _p.InstanceRun();

//            //  한 번만 실행시 이러한 방법도 가능
//            //new Program().InstanceRun();

//            int[] _nums = {1,2, 3, 4, 5 };
//            int _sum =  MyCalc.Sum(_nums);
//            double _avg = MyCalc.Avg(_nums);

//            int _cnt = MyCalc.NextCount;
//            Console.WriteLine(_cnt);
//            _cnt = MyCalc.NextCount;
//            Console.WriteLine(_cnt);

//        }
//        static void StaticRun() { }
//        void InstanceRun() { }          //  Instance Method -> Non-Static Method

//    }
//}
