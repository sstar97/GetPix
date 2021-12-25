using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPixRGB
{
    public partial class Form1 : Form
    {
        bool ngtf, gray, krmz, ysl, mav = true;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        //Mouse ile tıklandığında pixeldeki renk kodlarını alma.
        private void pitcureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                Bitmap b = new Bitmap(pictureBox1.Image);
                Color color = b.GetPixel(e.X, e.Y);
                textBox1.Text = "R:" + color.R.ToString();
                textBox2.Text = "G:" + color.G.ToString();
                textBox3.Text = "B:" + color.B.ToString();
            }
        }

        //Yeşil yapma.
        private void button6_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                ysl = !ysl;
                
                Bitmap ys = new Bitmap(pictureBox1.Image);

                int width = ys.Width;
                int height = ys.Height;

                if (ysl == false)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {


                            Color p = ys.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;



                            ys.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                        }
                    }
                    pictureBox1.Image = ys;
                    button6.Text = "Orjinale Döndür";
                }
                else
                {
                    pictureBox1.Image = pictureBox2.Image;
                    button6.Text = "Yeşil";
                }
            }
        }

        //Mavi yapma
        private void button7_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                mav = !mav;

                Bitmap mv = new Bitmap(pictureBox1.Image);

                int width = mv.Width;
                int height = mv.Height;

                if (mav == false)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {


                            Color p = mv.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;



                            mv.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                        }
                    }
                    pictureBox1.Image = mv;
                    button7.Text = "Orjinale Döndür";
                }
                else
                {

                    pictureBox1.Image = pictureBox2.Image;
                    button7.Text = "Mavi";
                }
            }
        }

        //Üzerinde çalışılan fotoğrafı kaydetme.
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Kaydet";
            saveDialog.Filter = "Resim Dosyaları (*.png;*.jpg)|*.png;*.jpg";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveDialog.FileName;
            }
        }

        //Negatif yapma.
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                ngtf = !ngtf;
                
                Bitmap ng = new Bitmap(pictureBox1.Image);

                int width = ng.Width;
                int height = ng.Height;

                if (ngtf == false)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {

                        
                            Color p = ng.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            r = 255 - r;
                            g = 255 - g;
                            b = 255 - b;

                            ng.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        }
                    }
                    pictureBox1.Image = ng;
                    button4.Text = "Orjinale Döndür";
                }
                else
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {


                            Color p = ng.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            r = 255 - r;
                            g = 255 - g;
                            b = 255 - b;

                            ng.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        }
                    }
                    pictureBox1.Image = ng;
                    button4.Text = "Negatife Çevir";
                }
            }
        }

        //Kırmızı yapma.
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                krmz = !krmz;
                
                Bitmap kr = new Bitmap(pictureBox1.Image);

                int width = kr.Width;
                int height = kr.Height;

                if (krmz == false)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {


                            Color p = kr.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            

                            kr.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                        }
                    }
                    pictureBox1.Image = kr;
                    button5.Text = "Orjinale Döndür";
                }
                else
                {

                    pictureBox1.Image = pictureBox2.Image;
                    button5.Text = "Kırmızı";
                }
            }
        }

        //Siyah-Beyaz yapma.
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf yükleyin!");
            }
            else
            {
                gray = !gray;
                
                Bitmap gr = new Bitmap(pictureBox1.Image);

                int width = gr.Width;
                int height = gr.Height;

                if(gray== false)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Color p = gr.GetPixel(x, y);

                            p = gr.GetPixel(x, y);

                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            int avrj = (r + g + b) / 3;

                            gr.SetPixel(x, y, Color.FromArgb(a, avrj, avrj, avrj));
                        }
                    }
                    pictureBox1.Image = gr;
                    button3.Text = "Orjinale Çevir";
                }
                else
                {
                    pictureBox1.Image = pictureBox2.Image;
                    button3.Text = "Siyah-Beyaz Çevir";
                }
            }
        }


    }
}
