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
//            // ����
//            //int _sum = LongCalc(10);
//            //label1.Text = _sum.ToString();

//            // �񵿱�
//            var _task1 = Task.Run(() => LongCalc(10));
//            int _sum =  await _task1;                                   //  await Ű���带 ����Ϸ��� async Ű���尡 �־�� �Ѵ�.
//            label1.Text = _sum.ToString();
//        }
//        private int LongCalc(int n)
//        {
//            int _result = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                _result += i;
//                // ... �� �۾� ....
//                Thread.Sleep(100);
//            }
//            return _result;
//        }
//    }
//}
