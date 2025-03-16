using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMth
{
    public static class MyExtension
    {
        public static bool IsEven(this int a)
        {
            return a % 2 == 0;
        }

        //  Class 확장 메서드
        public static string DashAppend(this string s, string text)
        {
            return s + "-" + text;
        }

        //
        public static int Moudulo(this Calc calc, int a, int b)
        {
            return a % b;
        }
    }
}