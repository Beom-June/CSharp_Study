//namespace AnoMeth
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        delegate void RunDelegate(int p);
//        delegate int Expr(int a, int b);        //  리턴값이 있는 델리게이트
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            //  무명메서드 : 이름이 없는 메서드
//            //  delegate *** (int p {/*...*/});
//            RunDelegate _rd = delegate (int p) { MessageBox.Show(p.ToString()); };
//            _rd(10);

//            Expr _expr = delegate (int a, int b) { return a + b; };
//            int _result = _expr(10, 20);

//            //button1.Click += Button1_Click;
//            button1.Click += delegate /*(object s, EventArgs e)*/
//            {
//                MessageBox.Show("Hello, World!");
//            };
//        }
//        //private void Button1_Click(object sender, EventArgs e)
//        //{
//        //    MessageBox.Show("Hello, World!");
//        //}
//    }
//}
