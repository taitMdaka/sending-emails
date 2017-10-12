using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace sending_email
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butnSend_Click(object sender, EventArgs e)
        {

            login = new NetworkCredential(textUser.Text, textPass.Text);
            client = new SmtpClient(textSMTP.Text);
            client.Port = Convert.ToInt32(textPort.Text);
            client.EnableSsl = checkBox1.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(textUser.Text + textSMTP.Text.Replace("smtp.", "@"), "Tait", Encoding.UTF8) };
            msg.To.Add(new MailAddress(textTo.Text));
            if (!string.IsNullOrEmpty(textCC.Text))
                msg.To.Add(new MailAddress(textCC.Text));
            msg.Subject = textSubject.Text;
            msg.Body = textMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending .....";
            client.SendAsync(msg, userstate);
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled,", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("your Messege has been sent successfully.", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}
