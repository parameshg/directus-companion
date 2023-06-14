using Amazon.S3.Model;
using Amazon.S3;
using Directus.Companion.Properties;
using System.ComponentModel;
using System.Net;
using Amazon;
using System.Security.AccessControl;

namespace Directus.Companion.Workers
{
    internal class Restore : Worker
    {
        public Restore()
        {
            WorkerReportsProgress = true;
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            try
            {
                ReportProgress(0, "Restoring Directus schema...");

                Download(Settings.Default.Folder, "directus/snapshot.json", "snapshot.json");

                ReportProgress(25, "Restoring Directus schema...");

                if (File.Exists("snapshot.json"))
                {
                    var snapshot = File.ReadAllText("snapshot.json");

                    if (!string.IsNullOrWhiteSpace(snapshot))
                    {
                        ReportProgress(50, "Restoring Directus schema...");

                        Directus.ApplySnapshot(snapshot);

                        ReportProgress(75, "Restoring Directus schema...");
                    }
                }

                ReportProgress(100, "Schema restore completed!");
            }
            catch (Exception error)
            {
                ReportProgress(0, $"Error: {error.Message}");
            }
        }

        private bool Download(string bucket, string key, string path)
        {
            var aws = new AmazonS3Client(Settings.Default.Username, Settings.Default.Password, RegionEndpoint.GetBySystemName(Settings.Default.Region));

            var request = new GetObjectRequest { BucketName = bucket, Key = key };

            var response = aws.GetObjectAsync(request).GetAwaiter().GetResult();

            response.WriteResponseStreamToFileAsync(path, false, CancellationToken.None).GetAwaiter().GetResult();

            return response.HttpStatusCode == HttpStatusCode.OK;
        }
    }
}