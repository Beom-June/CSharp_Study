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
//            // ���� �޼��带 ���ٽ�����
//            //button1.Click += delegate
//            //{
//            //    MessageBox.Show("Done");
//            //};

//            ////  �Ķ���� Ÿ�� ���� ����
//            //button1.Click += (s, ea) =>
//            //{
//            //    MessageBox.Show("Done");
//            //};

//            //  ���ٽ��� ��������Ʈ�� �Ҵ�
//            //FN _sqr = (x) => { return x * x; };
//            FN _sqr = (x) => x * x;
//            int _res = _sqr(4);
//            Func<int, int> _Sq = (x) => x * x;

//            // 16�� ���� ����
//            Func<double, double, decimal> f;

//            //  ���ٽ��� �޼����� �Ķ���ͷ� ����
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
