//using System.Threading.Tasks;

//namespace AwaitTest
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Run();
//        }
//        private async Task Run()
//        {
//            // 동기
//            //int _sum = LongCalc(10);
//            //label1.Text = _sum.ToString();

//            // 비동기
//            var _task1 = Task.Run(() => LongCalc(10));
//            int _sum =  await _task1;                                   //  await 키워드를 사용하려면 async 키워드가 있어야 한다.
//            label1.Text = _sum.ToString();
//        }
//        private int LongCalc(int n)
//        {
//            int _result = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                _result += i;
//                // ... 긴 작업 ....
//                Thread.Sleep(100);
//            }
//            return _result;
//        }
//    }
//}
