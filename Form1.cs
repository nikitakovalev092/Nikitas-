﻿using System;
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

        public Mem(string name1, string opisanie1, int god1)
        {
            name = name1;
            opisanie = opisanie1;
            pic = new PictureBox();
            god = god1;
        }
    }

    public partial class Form1 : Form
    {
        Mem[] mems = new Mem[12];
        public Form1()
        {
            InitializeComponent();

            mems[0] = new Mem("Ждун", "Ждун ждет", 2018);
            mems[1] = new Mem("Данила ты что крейзи", "Даёшь малодёшь", 2012);
            mems[2] = new Mem("CJ", "Я снова сдесь", 2004);
            mems[3] = new Mem("Меня заминировали", "ХЗ что это", 1280);
            mems[4] = new Mem("Выйди от сюда розбийник", "Политика", 2019);
            mems[5] = new Mem("Мы не знаем что это такое", "Телевидиние", 2008);
            mems[6] = new Mem("Славик Буйный", "Россиянин", 2003);
            mems[7] = new Mem("Бандит", "Россиянин", 2006);
            mems[8] = new Mem("Санис", "Соник", 1998);
            mems[9] = new Mem("Человек павук", "Мульты", 1999);
            mems[10] = new Mem("Майг вазовский", "Мульты", 2001);
            mems[11] = new Mem("Шкек", "Мульты", 2003);




            int x = 0;
            int y = 100;
            for (int i = 0; i < mems.Length; i = i + 1)
            {
                try
                {
                    mems[i].pic.Load("../../Kartinki/" + mems[i].name + ".jpg");
                    mems[i].pic.Location = new Point(x, y);
                    mems[i].pic.Size = new Size(200, 150);
                    mems[i].pic.Click += new EventHandler(pictureBox1_Click);
                    mems[i].pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(mems[i].pic);

                    x = x + 200;
                    if (x + 200 > Width)
                    {
                        x = 0;
                        y = y + 150;
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mems.Length; i = i + 1)
            {
                mems[i].pic.Visible = true;

            if (numericUpDown1.Value > 0 &&
                numericUpDown1.Value!= mems[i].god)
            {
            
                mems[i].pic.Visible = false;
       }

            if (mems[i].pic.Visible)
            {
                int x = 0;
                int y = 100;
                
                mems[i].pic.Location = new Point(x, y);

                x = x + 200;
                if (x + 200 > Width)
                {
                    x = 0;
                    y = y + 150;
                }
            }

                
                if (textBox1.Text != "" &&
                !mems[i].name.Contains(textBox1.Text))
        
            {
                   
            mems[i].pic.Visible = false;
        
            
           }             
           
            
            
            
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
