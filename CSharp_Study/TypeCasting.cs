using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//  암시적 변환 (컴파일러가 자동으로 형변환)
int _i = 10;
double _d = _i;

Button _button = new Button();
Control _control = _button;

Console.WriteLine(_button.GetString());
Console.WriteLine(_control.GetString());

//  명시적 변환 (프로그래머가 직접 강제로 변환)

class Control
{
    public virtual string GetString() => "Control";
}
class Button : Control
{
    public override string GetString()
    {
        return base.GetString() + " in Button"; ;
    }
}

namespace CSharp_Study
{


    class TypeCasting
    {
    }
}
