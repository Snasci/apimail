using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace APIMail.Contracts
{
    public class MailContract
    {
        public MailAddress FromAddress { get; set; }
        public List<MailAddress> ToAddresses { get; set; }
        public List<MailAddress> CCAddresses { get; set; }
        public List<MailAddress> BBCAddresses { get; set; }
        public string subject { get; set; }
        public string Body { get; set; }
        public List<byte[]> Attachments { get; set; }
        public DateTime TimeSent { get; set; }
    }
}