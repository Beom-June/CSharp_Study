//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GenTest
//{
//    class BaseClass
//    {
//    }

//    //  T : BaseClass 이거나 파생클래스. U : IComparable 인터페이스를 구현한 클래스
//    class MyClass<T, U>
//        where T : BaseClass
//        where U : IComparable
//    {
//    }

//    //class Calculator<T> where T

//    //  Class Type은 들어올수 없음
//    class Calculator<T> where T : struct
//    {
//        public T Add(T a, T b)
//        {
//            dynamic _da = a;
//            dynamic _db = b;

//            T _result = _da + _db;
//            return _result;
//        }
//        public T Subtract(T a, T b)
//        {
//            dynamic _da = a;
//            dynamic _db = b;

//            T _result = _da - _db;
//            return _result;
//        }
//        public T Multiply(T a, T b)
//        {
//            dynamic _da = a;
//            dynamic _db = b;

//            T _result = _da * _db;
//            return _result;
//        }
//        public T Divide(T a, T b)
//        {
//            dynamic _da = a;
//            dynamic _db = b;

//            T _result = _da / _db;
//            return _result;
//        }
//    }
//}