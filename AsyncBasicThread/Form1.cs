using AsyncBasicThread.Utils;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncBasicThread
{
    public partial class Form1 : Form
    {
        private const string _sourceFile = @"C:\Temp\source.txt";
        private const string _destFile = @"C:\Temp\dest.txt";

        //  ������Ƽ
        private int _currentThreadID => Thread.CurrentThread.ManagedThreadId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Fileprogress(string currentUnits, string totalUnits, int percentage)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new FileProgressDelegate(Fileprogress), currentUnits, totalUnits, percentage);
            }
            else
            {
                lblMain.Text = $"{currentUnits} / {totalUnits} ({percentage}%)";
                progressMain.Value = percentage;
            }
        }

        #region Main
        private async Task CopyFileAsync()
        {
            Debug.Print($"CopyFileAsync() ȣ�� ������ ID: {_currentThreadID}");
            FileUtils.Copy(_sourceFile, _destFile, fileProgresss: Fileprogress);
        }
        private async void btnCopyMain_Click(object sender, EventArgs e)
        {
            Debug.Print($"���� : {_currentThreadID}");
            await CopyFileAsync();
        }
        private void progresssMain_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Background
        private async Task CopyFileAsnyc()
        {
            await Task.Run(() =>
            {
                Debug.Print($"CopyFileAsync() ȣ�� ������ ID: {_currentThreadID}");
                FileUtils.Copy(_sourceFile, _destFile, fileProgresss: Fileprogress);
            });
        }
        private async void btnCopyBack_Click(object sender, EventArgs e)
        {
            Debug.Print($"���� : {_currentThreadID}");
            await CopyFileAsnyc();
        }
        #endregion

    }
}
