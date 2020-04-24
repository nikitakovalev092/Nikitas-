using System;
using System.Net;
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
    public partial class MemForm : Form
    {    Mem mem;
       
        
        public MemForm(Mem mem1)
        {
             mem = mem1;
            
            InitializeComponent();
            Text = mem.name;
            
            label1.Text = mem.opisanie;
            pictureBox1.Image = mem.pic.Image;
        }
       
        
        
       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(mem.kniga,
                "C:\\Users\\" + Environment.UserName + "\\Downloads\\" + mem.name + ".pdf");
            MessageBox.Show("Сохранено в " + mem.name + ".pdf");

        }
    }


}
