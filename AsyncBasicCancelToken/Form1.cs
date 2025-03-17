//using System.Diagnostics;
//using System.Threading.Tasks;

//namespace AsyncBasicCancelToken
//{
//    public partial class Form1 : Form
//    {
//        // 비동기 취소 : CancellationTokenSource
//        // 비동기 취소 여부 추적 : CancellationToken
//        CancellationTokenSource _tokenSource;
//        public Form1()
//        {
//            InitializeComponent();
//        }
//        private async Task DoWorkAsync(CancellationToken token)
//        {
//            //  캔슬여부  확인하는 방법
//            //while (!token.IsCancellationRequested)
//            //{
//            //    await Task.Delay(100);
//            //    int.TryParse(lblIdx.Text, out int value);
//            //    lblIdx.Text = (++value).ToString();
//            //}

//            //  에러 발생하는 방법
//            while (true)
//            {
//                //throw new Exception();
//                token.ThrowIfCancellationRequested();       //  취소 요청이 있으면 예외 발생
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
