using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Browse_Click(object sender, EventArgs e)
        {
            string fileName;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.bmp)|*.bmp";
                dialog.Title = "Select a BMP image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = textBox1.Text = dialog.FileName;
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading Image");
            }
        }

        //Create instance of DES
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();            
        
        Random rand = new Random();

        //des.GenerateKey();
        static byte[] sKey = new byte[8];
        //des.GenerateIV();
        static byte[] sIV = new byte[8];

        
        // ECB MODE //
        private void ECB_Click(object sender, EventArgs e)
        {
            
            //Generate IV and Key


            //Set Encryption mode
            des.Mode = CipherMode.ECB;
            
            //Read
            FileStream filestream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);            
            MemoryStream ms = new MemoryStream();
            filestream.CopyTo(ms);
            
            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();

            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();

            //Create encryptor
            var enc = des.CreateEncryptor();

            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);

            //Combine header and encrypted image
            var image = Combine(header, encimg);
            
            //Specify output file path for encrypted image
            //string fileName = @"C:\Users\Public\Pictures\Sample Pictures\ECB.bmp";
            MemoryStream mss = new MemoryStream();
            mss.Write(image, 0, image.Length);

            //Write encrypted image to disk
            //File.WriteAllBytes(fileName, image);

            //Show image from disk to pictureBox
            pictureBox2.Image = Image.FromStream(mss, false);
            
        }




        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        /*public static byte[] YourKey(byte[] sKey)
        {
            
        }*/

        /*public static byte[] YourIV (byte[] sIV)
          {
          }*/


        //CBC Mode

        private void CBC_Click(object sender, EventArgs e)
        {

            //Set Encryption mode
            des.Mode = CipherMode.CBC;

            //Read
            FileStream filestream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            filestream.CopyTo(ms);

            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();

            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();

            //Create encryptor
            var enc = des.CreateEncryptor();

            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);

            //Combine header and encrypted image
            var image = Combine(header, encimg);

            //Specify output file path for encrypted image
            //string fileName = @"C:\Users\Public\Pictures\Sample Pictures\CBC.bmp";
            //FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            
            //Write encrypted image to disk
            //File.WriteAllBytes(fileName, image);
            MemoryStream mss = new MemoryStream();
            mss.Write(image, 0, image.Length);

            //Show image from disk to pictureBox
            pictureBox2.Image = Image.FromStream(mss);
            filestream.Close();
        }


        //CFB Mode

        private void CFB_Click(object sender, EventArgs e)
        {



            //Set Encryption mode
            des.Mode = CipherMode.CFB;

            //Read
            FileStream filestream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            filestream.CopyTo(ms);

            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();

            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();

            //Create encryptor
            var enc = des.CreateEncryptor();

            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);

            //Combine header and encrypted image
            var image = Combine(header, encimg);

            //Specify output file path for encrypted image
            //string ENCFILENAME = @"C:\Users\Public\Pictures\Sample Pictures\CFB.bmp";

            //Write encrypted image to disk
            //File.WriteAllBytes(ENCFILENAME, image);
            MemoryStream mss = new MemoryStream();
            mss.Write(image, 0, image.Length);

            //Show image from disk to pictureBox
            pictureBox2.Image = Image.FromStream(mss);
            filestream.Close();
        }

        private void OFB_Click(object sender, EventArgs e)
        {

            /*rand.NextBytes(sKey);
            des.Key = sKey;

            rand.NextBytes(sIV);
            des.IV = sIV;*/

            /*for (int i = 0; i < 50; i++)
            {
                
            }*/

            //Set Encryption mode
            des.Mode = CipherMode.OFB;

            des.GenerateKey();
            des.GenerateIV();


            //Read
            FileStream filestream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            filestream.CopyTo(ms);

            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();

            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();

            //Create encryptor
            var enc = des.CreateEncryptor();

            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);

            //Combine header and encrypted image
            var image = Combine(header, encimg);

            //Specify output file path for encrypted image
            string ENCFILENAME = @"C:\Users\Public\Pictures\Sample Pictures\OFB.bmp";

            //Write encrypted image to disk
            File.WriteAllBytes(ENCFILENAME, image);

            //Show image from disk to pictureBox
            pictureBox2.Image = Image.FromFile(ENCFILENAME);
            filestream.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeKey_Click(object sender, EventArgs e)
        {
            /*
            Form2 f1 = new Form2();
            f1.Show();
             */
            rand.NextBytes(sKey);
            des.Key = sKey;

        }

        private void ChnageIV_Click(object sender, EventArgs e)
        {
            /*
            Form3 f1 = new Form3();
            f1.Show();
            */
            rand.NextBytes(sIV);
            des.IV = sIV;
        }


        public void SetKey()
        {
            sKey[0]=134;sKey[1]=113;sKey[2]=61;
            sKey[3]=240;sKey[4]=230;sKey[5]=162;
            sKey[6]=11;sKey[7]=195;
            des.Key = sKey;
        }


        public void SetIV()
        {
            sIV[0]=144;sIV[1]=162;sIV[2]=216;sIV[3]=208;
            sIV[4]=111;sIV[5]=41;sIV[6]=76;sIV[7]=171;
            des.IV = sIV;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetKey();
            SetIV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            filestream.CopyTo(ms);

            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();


            byte[] Counter = new byte[8];
            SetCounter(Counter);

            MemoryStream mss = new MemoryStream();

            byte[] PlainImage= ms.ToArray();
            int blocks = PlainImage.Length/8;

            for (int i = 0; i < blocks; i++)
            {
                /*if (i == blocks - 1)
                {
                    var block = ms.ToArray().Take(8).ToArray();
                }*/
                var enc = des.CreateEncryptor();
                var encimg = enc.TransformFinalBlock(Counter, 0, Counter.Length);
                var block = ms.ToArray().Take(8).ToArray();
                byte[] Cipher = XOR(block, Counter);
                mss.Write(Cipher,0,Cipher.Length);
                IncrementCounter(Counter);
            }

            //Create encryptor
            //Encrypt Counter    


            
            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();

            
            //Combine header and encrypted image
            var cip = mss.ToArray();
            var image = Combine(header, cip);

            //Specify output file path for encrypted image
            //string fileName = @"C:\Users\Public\Pictures\Sample Pictures\ECB.bmp";           
            MemoryStream finalIMG = new MemoryStream();
            finalIMG.Write(image, 0, image.Length);

            //Write encrypted image to disk
            //File.WriteAllBytes(fileName, image);

            //Show image from disk to pictureBox
            pictureBox2.Image = Image.FromStream(finalIMG, false);            
        }


        public void SetCounter(byte[] Counter)
        {
            Counter[0] = 144; Counter[1] = 162; Counter[2] = 216; Counter[3] = 208;
            Counter[4] = 111; Counter[5] = 41; Counter[6] = 76; Counter[7] = 171;

        }

        public void IncrementCounter(byte[] Counter)
        {
            for (int i = 0; i < Counter.Length; i++)
            {
                Counter[i] += 1;
            }
        }

        public byte[] XOR(byte[] Block, byte[] Counter)
        {
            for (int i = 0; i < Block.Length; i++)
                Block[i] ^= Counter[i];
            return Block;
        }


    }
}
