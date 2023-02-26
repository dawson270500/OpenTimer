using System.ComponentModel;

namespace OpenTimer
{
    public partial class MainWindow : Form
    {
        int SecondsToWait = 0;
        System.ComponentModel.BackgroundWorker backgroundWorker_Timer;
        public MainWindow()
        {
            backgroundWorker_Timer = new System.ComponentModel.BackgroundWorker();
            backgroundWorker_Timer.WorkerSupportsCancellation = true;
            backgroundWorker_Timer.DoWork += BackgroundWorker_Timer_DoWork;
            backgroundWorker_Timer.WorkerReportsProgress= true;
            InitializeComponent();
        }

        bool ClearTimer = false;
        private void BackgroundWorker_Timer_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ClearTimer = false;
            while (SecondsToWait > 0)
            {
                for(int i =100; i > 0; i--)
                {
                    if (backgroundWorker_Timer.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    Thread.Sleep(10);
                }
                SecondsToWait -= 1;
                if(SecondsToWait== 0)
                {
                    ClearTimer = true;
                    this.Invoke(new MethodInvoker(updateTimer));
                    e.Cancel = true;
                    break;
                }
                this.Invoke(new MethodInvoker(updateTimer));
            }
        }

        static int SecondsInMinute = 60;
        static int SecondsInHour = SecondsInMinute * 60;
        private void StartButton_Click(object sender, EventArgs e)
        {
            SecondsToWait = (int)(SecondsInMinute * MinutesUpDown.Value);
            SecondsToWait += (int)(SecondsInHour * HoursUpDown.Value);
            SecondsToWait += (int)SecondsUpDown.Value;
            backgroundWorker_Timer.RunWorkerAsync();
            StartButton.Enabled = false;
            PauseButton.Enabled = true;
        }

        private void updateTimer()
        {
            if(ClearTimer)
            {
                SecondsUpDown.Value = 0;
                MinutesUpDown.Value = 0;
                HoursUpDown.Value = 0;
                StartButton.Enabled = true;
                return;
            }
            int SecsDown = (int)SecondsUpDown.Value;
            int MinsDown = (int)MinutesUpDown.Value;
            int HoursDown = (int)HoursUpDown.Value;
            SecsDown -= 1;
            if (SecsDown <= 0)
            {
                MinsDown -= 1;
                SecsDown = 59;
            }
            if(MinsDown <= 0)
            {
                MinsDown = 59;
                if (HoursDown != 0)
                    HoursDown -= 1;
            }

            SecondsUpDown.Value = SecsDown;
            MinutesUpDown.Value = MinsDown;
            HoursUpDown.Value = HoursDown;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            PauseButton.Enabled = false;
            backgroundWorker_Timer.CancelAsync();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker_Timer.CancelAsync();
            StartButton.Enabled = true;
            SecondsUpDown.Value = 0;
            MinutesUpDown.Value = 0;
            HoursUpDown.Value = 0;
            SecondsToWait = 0;
        }
    }
}