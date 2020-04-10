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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textname
            // 
            this.Textname.Location = new System.Drawing.Point(145, 12);
            this.Textname.Name = "Textname";
            this.Textname.Size = new System.Drawing.Size(100, 20);
            this.Textname.TabIndex = 1;
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(82, 15);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(57, 13);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Название";
            // 
            // Opisanie
            // 
            this.Opisanie.AutoSize = true;
            this.Opisanie.Location = new System.Drawing.Point(82, 40);
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(57, 13);
            this.Opisanie.TabIndex = 3;
            this.Opisanie.Text = "Описание";
            // 
            // textopisanie
            // 
            this.textopisanie.Location = new System.Drawing.Point(145, 40);
            this.textopisanie.Name = "textopisanie";
            this.textopisanie.Size = new System.Drawing.Size(100, 20);
            this.textopisanie.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.textopisanie);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Textname);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textname;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Opisanie;
        private System.Windows.Forms.TextBox textopisanie;
    }
}