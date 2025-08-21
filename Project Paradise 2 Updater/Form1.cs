using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Paradise_2_Updater
{
    public partial class Form1 : Form
    {
        public string WorkingDir;

        public Form1()
        {
            //"https://cdn.project-paradise2.de/Requests/Launcherversion.php"

            InitializeComponent();
            Database.Read();
            WorkingDir = Database.p2Database.Usersettings.Gamedirectory;


            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileComplete);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
            Uri uri = new Uri("https://cdn.project-paradise2.de/Requests/Launcherversion.php");
            startTime = DateTime.Now;
            var info = client.DownloadString(uri);


            PrepareUpdate();
        }

        private void PrepareUpdate()
        {
            try
            {
                if (File.Exists(WorkingDir + "\\Uplauncher.exe"))
                {
                    File.Delete(WorkingDir + "\\Uplauncher.exe");
                }
                Task.Run(() => StartDownload());
            }
            catch (Exception)
            {
            }
        }

        private DateTime startTime;

        private void StartDownload()
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileComplete);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                Uri uri = new Uri("https://cdn.project-paradise2.de/launcherfiles/new/Unpacket/Uplauncher.exe");
                startTime = DateTime.Now;
                client.DownloadFileAsync(uri, WorkingDir + "/Uplauncher.exe");
            }
            catch (Exception)
            {
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            if (CurrentProgress.InvokeRequired || CurrentState.InvokeRequired)
            {
                CurrentProgress.Invoke(new Action(() => UpdateProgress(e)));
                CurrentState.Invoke(new Action(() => UpdateUIState(e)));
            }
            else
            {
                UpdateProgress(e);
                UpdateUIState(e);
            }
        }

        private void UpdateProgress(DownloadProgressChangedEventArgs e)
        {
            CurrentProgress.Value = e.ProgressPercentage;
        }

        private void UpdateUIState(DownloadProgressChangedEventArgs e)
        {
            double elapsedSeconds = (DateTime.Now - startTime).TotalSeconds;
            double bytesPerSecond = e.BytesReceived / elapsedSeconds;
            string downloadSpeed = $"{(bytesPerSecond / (1024 * 1024)):F2} MB/s";
            double bytesRemaining = e.TotalBytesToReceive - e.BytesReceived;
            double secondsRemaining = bytesRemaining / bytesPerSecond;
            TimeSpan timeSpan = TimeSpan.FromSeconds(secondsRemaining);
            string timeRemaining = timeSpan.ToString(@"hh\:mm\:ss");
            CurrentState.Text = $"Downloading... {e.ProgressPercentage}% completed\nSpeed: {downloadSpeed}\nTime remaining: {timeRemaining}";
        }

        private void DownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message, "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Download completed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RunLauncher();
                Environment.Exit(0);
            }
        }

        public void RunLauncher()
        {
            try
            {
                string appPath = Database.p2Database.Usersettings.Gamedirectory + "\\Uplauncher.exe";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = appPath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process.Start(processInfo);
            }
            catch (Exception)
            {
            }
        }
    }
}
