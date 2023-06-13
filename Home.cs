using DirectusCompanion.Properties;
using DirectusCompanion.Workers;
using System.ComponentModel;

namespace DirectusCompanion
{
    public partial class Home : Form
    {
        private Backup Backup { get; set; } = new Backup();

        private Restore Restore { get; set; } = new Restore();

        public Home()
        {
            InitializeComponent();
        }

        private void OnMinimize(object sender, EventArgs e)
        {
            Hide();
        }

        private void OnSettings(object sender, EventArgs e)
        {
            var property = new Property()
            {
                Data = new Configuration
                {
                    Username = Settings.Default.Username,
                    Password = Settings.Default.Password,
                    Folder = Settings.Default.Folder,
                    SourceUrl = Settings.Default.SourceUrl,
                    SourceToken = Settings.Default.SourceToken,
                    TargetUrl = Settings.Default.TargetUrl,
                    TargetToken = Settings.Default.TargetToken
                }
            };

            if (property.ShowDialog() == DialogResult.OK)
            {
                var configuration = property.Data as Configuration;

                if (configuration != null)
                {
                    Settings.Default.Username = configuration.Username;
                    Settings.Default.Password = configuration.Password;
                    Settings.Default.Folder = configuration.Folder;
                    Settings.Default.SourceUrl = configuration.SourceUrl;
                    Settings.Default.SourceToken = configuration.SourceToken;
                    Settings.Default.TargetUrl = configuration.TargetUrl;
                    Settings.Default.TargetToken = configuration.TargetToken;

                    Settings.Default.Save();
                }
            }
        }

        private void OnRestore(object sender, EventArgs e)
        {
            Restore.ProgressChanged += OnProgress;

            Restore.RunWorkerCompleted += OnCompleted;

            btnSettings.Enabled = false;

            btnBackup.Enabled = false;

            btnRestore.Enabled = false;

            Restore.RunWorkerAsync();
        }

        private void OnBackup(object sender, EventArgs e)
        {
            Backup.ProgressChanged += OnProgress;

            Backup.RunWorkerCompleted += OnCompleted;

            btnSettings.Enabled = false;

            btnBackup.Enabled = false;

            btnRestore.Enabled = false;

            Backup.RunWorkerAsync();
        }

        private void OnCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            btnSettings.Enabled = true;

            btnBackup.Enabled = true;

            btnRestore.Enabled = true;

            Application.DoEvents();
        }

        private void OnProgress(object? sender, ProgressChangedEventArgs e)
        {
            Status.Text = e.UserState as string;

            Progress.Minimum = 0;

            Progress.Maximum = 100;

            Progress.Value = e.ProgressPercentage;

            Application.DoEvents();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnShow(object sender, EventArgs e)
        {
            Show();
        }
    }
}