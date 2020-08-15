namespace Bilgi_yarışması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsoru = new System.Windows.Forms.Label();
            this.labeldoğru = new System.Windows.Forms.Label();
            this.labelyanlış = new System.Windows.Forms.Label();
            this.buttonsonra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 179);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttona
            // 
            this.buttona.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttona.Location = new System.Drawing.Point(0, 185);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(145, 46);
            this.buttona.TabIndex = 1;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonb.Location = new System.Drawing.Point(206, 185);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(145, 46);
            this.buttonb.TabIndex = 2;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonc.Location = new System.Drawing.Point(0, 247);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(145, 46);
            this.buttonc.TabIndex = 3;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttond
            // 
            this.buttond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttond.Location = new System.Drawing.Point(206, 247);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(145, 46);
            this.buttond.TabIndex = 4;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(449, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(437, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(437, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış :";
            // 
            // labelsoru
            // 
            this.labelsoru.AutoSize = true;
            this.labelsoru.BackColor = System.Drawing.SystemColors.Info;
            this.labelsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoru.Location = new System.Drawing.Point(503, 22);
            this.labelsoru.Name = "labelsoru";
            this.labelsoru.Size = new System.Drawing.Size(20, 24);
            this.labelsoru.TabIndex = 8;
            this.labelsoru.Text = "0";
            // 
            // labeldoğru
            // 
            this.labeldoğru.AutoSize = true;
            this.labeldoğru.BackColor = System.Drawing.SystemColors.Info;
            this.labeldoğru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoğru.Location = new System.Drawing.Point(503, 58);
            this.labeldoğru.Name = "labeldoğru";
            this.labeldoğru.Size = new System.Drawing.Size(20, 24);
            this.labeldoğru.TabIndex = 9;
            this.labeldoğru.Text = "0";
            // 
            // labelyanlış
            // 
            this.labelyanlış.AutoSize = true;
            this.labelyanlış.BackColor = System.Drawing.SystemColors.Info;
            this.labelyanlış.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlış.Location = new System.Drawing.Point(503, 97);
            this.labelyanlış.Name = "labelyanlış";
            this.labelyanlış.Size = new System.Drawing.Size(20, 24);
            this.labelyanlış.TabIndex = 10;
            this.labelyanlış.Text = "0";
            // 
            // buttonsonra
            // 
            this.buttonsonra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsonra.Location = new System.Drawing.Point(396, 137);
            this.buttonsonra.Name = "buttonsonra";
            this.buttonsonra.Size = new System.Drawing.Size(127, 42);
            this.buttonsonra.TabIndex = 11;
            this.buttonsonra.Text = "Sonraki soru";
            this.buttonsonra.UseVisualStyleBackColor = true;
            this.buttonsonra.Click += new System.EventHandler(this.buttonsonra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(539, 295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsonra);
            this.Controls.Add(this.labelyanlış);
            this.Controls.Add(this.labeldoğru);
            this.Controls.Add(this.labelsoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsoru;
        private System.Windows.Forms.Label labeldoğru;
        private System.Windows.Forms.Label labelyanlış;
        private System.Windows.Forms.Button buttonsonra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

