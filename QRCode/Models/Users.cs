using System;

namespace QRCode.Models
{
    public class Users
    {
        public int idUsers { get; set; }
        public Guid token { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string date { get; set; }
        public bool status { get; set; }

        /* */
        public string qrocode { get; set; }
    }
}
