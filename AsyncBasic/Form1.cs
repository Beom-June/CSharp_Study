namespace AsyncBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  동기 테스트
        private void RunAnything(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }

        //  비동기 테스트
        private async Task RunAnythingAsync(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }

        private void btnWalking_Click(object sender, EventArgs e)
        {
            //RunAnything(lblWalking);
            _ = RunAnythingAsync(lblWalking);
        }
        private void btnPhone_Click(object sender, EventArgs e)
        {
            //RunAnything(lblPhone);
            _ = RunAnythingAsync(lblPhone);
        }
        private void btnTalking_Click(object sender, EventArgs e)
        {
            //RunAnything(lblTalking);
            _ = RunAnythingAsync(lblTalking);
        }

        // Task 를 반환해여 await 가능
        private async Task RunAllAsync(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100);
                lbAll.Items.Add($"{lbl.Name} - {i}");
            }
        }

        //private void btnAll_Click(object sender, EventArgs e)
        private async void btnAll_Click(object sender, EventArgs e)
        {
            //_ = RunAllAsync(lblWalking);
            //_ = RunAllAsync(lblPhone);
            //_ = RunAllAsync(lblTalking);
            await RunAllAsync(lblWalking);
            await RunAllAsync(lblPhone);
            await RunAllAsync(lblTalking);
        }
    }
}