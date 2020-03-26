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
    public struct Mem
    {
        public string name;
        public string opisanie;
        public PictureBox pic;
        public int god;
        
        public Mem(string name1 , string opisanie1 , int god1)
        {
            name = name1;
            opisanie = opisanie1;
            pic = new PictureBox();
            god = god1; 
        }
    }

    public partial class Form1 : Form
    {
        Mem[] mems = new Mem[9];
        public Form1()
        {
            InitializeComponent();

            mems[0] = new Mem("Ждун", "Ждун ждет", 2018);
            mems[1] = new Mem("Данила ты что крейзи", "Даёшь малодёшь", 2012);
            mems[2] = new Mem("CJ", "Я снова сдесь", 2004);
            mems[3] = new Mem("Меня заминировали", "ХЗ что это", 1280);
            mems[4] = new Mem("Тролл", "Классика", 2000);
            mems[5] = new Mem("Выйди от сюда розбийник", "Политика", 2019);
            mems[6] = new Mem("Мы не знаем что это такое", "Телевидиние", 2008);
            mems[7] = new Mem("Славик Буйный", "Россиянин", 2003);
            mems[8] = new Mem("Бандит", "Россиянин", 2006);

            int x = 0;
            int y = 0;
            for (int i = 0; i  <mems.Length; i = i + 1)
            {
                try
                {
                    mems[i].pic.Load("../../Kartinki/"+ mems[i].name + ".jpg");
                    mems[i].pic.Location = new Point(x, y);
                    mems[i].pic.Size = new Size(300, 300);
                    mems[i].pic.Click += new EventHandler(pictureBox1_Click);
                    mems[i].pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(mems[i].pic);
                    
                    x = x + 300;
                    if (x + 300 > Width)
                    {
                        x = 0;
                        y = y + 300;
                    }
                }
                catch (Exception) { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mems.Length; i = i + 1)
            {
                if (sender == mems[i].pic)
                {
                    MemForm mf = new MemForm(mems[i]);
                    mf.Show();
                }
            }
        }
    }
}
