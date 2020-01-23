using System;
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
    public partial class Who : Form
    {
        int nomerVoprosa = 1;
        public Who()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Load("https://cs.pikabu.ru/post_img/2013/10/06/8/1381064065_1496238504.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        void nextQuestion()
        {
            nomerVoprosa++;
            if (nomerVoprosa == 1)
            {
                pictureBox1.Load("../../Kartinki/590.jpg");
                button2.Text = "О май гад данила ты что крейзи";
                button3.Text = "не панимаю ";
                button4.Text = "Арбуз";
            }
            if (nomerVoprosa == 2)
            {
                pictureBox1.Load("../../Kartinki/kreizi.jpg");
                button2.Text = "О май гад данила ты что крейзи";
                button3.Text = "не панимаю ";
                button4.Text = "Арбуз";
            }
            if (nomerVoprosa == 3)
            {
                pictureBox1.Load("../../Kartinki/Dad.jpg");
                button2.Text = "бать те нармально";
                button3.Text = "отдых на море ";
                button4.Text = "рыбалка с дедом";

            }

            if (nomerVoprosa == 4)
            {
                pictureBox1.Load("../../Kartinki/CJ.jpg");
                button2.Text = "ah shit here we go again";
                button3.Text = "Вот деоьмо я снова здесь  ";
                button4.Text = "КИСЕЛЬ";



            }
                    
                    }


        private void button2_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }
    }
}
