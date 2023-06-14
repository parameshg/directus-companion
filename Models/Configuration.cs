using System.ComponentModel;

namespace Directus.Companion.Models
{
    internal class Configuration
    {
        [Category("General")]
        [DisplayName("Auto Start")]
        [Description("Start at Windows login")]
        public bool AutoStart { get; set; }

        [Category("Directus")]
        [DisplayName("URL")]
        [Description("Directus Base URL")]
        public string Url { get; set; }

        [Category("Directus")]
        [DisplayName("Token")]
        [PasswordPropertyText(true)]
        [Description("Directus API Token")]
        public string Token { get; set; }

        [Category("AWS")]
        [DisplayName("Access Key ID")]
        [Description("AWS Access Key ID")]
        public string Username { get; set; }

        [Category("AWS")]
        [DisplayName("Access Key")]
        [PasswordPropertyText(true)]
        [Description("AWS Secret Access Key")]
        public string Password { get; set; }

        [Category("AWS")]
        [DisplayName("Bucket")]
        [Description("AWS Bucket Name")]
        public string Folder { get; set; }

        [Category("AWS")]
        [DisplayName("Region")]
        [Description("AWS Region")]
        public string Region { get; set; }
    }
}