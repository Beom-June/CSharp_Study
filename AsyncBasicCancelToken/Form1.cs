//using System.Diagnostics;
//using System.Threading.Tasks;

//namespace AsyncBasicCancelToken
//{
//    public partial class Form1 : Form
//    {
//        // �񵿱� ��� : CancellationTokenSource
//        // �񵿱� ��� ���� ���� : CancellationToken
//        CancellationTokenSource _tokenSource;
//        public Form1()
//        {
//            InitializeComponent();
//        }
//        private async Task DoWorkAsync(CancellationToken token)
//        {
//            //  ĵ������  Ȯ���ϴ� ���
//            //while (!token.IsCancellationRequested)
//            //{
//            //    await Task.Delay(100);
//            //    int.TryParse(lblIdx.Text, out int value);
//            //    lblIdx.Text = (++value).ToString();
//            //}

//            //  ���� �߻��ϴ� ���
//            while (true)
//            {
//                //throw new Exception();
//                token.ThrowIfCancellationRequested();       //  ��� ��û�� ������ ���� �߻�
//                await Task.Delay(100);
//                int.TryParse(lblIdx.Text, out int value);
//                lblIdx.Text = (++value).ToString();
//            }
//        }

//        private async void btnStart_Click(object sender, EventArgs e)
//        {
//            _tokenSource = new CancellationTokenSource();
//            var _token = _tokenSource.Token;
//            try
//            {
//                await DoWorkAsync(_token);
//            }
//            catch (OperationCanceledException ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }
//        }

//        private void btnCancle_Click(object sender, EventArgs e)
//        {
//            _tokenSource.Cancel();
//        }
//    }
//}
