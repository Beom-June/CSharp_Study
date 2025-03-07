//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////  문자열 찾기

//string _str = "hi, Good Morning, Good Bye";

//Console.WriteLine(" **** IndexOf **** ");
//int _i = _str.IndexOf("Good");
//Console.WriteLine($"str.IndexOf(\"Good\") : {_i}");

//_i = _str.IndexOf("good");
//Console.WriteLine($"str.IndexOf(\"good\") : {_i}");     //  대소문자 구분함

//_i = _str.IndexOf("good", StringComparison.OrdinalIgnoreCase);
//Console.WriteLine($"str.IndexOf(\"good\", StringComparison.OrdinalIgnoreCase) : {_i}");     //  StringComparison.OrdinalIgnoreCase : 구분 X

//Console.WriteLine("*****************************************************");

//Console.WriteLine(" **** LastIndexOf **** ");
//int _ii = _str.LastIndexOf("Good");
//Console.WriteLine($"str.IndexOf(\"Good\") : {_ii}");

//_ii = _str.LastIndexOf("good");
//Console.WriteLine($"str.LastIndexOf(\"good\") : {_ii}");     //  대소문자 구분함

//_ii = _str.LastIndexOf("good", StringComparison.OrdinalIgnoreCase);
//Console.WriteLine($"str.LastIndexOf(\"good\", StringComparison.OrdinalIgnoreCase) : {_ii}");     //  StringComparison.OrdinalIgnoreCase : 구분 X

//Console.WriteLine("*****************************************************");

////  문자열이 지정된 문자열로 시작하는지 체크 (반환값 : bool)
//Console.WriteLine(" **** StartsWith **** ");
//bool _b = _str.StartsWith("hi");
//Console.WriteLine($" StartWith(\"hi\") : {_b}");
//Console.WriteLine($" StartWith(\"Hi\") : {_b}");
//Console.WriteLine("*****************************************************");

////  문자열이 지정된 문자열로 끝나는지 체크 (반환값 : bool)
//Console.WriteLine(" **** EndsWidth **** ");
//bool _result1 = _str.EndsWith("Good Bye");
//bool _result2 = _str.EndsWith("good Bye");
//Console.WriteLine($" EndsWidth(\"Good Bye\") : {_result1}");
//Console.WriteLine($" EndsWidth(\"good Bye\") : {_result2}");
//Console.WriteLine("*****************************************************");

////  문자열이 지정된 문자열을 포함하는지 체크 (반환값 : bool)
//Console.WriteLine(" **** Contains **** ");
//bool _result3 = _str.Contains("Morning");
//bool _result4 = _str.Contains("morning");
//Console.WriteLine($" EndsWidth(\"Morning Bye\") : {_result3}");
//Console.WriteLine($" EndsWidth(\"morning Bye\") : {_result4}");
//Console.WriteLine("*****************************************************");

////  지정된 문자열을 찾아 다른 문자열로 변경
//Console.WriteLine(" **** Replace **** ");
//string _result5 = _str.Replace("Morning", "Evening");
//Console.WriteLine($"str.Replace(\"Morning\", \"Evening\") : {_result5}");
//Console.WriteLine("*****************************************************");
