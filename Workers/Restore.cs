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
            base.OnDoWork(e);
        }
    }
}