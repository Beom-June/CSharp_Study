//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

////  암시적 변환 (컴파일러가 자동으로 형변환)
//int _i = 10;
//double _d = _i;

//Button _button = new Button();
//Control _control = _button;

//Console.WriteLine(_button.GetString());
//Console.WriteLine(_control.GetString());

////  명시적 변환 (프로그래머가 직접 강제로 변환)
//double _dd = 10.5;
//int _ii = (int)_dd;

///*  Boxing은 값 형식을 참조 형식으로 변환하기 때문에 추가적인 메모리 할당 및 복사 작업이 필요
// *  성능에 부담을 줄 수 있는 작업 */
////  Boxing : 값 형식을 참조 형식으로 변환
//object _obj = 123;

////  UnBoxing : 참조 형식을 값 형식으로 변환
//int _iii = (int)_obj;

////  Convert 클래스를 사용한 변환
////string _s = "10.5";
////double _ddd = Convert.ToDouble(_s);
////double _d2 = double.Parse(_s);

////  TryParse
//string _s = "10.5";
//double.TryParse(_s, out double _ddd);
//if (int.TryParse(_s, out int i))
//{
//    Console.WriteLine(i);
//}
//else
//{
//    Console.WriteLine("i is null");
//}

////  Boxing, UnBoxing 때 사용
//void BoxingUnboxing(object obj)
//{
//    Console.WriteLine(" ***** BoxingUnboxing ***** ");
//    //Control _control = (Control)obj;

//    //  Type이 명확하지 않을 때 오류가 생길 수 있음. as operater 사용
//    //Button _button = (Button)obj;
//    Button _button = obj as Button;     //  맞으면 넘겨줌, 아니면 null 넘김
//    if (_button != null)
//    {
//        Console.WriteLine(_button.GetString());
//    }
//    else
//    {
//        Console.WriteLine("button is null");
//    }

//    //Console.WriteLine(_control.GetString());
//}
////BoxingUnboxing(new Control());
//BoxingUnboxing(new Button());

////  암시적, 명시적 변환 때 사용
//class Control
//{
//    public virtual string GetString() => "Control";
//}
//class Button : Control
//{
//    public override string GetString()
//    {
//        return base.GetString() + " in Button"; ;
//    }
//}

//namespace CSharp_Study
//{
//    class TypeCasting
//    {
//    }
//}
