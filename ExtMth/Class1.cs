using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMth
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int _a = 124;
            //bool _b = MyUtility.IsEven(_a);

            bool _b = _a.IsEven();      //  Extension method
            _b = 100.IsEven();          //  100 객체를 첫 번째 인자로 전달

            string _s = "ABC";
            string _s2 = _s.DashAppend("DEF");

            Calc _calc = new Calc();
            int _result = _calc.Moudulo(10, 3);

            // interface 확장 메서드
            var _list = new List<string> { "Alex", "Pane", "Jane", "Alexa" };
            var _aNames = _list.Where(w => w.StartsWith("A"));
        }
    }
}
