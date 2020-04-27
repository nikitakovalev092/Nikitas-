using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");
            MailAddress toAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");
            using( MailMessage mailMessage =  new MailMessage( fromMailAddress, toAddress))
            using( SmtpClient smtpClient =  new SmtpClient())
            {
                mailMessage.Subject = "Привет";
                mailMessage.Body = "А вот и список Машин";
                mailMessage.Attachments.Add(new Attachment("Мем.txt"));

                smtpClient. Host =  "smtp.gmail.com";
                smtpClient.Port =  587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("kovalevn092@gmail.com,nikitakovalev45");

                smtpClient.Send( mailMessage);
           
            
            }
        
        }

    }	    }
	

            
           
        

        

