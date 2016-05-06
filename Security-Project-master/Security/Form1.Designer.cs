namespace Security
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ECB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OFB = new System.Windows.Forms.Button();
            this.CFB = new System.Windows.Forms.Button();
            this.CBC = new System.Windows.Forms.Button();
            this.ChangeKey = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ChnageIV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(553, 12);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(162, 32);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse BMP Gray Image";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 32);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(288, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 268);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ECB
            // 
            this.ECB.Location = new System.Drawing.Point(697, 90);
            this.ECB.Name = "ECB";
            this.ECB.Size = new System.Drawing.Size(101, 32);
            this.ECB.TabIndex = 0;
            this.ECB.Text = "View ECB Image";
            this.ECB.UseVisualStyleBackColor = true;
            this.ECB.Click += new System.EventHandler(this.ECB_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "View CTR Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OFB
            // 
            this.OFB.Location = new System.Drawing.Point(697, 246);
            this.OFB.Name = "OFB";
            this.OFB.Size = new System.Drawing.Size(101, 32);
            this.OFB.TabIndex = 4;
            this.OFB.Text = "View OFB Image";
            this.OFB.UseVisualStyleBackColor = true;
            this.OFB.Click += new System.EventHandler(this.OFB_Click);
            // 
            // CFB
            // 
            this.CFB.Location = new System.Drawing.Point(697, 194);
            this.CFB.Name = "CFB";
            this.CFB.Size = new System.Drawing.Size(101, 32);
            this.CFB.TabIndex = 5;
            this.CFB.Text = "View CFB Image";
            this.CFB.UseVisualStyleBackColor = true;
            this.CFB.Click += new System.EventHandler(this.CFB_Click);
            // 
            // CBC
            // 
            this.CBC.Location = new System.Drawing.Point(697, 142);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(101, 32);
            this.CBC.TabIndex = 6;
            this.CBC.Text = "View CBC Image";
            this.CBC.UseVisualStyleBackColor = true;
            this.CBC.Click += new System.EventHandler(this.CBC_Click);
            // 
            // ChangeKey
            // 
            this.ChangeKey.Location = new System.Drawing.Point(51, 324);
            this.ChangeKey.Name = "ChangeKey";
            this.ChangeKey.Size = new System.Drawing.Size(127, 32);
            this.ChangeKey.TabIndex = 7;
            this.ChangeKey.Text = "Change Key";
            this.ChangeKey.UseVisualStyleBackColor = true;
            this.ChangeKey.Click += new System.EventHandler(this.ChangeKey_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(444, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "Close";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ChnageIV
            // 
            this.ChnageIV.Location = new System.Drawing.Point(220, 324);
            this.ChnageIV.Name = "ChnageIV";
            this.ChnageIV.Size = new System.Drawing.Size(136, 32);
            this.ChnageIV.TabIndex = 9;
            this.ChnageIV.Text = "Change IV";
            this.ChnageIV.UseVisualStyleBackColor = true;
            this.ChnageIV.Click += new System.EventHandler(this.ChnageIV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 368);
            this.Controls.Add(this.ChnageIV);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ChangeKey);
            this.Controls.Add(this.CBC);
            this.Controls.Add(this.CFB);
            this.Controls.Add(this.OFB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ECB);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.Text = "Des Block Modes Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ECB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OFB;
        private System.Windows.Forms.Button CFB;
        private System.Windows.Forms.Button CBC;
        private System.Windows.Forms.Button ChangeKey;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ChnageIV;
    }
}

