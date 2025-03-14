//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegTest
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().TestCode();
//        }
//        void TestCode()
//        {
//            //...
//            var _addOp = new CalcDelegate(Add);
//            Calc(6, 3, _addOp);
//            Calc(6, 3, Subtract);       //  바로 함수 호출도 가능
//            Calc(6, 3, Power);       //  바로 함수 호출도 가능


//        }

//        delegate int CalcDelegate(int a, int b);

//        //void Calc(int a, int b, string flag)
//        void Calc(int a, int b, CalcDelegate calc)
//        {
//            //int _result = calc.Invoke(a,b);
//            int _result = calc(a, b);
//            /*
//            switch (flag)
//            {
//                case "Add":
//                    _result = Add(a, b);
//                    break;
//                case "Subtract":
//                    _result = Subtract(a, b);
//                    break;
//                case "Multiply":
//                    _result = Multiply(a, b);
//                    break;
//                case "Divide":
//                    _result = Divide(a, b);
//                    break;
//                case "Mod":
//                    _result = Mod(a, b);
//                    break;
//                case "Power":
//                    _result = Power(a, b);
//                    break;
//                default:
//                    break;
//            }
//            */

//            Console.WriteLine($"사용된함수{calc.Method}");
//            Console.WriteLine($"f({a} , {b}  = {_result}");
//        }
//        #region delegate 타입에 맞는 메서드들
//        int Add(int a, int b)
//        {
//            return a + b;
//        }
//        int Subtract(int a, int b)
//        {
//            return a - b;
//        }
//        int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//        int Divide(int a, int b)
//        {
//            return a / b;
//        }
//        int Mod(int a, int b)
//        {
//            return a % b;
//        }
//        int Power(int a, int b)
//        {
//            return (int)Math.Pow(a, b);
//        }
//        #endregion
//    }
//}
