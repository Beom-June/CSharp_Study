using System.Diagnostics;
using System.Threading.Tasks;

namespace AyncBasicTask
{
    public partial class Form1 : Form
    {
        Stopwatch _sw = new();
        private double _arriveTime => Math.Round(_sw.ElapsedMilliseconds / 1000d, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Start()
        {
            _sw.Start();
        }
        private void End()

        {
            //AddLogs($"End: {_arriveTime}");
            _sw.Stop();
            _sw.Reset();
        }

        // �α� ����Ʈ �߰�
        private void AddLogs(params string[] _texts) => lbLogs.Items.AddRange(_texts);

        // �α� ����Ʈ Ŭ����
        private void ClearLogs() => lbLogs.Items.Clear();

        // ������ ��ġ �ʱ�ȭ
        private void ResetBugs()
        {
            var _bugs = new List<Label> { bugA, bugB, bugC, bugD };
            _bugs.ForEach(x => x.Left = 125);
        }

        // ������ �̵�
        private async Task<string> MoveLabel(Label lbl, int speed)
        {
            int _endX = finishLine.Left - lbl.Width;
            while (lbl.Left < _endX)
            {
                lbl.Location = new Point(lbl.Left + speed * 4, lbl.Top);
                await Task.Delay(1);
            }
            lbl.Location = new Point(_endX, lbl.Top);

            return $"{lbl.Text} �����ð� : {_arriveTime}��";
            ;
        }

        // �ϳ��� ���
        private async void btnStart1_Click(object sender, EventArgs e)
        {
            Start();

            string _logA = await MoveLabel(bugA, 1);
            string _logB = await MoveLabel(bugB, 2);
            string _logC = await MoveLabel(bugC, 3);
            string _logD = await MoveLabel(bugD, 4);

            AddLogs(_logA, _logB, _logC, _logD);
            End();
        }

        // A�� B ���� ���
        private async void btnStart2_Click(object sender, EventArgs e)
        {
            Start();

            ResetBugs();
            Task<string> _aTask = MoveLabel(bugA, 1);
            Task<string> _bTask = MoveLabel(bugB, 2);

            //string _logA = await _aTask;
            //string _logB = await _bTask;

            string[] _result = await Task.WhenAll(_aTask, _bTask);
            AddLogs(_result);

            Task<string> _cTask = MoveLabel(bugC, 3);
            Task<string> _dTask = MoveLabel(bugD, 4);

            //await _cTask;
            //await _dTask;
            string[] _results = await Task.WhenAll(_cTask, _dTask);
            AddLogs(_results);

            End();
        }

        // ���� ���
        private async void btnStartAll_Click(object sender, EventArgs e)
        {
            Start();

            Task<string> _aTask = MoveLabel(bugA, 1);
            Task<string> _bTask = MoveLabel(bugB, 2);
            Task<string> _cTask = MoveLabel(bugC, 3);
            Task<string> _dTask = MoveLabel(bugD, 4);

            await _aTask;
            await _bTask;
            await _cTask;
            await _dTask;

            End();
        }

        // ���� ��� (WhenAny)
        private async void btnStart4_Click(object sender, EventArgs e)
        {
            Start();

            Task<string> _aTask = MoveLabel(bugA, 1);
            Task<string> _bTask = MoveLabel(bugB, 2);
            Task<string> _cTask = MoveLabel(bugC, 3);
            Task<string> _dTask = MoveLabel(bugD, 4);

            var _tasks = new List<Task>() { _aTask, _bTask, _cTask, _dTask };

            while (_tasks.Count > 0)
            {
                Task _task = await Task.WhenAny(_tasks);
                //if(_task == _cTask)
                //{
                //    string _logC = await _cTask;
                //    AddLogs(_logC);
                //}
                
                //  ����ȯ
                string _log =  await(Task<string>)_task;
                AddLogs(_log);

                _tasks.Remove(_task);
            }
            End();
        }

        private void bugA_Click(object sender, EventArgs e)
        {

        }

        private void bugC_Click(object sender, EventArgs e)
        {


        }
    }
}
