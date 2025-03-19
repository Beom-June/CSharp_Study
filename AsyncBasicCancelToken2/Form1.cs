namespace AsyncBasicCancelToken2
{
    /* CacellationTokenSOurce 사용하는 이유
     * 
     * 1. 작업 병렬 실행 제어
     * 2. 작업 연기
     * 3. 캡슐화
     * 4. 인터페이스
     */
    public partial class Form1 : Form
    {
        private CancellationTokenSource? _tokenSource;

        // 프로그래스 바 진행률 표시 메서드
        private void SetProgress(ProgressBar progressBar, Label label, int count)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(SetProgress, progressBar, label, count);
            }
            else
            {
                progressBar.Value = count;
                label.Text = $"{count}%";
            }
        }

        //private ZeroToHundredManager _zeroToHundred;
        //private HunderedToZeroManager _hundredToZero;

        // 시작 버튼
        private async void btnStart_Click(object sender, EventArgs e)
        {
            _tokenSource = new CancellationTokenSource();
            CancellationToken _token = _tokenSource.Token;

            //await new ZeroToHundredManager().Run(count => SetProgress(prg1, lbl1, count), _token);
            //await new HunderedToZeroManager().Run(count => SetProgress(prg1, lbl1, count), _token);

            // 병렬 호출
            var _tasks = new List<Task>();

            for (int i = 1; i < 6; i += 2)
            {
                var _prg = Controls[$"prg{i}"] as ProgressBar;
                var _lbl = Controls[$"lbl{i}"] as Label;
                var _prg2 = Controls[$"prg{i + 1}"] as ProgressBar;
                var _lbl2 = Controls[$"lbl{i + 1}"] as Label;

                if (_prg == null || _lbl == null || _prg2 == null || _lbl2 == null)
                {
                    MessageBox.Show($"prg{i}, lbl{i}, prg{i + 1}, lbl{i + 1} 컨트롤을 찾을 수 없습니다.");
                    continue;
                }

                var _task1 = new ZeroToHundredManager().Run(count => SetProgress(_prg, _lbl, count), _token);
                await Task.Delay(200);
                var _task2 = new HunderedToZeroManager().Run(count => SetProgress(_prg2, _lbl2, count), _token);
                await Task.Delay(200);

                _tasks.Add(_task1);
                _tasks.Add(_task2);
            }
            await Task.WhenAll(_tasks);
        }

        // 취소 (Cancel Token)
        private void btnCancle_Click(object sender, EventArgs e)
        {
            _tokenSource?.Cancel();

            // 토큰이 이 부분을 맞추줌
            //_zeroToHundred.Cancel = true;
            //_hundredToZero.CancelAsync = true;

        }
        public Form1()
        {
            InitializeComponent();

            //  많은 개발자들이 토큰을 사용함
            //  즉 인터페이스 처럼 사용 가능
            //var _httpClient = new HttpClient();
            //_httpClient.GetAsync("url", _tokenSource.Token);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prg1_Click(object sender, EventArgs e)
        {
        }
        private void prg2_Click(object sender, EventArgs e)
        {
        }

    }
}
