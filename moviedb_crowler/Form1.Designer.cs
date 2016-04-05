namespace moviedb_crowler
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelurl = new System.Windows.Forms.Label();
            this.textBox_ARA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.element1_ver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.veri_yukle = new System.Windows.Forms.Timer(this.components);
            this.data_cek = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imdbveriyukle = new System.Windows.Forms.Timer(this.components);
            this.imdb_veri_cek = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelurl
            // 
            this.labelurl.AutoSize = true;
            this.labelurl.Location = new System.Drawing.Point(12, 23);
            this.labelurl.Name = "labelurl";
            this.labelurl.Size = new System.Drawing.Size(35, 13);
            this.labelurl.TabIndex = 0;
            this.labelurl.Text = "URL :";
            // 
            // textBox_ARA
            // 
            this.textBox_ARA.Location = new System.Drawing.Point(53, 23);
            this.textBox_ARA.Multiline = true;
            this.textBox_ARA.Name = "textBox_ARA";
            this.textBox_ARA.Size = new System.Drawing.Size(127, 20);
            this.textBox_ARA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 165);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1343, 535);
            this.webBrowser1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fim Adı:";
            // 
            // element1_ver
            // 
            this.element1_ver.Location = new System.Drawing.Point(15, 49);
            this.element1_ver.Name = "element1_ver";
            this.element1_ver.Size = new System.Drawing.Size(141, 55);
            this.element1_ver.TabIndex = 5;
            this.element1_ver.Text = "THEMOVİEDB VERİ ÇEK";
            this.element1_ver.UseVisualStyleBackColor = true;
            this.element1_ver.Click += new System.EventHandler(this.element1_ver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fim Yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(894, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yönetmenleı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1155, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Oyuncular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(731, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Film Açıklaması:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "İmdb puan :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(333, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 134);
            this.listBox1.TabIndex = 6;
            // 
            // veri_yukle
            // 
            this.veri_yukle.Interval = 6000;
            this.veri_yukle.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // data_cek
            // 
            this.data_cek.Interval = 2000;
            this.data_cek.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(504, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(78, 134);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(601, 20);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(86, 134);
            this.listBox3.TabIndex = 6;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(713, 20);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(141, 134);
            this.listBox4.TabIndex = 6;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(870, 16);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(123, 134);
            this.listBox5.TabIndex = 6;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(1008, 15);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(100, 134);
            this.listBox6.TabIndex = 6;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(1138, 15);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(89, 134);
            this.listBox7.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "İMDB VERİ ÇEK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(1233, 15);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(89, 134);
            this.listBox8.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1250, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "tür";
            // 
            // imdbveriyukle
            // 
            this.imdbveriyukle.Interval = 6000;
            this.imdbveriyukle.Tick += new System.EventHandler(this.imdbveriyukle_Tick);
            // 
            // imdb_veri_cek
            // 
            this.imdb_veri_cek.Interval = 2000;
            this.imdb_veri_cek.Tick += new System.EventHandler(this.imdb_veri_cek_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.element1_ver);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ARA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelurl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelurl;
        private System.Windows.Forms.TextBox textBox_ARA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button element1_ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer veri_yukle;
        private System.Windows.Forms.Timer data_cek;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer imdbveriyukle;
        private System.Windows.Forms.Timer imdb_veri_cek;
    }
}

