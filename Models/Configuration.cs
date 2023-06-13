using System.ComponentModel;

namespace DirectusCompanion.Models
{
    internal class Configuration
    {
        [Category("Directus")]
        [DisplayName("URL")]
        public string Url { get; set; }

        [Category("Directus")]
        [DisplayName("Token")]
        [PasswordPropertyText(true)]
        public string Token { get; set; }

        [Category("AWS")]
        [DisplayName("Access Key ID")]
        public string Username { get; set; }

        [Category("AWS")]
        [DisplayName("Access Key")]
        [PasswordPropertyText(true)]
        public string Password { get; set; }

        [Category("AWS")]
        [DisplayName("Bucket")]
        public string Folder { get; set; }
    }
}