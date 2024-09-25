using System;
using System.Windows.Forms;

namespace BatteryNotifier
{
    public partial class Form1 : Form
    {
        private int plugInThreshold;
        private int removeChargerThreshold;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the timer interval to check every minute
            timer1.Interval = 60000; // 1 minute
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            plugInThreshold = (int)numericUpDownPlugIn.Value;
            removeChargerThreshold = (int)numericUpDownRemoveCharger.Value;

            // Start the timer for checking the battery status
            timer1.Start();

            // Minimize to tray when monitoring starts
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Get current battery status
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            int batteryPercentage = (int)(powerStatus.BatteryLifePercent * 100);

            if (powerStatus.PowerLineStatus == PowerLineStatus.Offline && batteryPercentage <= plugInThreshold)
            {
                // Battery is below plug-in threshold and laptop is unplugged
                ShowNotification("Plug in the charger", $"Battery is at {batteryPercentage}%");
            }
            else if (powerStatus.PowerLineStatus == PowerLineStatus.Online && batteryPercentage >= removeChargerThreshold)
            {
                // Battery is above remove charger threshold and laptop is charging
                ShowNotification("Remove the charger", $"Battery is at {batteryPercentage}%");
            }
        }

        private void ShowNotification(string title, string message)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(3000);  // Show for 3 seconds
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Battery Notifier", "Running in the background.", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // Restore the form when the tray icon is double-clicked
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application when "Exit" is clicked from the context menu
            timer1.Stop();
            notifyIcon1.Visible = false;
            Application.Exit();
        }
    }
}
