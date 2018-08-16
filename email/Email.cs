using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    public class Email
    {
        public string emailAddressFrom;
        public string emailAddressTo;
        public string subject;
        public string body;

        public Email(string emailAddressFrom, string emailAddressTo, string subject, string body)
        {
            this.emailAddressFrom = emailAddressFrom;
            this.emailAddressTo = emailAddressTo;
            this.subject = subject;
            this.body = body;
        }

        public void send()
        {
            try
            {
               

                MessageBox.Show("Done!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + exp.InnerException.Message);
            }
        }
    }
}
