using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Encryption
{
    public partial class Form1 : Form
    {
        private string _encryptionKey;

 

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            GenerateEncryptionKey();
        }

        private void GenerateEncryptionKey()
        {
            Random rnd = new Random();

            // Range is 100 - 355 because that makes the keyVals 3 numbers long
            int keyVal1 = rnd.Next(100, 355); 
            int keyVal2 = rnd.Next(100, 355);
            int keyVal3 = rnd.Next(100, 355); 

            KeyTextBox.Text = keyVal1.ToString() + keyVal2 + keyVal3;

            _encryptionKey = KeyTextBox.Text;

        }


       
        private Bitmap EncryptKeyIntoImage(Bitmap bitmap)
        {
            int R =(Int32.Parse(_encryptionKey.Substring(0, 3)) - 100) ;
            int G =(Int32.Parse(_encryptionKey.Substring(3, 3)) - 100);
            int B =(Int32.Parse(_encryptionKey.Substring(6, 3)) - 100);

            Color encryptColor = Color.FromArgb(R, G, B);

            bitmap.SetPixel(0, 0, encryptColor);

            return bitmap;
        }

        private Bitmap EncryptMessageLength(Bitmap bitmap, byte[] messageBytes)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            double divideCount;

            int messageLen = messageBytes.Length;

            if (messageLen > 65025)
            {
                divideCount = (double)messageLen/65025;
                divideCount = Math.Floor(divideCount);
                r = (int)divideCount;

                messageLen -= (int)divideCount * 65025;
            }

            if (messageLen > 255 && messageLen <= 65025)
            {
                
                divideCount = (double) messageLen/255;
                divideCount = Math.Floor(divideCount);
                g = (int)divideCount;

                messageLen -= (int)divideCount * 255;
            }
            
                b = messageLen;
            
            

            Color color = Color.FromArgb(r,g,b);
            bitmap.SetPixel(1,0,color);
            return bitmap;
        }

        private void GenerateEncryptedPic(Bitmap originalBitmap, byte[] messageBytes)
        {
         
            Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            int bitmapHeigth = newBitmap.Height;
            int bitmapWidth = newBitmap.Width;

            // Coppies over the Bitmap
            for (int i = 0; i < originalBitmap.Width; i++)
            {
                for (int j = 0; j < originalBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    var actualColor = originalBitmap.GetPixel(i, j);
                    newBitmap.SetPixel(i, j, actualColor);
                }
            }

            EncryptKeyIntoImage(newBitmap);
            Color encryptionColor = newBitmap.GetPixel(0, 0);
            EncryptMessageLength(newBitmap, messageBytes);

            // Used to determine which pixel needs to be encrypted
            int bitmapX = 0;
            int bitmapY = 0; 

            for (int i = 0; i < messageBytes.Length; i++)
            {
                Color messageColor = new Color();
                switch (i%3)
                {
                    case 0: // Use R
                        bitmapX += encryptionColor.R + (encryptionColor.R * (bitmapY % 3));
                        messageColor = Color.FromArgb(messageBytes[i], encryptionColor.G, encryptionColor.B);
                        break;

                    case 1: // Use G
                        bitmapX += encryptionColor.G + (encryptionColor.G * (bitmapY % 3));
                        messageColor = Color.FromArgb(encryptionColor.R, messageBytes[i], encryptionColor.B);
                        break;

                    case 2: // Use B
                        bitmapX += encryptionColor.B + (encryptionColor.B * (bitmapY % 3));
                        messageColor = Color.FromArgb(encryptionColor.R, encryptionColor.G, messageBytes[i]);
                        break;
                }

                if (bitmapX >= bitmapWidth) // check if > or =>
                {
                    bitmapX = bitmapX % bitmapWidth;
                    bitmapY += 1;
                }
                if (bitmapY >= bitmapHeigth)
                {
                    bitmapY = 0;
                }

                newBitmap.SetPixel(bitmapX, bitmapY, messageColor);
            }

            pictureBox.Image = newBitmap;
        }

        private int GetMessageLength(Color color)
        {
            int length = 0;
            length += color.R*255*255;
            length += color.G*255;
            length += color.B;

            return length;
        }

        // Used to go from text to encrypted img.
        private void EncryptButton_Click(object sender, EventArgs e)
        {

            if (EncryptionTextBox.Text == "")
            {
                MessageBox.Show("No text to encrypt", "Missing text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (pictureBox.Image == null)
            {
                MessageBox.Show("No Image", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                byte[] asciiBytes =  Encoding.ASCII.GetBytes(EncryptionTextBox.Text);
                Bitmap bmp = new Bitmap(pictureBox.Image);

                GenerateEncryptedPic(bmp,asciiBytes);
                MessageBox.Show("Encryption has finished succesfully.", "Encryption has finished succesfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DecryptImage()
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            Color decryptColor = bmp.GetPixel(0, 0);
            Color lengthColor = bmp.GetPixel(1, 0);

            int messageLength = GetMessageLength(lengthColor);
            int bitmapHeight = bmp.Height;
            int bitmapWidth = bmp.Width;

            // Used to determine which pixel needs to be encrypted
            int bitmapX = 0;
            int bitmapY = 0;

            List<Byte> messageBytes = new List<byte>();

            for (int i = 0; i < messageLength; i++)
            {
                Color pixel;
                switch (i%3)
                {

                    case 0: // Use R
                        bitmapX += decryptColor.R + (decryptColor.R* (bitmapY % 3));
                        break;

                    case 1: // Use G
                        bitmapX += decryptColor.G + (decryptColor.G* (bitmapY % 3));
                        break;

                    case 2: // Use B
                        bitmapX += decryptColor.B + (decryptColor.B* (bitmapY % 3));
                        break;
                }

                if (bitmapX >= bitmapWidth) // check if > or =>
                {
                    bitmapX = bitmapX % bitmapWidth;
                    bitmapY += 1;
                }
                if (bitmapY >= bitmapHeight)
                {
                    bitmapY = 0;
                }

                switch (i % 3)
                {
                    case 0: // Use R
                        pixel = bmp.GetPixel(bitmapX, bitmapY);
                        messageBytes.Add(pixel.R);
                        break;

                    case 1: // Use G
                        pixel = bmp.GetPixel(bitmapX, bitmapY);
                        messageBytes.Add(pixel.G);
                        break;

                    case 2: // Use B
                        pixel = bmp.GetPixel(bitmapX, bitmapY);
                        messageBytes.Add(pixel.B);
                        break;
                }


            }


            var str = System.Text.Encoding.Default.GetString(messageBytes.ToArray());

            EncryptionTextBox.Text = str;
            MessageBox.Show("Text Has succesfull been decrypted!", "Text Has succesfull been decrypted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ImportImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String path = openFileDialog.FileName;

                try
                {
                    pictureBox.Image = Image.FromFile(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid File", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            ImportImage();
            DecryptImage();
        }

        private void KeyGenButton_Click(object sender, EventArgs e)
        {
            GenerateEncryptionKey();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportImage();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Encrypted image somewhere";

            if (pictureBox.Image == null)
            {
                MessageBox.Show("No Image to save.", "No Image to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName + ".png";
                pictureBox.Image.Save(path,ImageFormat.Png);
                MessageBox.Show("Saved File Succefull", "Saved File Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            EncryptionTextBox.Text = "";
            EmailTextBox.Text = "";
            pictureBox.Image = null;
            GenerateEncryptionKey();
            MessageBox.Show("Cleared All Fields succesfull!", "Cleared All Fields succesfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Clipboard.SetImage(pictureBox.Image);
                MessageBox.Show("Image succesfully copied to clipboard.", "Image succesfully copied to clipboard.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong with copying the image to the clipboard.", "Copy to clipboard failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be implemented in the future", "Not implemented yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
