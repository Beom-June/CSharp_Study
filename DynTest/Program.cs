//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace DynTest
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            dynamic _a = false;     //  Dynamic Type -> Type Checking, 런타임시에 타입이 결정됨
//            Console.WriteLine(_a.GetType());

//            _a = 123;
//            Console.WriteLine(_a.GetType());

//            // Object vs Dynamic
//            object _i = 10;
//            _i = (int)_i + 20;  //  object는 캐스팅이 필요함

//            _i = "Hello";
//            string _s = ((string)_i).ToUpper();

//            dynamic _d = 10;
//            _d = _d + 20;   //  dynamic은 캐스팅이 필요없음
//            _d = "Hello";
//            string _ss = _d.ToUpper();
//        }

//        void ExpandoTest()
//        {
//            dynamic _perseon = new ExpandoObject();
//            _perseon.Name = "C#";
//            _perseon.Age = 20;

//            _perseon.DisplayData = (Action)(() =>
//            {
//                Console.WriteLine($"{_perseon.Name} : {_perseon.Age}");
//            });

//            _perseon.AgeChanged = null;

//            _perseon.CangedAge = (Action<int>)((age) =>
//            {
//                _perseon.Age = age;
//                if (_perseon.AgeChanged != null)
//                    _perseon.AgeChanged(this, EventArgs.Empty);
//            });

//            new Class2().Run(_perseon);
//        }
//    }
//    class Class1
//    {
//        public void Test()
//        {
//            dynamic _t = new { Name = "C#", Age = 20 };
//            new Class2().Run(_t);
//        }
//    }
//    class Class2
//    {
//        public void Run(dynamic o)
//        {
//            // Dynamic 타입의 속성 직접 사용
//            Console.WriteLine(o.Name);
//            Console.WriteLine(o.Age);
//        }
//    }
//}