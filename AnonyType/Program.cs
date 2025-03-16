//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnonyType
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            // 익명 타입. 추론할 수 있도록 var사용
//            // 생성자를 사용하지 않고 객체를 생성. 초기화 하는 방식 : Object Initializer
//            var _t = new
//            {
//                Name = "홍길동",
//                Age = 20,
//                Phone = "010-333-4444"
//            };

//            int _age = _t.Age;
//            //_t.Age = 25; // 익명 타입은 읽기 전용이므로 컴파일 오류 발생

//            Type _type = _t.GetType();

//            //  LINQ
//            var _v = new[]{
//                new {Name = "Lee", Age = 20, Phone = "010-2424-5656"},
//                new {Name = "Kim", Age = 25, Phone = "010-2222-4444"},
//                new {Name = "Park", Age = 30, Phone = "010-543-7695"}
//            };

//            // LINQ SELCT를 이용해 30세 이상인 사람들 조회
//            var _list = _v.Where(a => a.Age >= 30).Select(p => new { 이름 = p.Name, 나이 = p.Age });
//            foreach (var a in _list)
//            {
//                Debug.WriteLine(a.이름 + a.나이);
//            }
//        }
//    }
//}
