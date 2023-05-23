namespace VBV3Project.Models
{
    public class EmailSettings
    {
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool EnableSSL { get; set; }
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Host { get; set; } // add this property
        public int Port { get; set; }
    }

}
