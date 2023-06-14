using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Directus.Companion.Properties;
using System.ComponentModel;
using System.Net;

namespace Directus.Companion.Workers
{
    internal class Backup : Worker
    {
        public Backup()
        {
            WorkerReportsProgress = true;
        }

        protected override void OnDoWork(DoWorkEventArgs args)
        {
            try
            {
                ReportProgress(0, "Backing up Directus schema...");

                var snapshot = Directus.GetSnapshot().GetAwaiter().GetResult();

                ReportProgress(25, "Backing up Directus schema...");

                if (!string.IsNullOrWhiteSpace(snapshot))
                {
                    File.WriteAllText("snapshot.json", snapshot);

                    ReportProgress(50, "Backing up Directus schema...");

                    Upload(Settings.Default.Folder, "directus/snapshot.json", "snapshot.json");

                    ReportProgress(75, "Backing up Directus schema...");
                }

                ReportProgress(100, "Schema backup completed!");
            }
            catch (Exception error)
            {
                ReportProgress(0, $"Error: {error.Message}");
            }
        }

        private bool Upload(string bucket, string key, string path)
        {
            var aws = new AmazonS3Client(Settings.Default.Username, Settings.Default.Password, RegionEndpoint.GetBySystemName(Settings.Default.Region));

            var request = new PutObjectRequest { BucketName = bucket, Key = key, FilePath = path };

            var response = aws.PutObjectAsync(request).GetAwaiter().GetResult();

            return response.HttpStatusCode == HttpStatusCode.OK;
        }
    }
}