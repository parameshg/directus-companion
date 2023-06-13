using System.ComponentModel;

namespace DirectusCompanion.Workers
{
    internal class Backup : Worker
    {
        public Backup()
        {
            WorkerReportsProgress = true;
        }

        protected override void OnDoWork(DoWorkEventArgs args)
        {
            ReportProgress(0, "Backing up Directus schema...");

            var snapshot = Directus.GetSnapshot().GetAwaiter().GetResult();

            if (!string.IsNullOrWhiteSpace(snapshot))
            {
                File.WriteAllText("snapshot.json", snapshot);
            }

            ReportProgress(100, "Schema backup completed!");
        }
    }
}