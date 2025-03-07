//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////  배열 형 변환 (Cast, Of Type)
//List<Animal> _animals = new()
//{
//    new Cat{ Name = "Cat1" },
//    new Cat{ Name = "Cat2" },
//    new Cat{ Name = "Cat3" },
//    new Dog{ Name = "Dog1" },
//    new Dog{ Name = "Dog2" },
//    new Dog{ Name = "Dog3" },
//    new Pig{ Name = "Pig1" },
//    new Pig{ Name = "Pig2" },
//    new Pig{ Name = "Pig3" },
//};

////  Cast : 형 변환 실패 시 InvalidCastException 발생
////  Of Type : 형 변환 실패 시 무시하고 다음 요소로 넘어감
////  즉, 해당 타입과 맞지 않는 요소는 건너뛰고 해당 타입과 맞는 요소만 반환
////List<Cat> _cats = _animals.Cast<Cat>().ToList();
//List<Cat> _cats = _animals.OfType<Cat>().ToList();

//foreach (var _cat in _cats)
//{
//    Console.WriteLine(_cat.Name);
//}
//class Animal
//{
//    public string Name { get; set; }
//}

//class Cat : Animal { }
//class Dog : Animal { }
//class Pig : Animal { }
//class Tiger : Animal { }
