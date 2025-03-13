//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ModLog;   //  ModLog 네임스페이스를 사용하기 위해 추가

////  접근 제한자 공부

//namespace CSharp_Study
//{
//    //  기준 클래스, Base Class
//    class Animal
//    {
//        private int _id;
//        protected string _name;     //  private -> protected로 변경 : 파생 클래스에서 사용 가능

//        protected void Eat()
//        {
//            //...
//        }
//    }

//    //  파생 클래스, Derived Class
//    class Dog : Animal
//    {
//        public void CheckIdfentity()
//        {
//            //  _id = 0;  //  private 멤버는 자식 클래스에서 접근 불가
//            Console.WriteLine("{0}", _name);

//            //  Eat();  //  protected 멤버는 자식 클래스에서 접근 가능
//        }
//    }
//    class ModProgram
//    {
//        static void Main(string[] args)
//        {
//            Logger _logger = new Logger();
//            _logger.LogSuccess("");

//            string _s = _logger.LogDirectory;
//        }
//    }
//}
