using System.ComponentModel;

namespace DirectusCompanion.Workers
{
    internal class Restore : Worker
    {
        public Restore()
        {
            WorkerReportsProgress = true;
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            ReportProgress(0, "Restoring Directus schema...");

            var snapshot = File.ReadAllText("snapshot.json");

            if (!string.IsNullOrWhiteSpace(snapshot))
            {
                Directus.ApplySnapshot(snapshot);
            }

            ReportProgress(100, "Schema restore completed!");
        }
    }
}