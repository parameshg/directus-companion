using System.ComponentModel;

namespace DirectusCompanion
{
    internal class Configuration
    {
        [Category("Source")]
        [DisplayName("URL")]
        public string SourceUrl { get; set; }

        [Category("Source")]
        [DisplayName("Token")]
        [PasswordPropertyText(true)]
        public string SourceToken { get; set; }

        [Category("Target")]
        [DisplayName("URL")]
        public string TargetUrl { get; set; }

        [Category("Target")]
        [DisplayName("Token")]
        [PasswordPropertyText(true)]
        public string TargetToken { get; set; }

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