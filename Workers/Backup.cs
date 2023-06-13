using System.ComponentModel;

namespace DirectusCompanion.Workers
{
    internal class Backup : Worker
    {
        public Backup()
        {
            WorkerReportsProgress = true;
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            base.OnDoWork(e);
        }
    }
}