using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Internet : Form
    {
        public Internet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://ribalych-ru.turbopages.org/s/ribalych.ru/2018/03/14/istoriya-populyarnyx-memov/");
            }
            catch (Exception) { }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
