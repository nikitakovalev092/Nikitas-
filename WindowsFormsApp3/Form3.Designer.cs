namespace WindowsFormsApp3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Textname = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.Label();
            this.Opisanie = new System.Windows.Forms.Label();
            this.textopisanie = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.Label();
            this.textyear = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textname
            // 
            this.Textname.Location = new System.Drawing.Point(61, 15);
            this.Textname.Name = "Textname";
            this.Textname.Size = new System.Drawing.Size(100, 20);
            this.Textname.TabIndex = 1;
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(-2, 15);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(57, 13);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Название";
            // 
            // Opisanie
            // 
            this.Opisanie.AutoSize = true;
            this.Opisanie.Location = new System.Drawing.Point(-2, 47);
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(57, 13);
            this.Opisanie.TabIndex = 3;
            this.Opisanie.Text = "Описание";
            // 
            // textopisanie
            // 
            this.textopisanie.Location = new System.Drawing.Point(61, 47);
            this.textopisanie.Name = "textopisanie";
            this.textopisanie.Size = new System.Drawing.Size(100, 20);
            this.textopisanie.TabIndex = 4;
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(-2, 71);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(25, 13);
            this.year1.TabIndex = 5;
            this.year1.Text = "Год";
            // 
            // textyear
            // 
            this.textyear.Location = new System.Drawing.Point(61, 73);
            this.textyear.Name = "textyear";
            this.textyear.Size = new System.Drawing.Size(100, 20);
            this.textyear.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Картинка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textyear);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.textopisanie);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Textname);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textname;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Opisanie;
        private System.Windows.Forms.TextBox textopisanie;
        private System.Windows.Forms.Label year1;
        private System.Windows.Forms.TextBox textyear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}