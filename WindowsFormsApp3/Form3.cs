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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

     
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Мем.txt",
                Environment.NewLine + Textname.Text + ", " + textopisanie.Text + ", " + textyear.Text);
       
          if (FileName != "")
    
    {
               System.IO.File.Copy(FileName,
         ".../../Kartinki/" + Textname.Text + ".jpg");
    
    }   
        }
         string FileName = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
             DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }

        }

    }
}
