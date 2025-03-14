//using System.Diagnostics;

//namespace LambdaTest
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        delegate int FN(int a);

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            // 무명 메서드를 람다식으로
//            //button1.Click += delegate
//            //{
//            //    MessageBox.Show("Done");
//            //};

//            ////  파라미터 타입 생략 가능
//            //button1.Click += (s, ea) =>
//            //{
//            //    MessageBox.Show("Done");
//            //};

//            //  람다식을 델리게이트에 할당
//            //FN _sqr = (x) => { return x * x; };
//            FN _sqr = (x) => x * x;
//            int _res = _sqr(4);
//            Func<int, int> _Sq = (x) => x * x;

//            // 16개 까지 가능
//            Func<double, double, decimal> f;

//            //  람다식을 메서드의 파라미터로 전달
//            GetData(p => p == "A");
//            GetData(p => p.Contains("A"));
//            GetData(p => p.Substring(0, 1) == "A");

//            //  LINQ
//            var _list = _data.Where(n => n.StartsWith("A"));
//        }

//        private List<string> _data = new List<string> { "Alexa", "Plane", "Jane", "Adele" };

//        private void GetData(Func<string, bool> filter)
//        {
//            foreach (var item in _data)
//            {
//                if (filter(item))
//                {
//                    Debug.WriteLine(item);
//                }
//            }
//        }
//    }
//}
