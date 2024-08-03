using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCatCafe.Model.Entities
{
    public class SmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }  // UserName ile Password özelliklerinin doğru tanımlandığından emin olun
        public string Password { get; set; }
    }
}
