using Directus.Companion.Models;
using Directus.Companion.Properties;
using Directus.Companion.Workers;
using Microsoft.Win32;
using System.ComponentModel;

namespace Directus.Companion
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
                    Region = Settings.Default.Region,
                    Folder = Settings.Default.Folder,
                    Url = Settings.Default.Url,
                    Token = Settings.Default.Token,
                    AutoStart = Settings.Default.AutoStart
                }
            };

            if (property.ShowDialog() == DialogResult.OK)
            {
                var configuration = property.Data as Configuration;

                if (configuration != null)
                {
                    Settings.Default.Username = configuration.Username;
                    Settings.Default.Password = configuration.Password;
                    Settings.Default.Region = configuration.Region;
                    Settings.Default.Folder = configuration.Folder;
                    Settings.Default.Url = configuration.Url;
                    Settings.Default.Token = configuration.Token;
                    Settings.Default.AutoStart = configuration.AutoStart;

                    Settings.Default.Save();
                }
            }

            if (Settings.Default.AutoStart)
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true)?.SetValue("Directus Companion", $"\"{Application.ExecutablePath}\"");
            }
            else
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true)?.DeleteValue("Directus Companion", false);
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

            Status.ForeColor = Status.Text.Contains("Error") ? Color.Red : Color.Black;

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