//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////  데이터 타입
////  .NET 프로그래밍언어
////  .NET 공용 타입 형식을 사용

////  int == System.Int32
////  string == System.String
////  bool == System.Boolean

///* 정수형
// * byte : 8비트 (unsigned)
// * sbyte : 8비트 (signed)
// * short : 16비트 (signed)
// * ushort : 16비트 (unsigned)
// * int : 32비트 (signed)
// * uint : 32비트 (unsigned)
// * long : 64비트 (signed)
// * ulong : 64비트 (unsigned)
// * 
// * 실수형
// * float : 32비트 (부동 소수점)
// * double : 64비트 (부동 소수점)
// * decimal : 128비트 (부동 소수점)
// */

///* 논리형  
// * bool : 1비트 (true, false)
// */

///* 문자열  
// * char : 16비트 유니코드 문자 (c, c++ 8비트)
// * string : 유니코드 문자열
// */

///* 최상위 기본 클래스 (Top-Level Base Class)
// * object : 모든 데이터 형식의 최상위 클래스
// */

//// 변수 선언
////  명시적
////int _number = 123;  //  초기화
////string _name = "홍길동";
////char _c = 'A';
////float _score = 3.14f;

////  암시적 : var, 컴파일러가 자동으로 형식을 결정, 초기화 시 형식이 결정되므로 초기화 필수
////var _number = 123;  //  초기화
////var _name = "홍길동";
////var _c = 'A';
////var _score = 3.14f;

////  리터럴 (Literal)
////  프로그램에서 사용하는 고정된 값
////  컴파일 시간에 값을 결정
////  실행 시간에 변경되지 않음

////  컴파일 (Compile)
////  소스 코드를 기계어로 변환
////  고수준 언어를 저수준 언어로 변환

//int _x = 10;            //  10은 정수형 숫자 리터럴
//int _y = 10;            //  10은 정수형 숫자 리터럴
//double _d = 3.14;       //  3.14는 실수형 숫자 리터럴
//char _c = 'A';          //  'A'는 문자 리터럴

////  리터럴이 아닌 경우
//int _z = _x * _y;       //  _x * _y는 연산식, 리터럴이 아님, _z는 연산식의 결과값

//Console.WriteLine("아무 말이나 입력하세요");
//string? _str = Console.ReadLine();
//Console.WriteLine(_str);

////  숫자형 접미사 (Suffix)

//var _longValue = 10L;       //  long, 마지막에 적어줌
//var _ulongValue = 10UL;     //  ulong
//var _floatValue = 3.14f;    //  float
//var _doubleValue = 3.14d;     //  double
//var _decimalValue = 3.14m;  //  decimal
