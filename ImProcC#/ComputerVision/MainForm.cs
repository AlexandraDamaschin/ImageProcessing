using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        private string sSourceFileName = "";
        //image 1
        private FastImage workImage;
        private Bitmap image = null;
        //image 2
        private FastImage workImage2;
        private Bitmap image2 = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panelSource.BackgroundImage = new Bitmap(sSourceFileName);
            //initialize image 1
            image = new Bitmap(sSourceFileName);
            workImage = new FastImage(image);
            //initialize image 2
            image2 = new Bitmap(sSourceFileName);
            workImage2 = new FastImage(image2);
        }

        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((R + G + B) / 3);

                    color = Color.FromArgb(average, average, average);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();

        }

        private void button_negativizare_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    color = Color.FromArgb(255 - R, 255 - G, 255 - B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void trackBar1_luminozitate_ValueChanged(object sender, EventArgs e)
        {
            Color color;
            int delta = trackBar1_luminozitate.Value;

            workImage.Lock();
            workImage2.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage2.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    //set R
                    if (R + delta > 255)
                    {
                        R = 255;
                    }
                    else if (R + delta < 0)
                    {
                        R = 0;
                    }
                    else
                    {
                        R = (R + delta);
                    }

                    // set G
                    if (G + delta > 255)
                    {
                        G = 255;
                    }
                    else if (G + delta < 0)
                    {
                        G = 0;
                    }
                    else
                    {
                        G = (G + delta);
                    }

                    //set B
                    if (B + delta > 255)
                    {
                        B = 255;
                    }
                    else if (B + delta < 0)
                    {
                        B = 0;
                    }
                    else
                    {
                        B = (B + delta);
                    }
                    //change color of image
                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImage2.Unlock();
        }

        private void trackBar2_contrast_Scroll(object sender, EventArgs e)
        {
            Color color;
            int delta = trackBar2_contrast.Value;

            workImage.Lock();
            workImage2.Lock();

            int maxG = -256, maxR = -256, maxB = -256;
            int minG = 256, minR = 256, minB = 256;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage2.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    //set max
                    if (R > maxR)
                        maxR = R;

                    if (G > maxG)
                        maxG = G;

                    if (B > maxB)
                        maxB = B;

                    //set min   
                    if (R < minR)
                        maxR = R;

                    if (G < minG)
                        maxG = G;

                    if (B < minB)
                        maxB = B;

                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }

            //calculate a
            int aR = minR + delta;
            int aG = minG + delta;
            int aB = minB + delta;

            //calculate b
            int bR = maxR - delta;
            int bG = maxG - delta;
            int bB = maxB - delta;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    //set R
                    R = (bR - aR) * (R - minR) / (maxR - minR) + aR;
                    if (R > 255)
                    {
                        R = 255;
                    }
                    else if (R < 0)
                    {
                        R = 0;
                    }

                    //set B
                    B = (bB - aB) * (B - minB) / (maxB - minB) + aB;
                    if (B > 255)
                    {
                        B = 255;
                    }
                    else if (B < 0)
                    {
                        B = 0;
                    }

                    //set G
                    G = (bG - aG) * (G - minG) / (maxG - minG) + aR;
                    if (G > 255)
                    {
                        G = 255;
                    }
                    else if (G < 0)
                    {
                        G = 0;
                    }

                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImage2.Unlock();
        }

        private void button_egalizare_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();

            int[] hist = new int[256];
            int[] histC = new int[256];
            int[] transf = new int[256];

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    int average = (R + G + B) / 3;

                    /* Posibil sa nu fie initializat cu 0 */
                    hist[average]++;
                }
            }


            histC[0] = hist[0];
            for (int i = 1; i < 256; i++)
            {
                histC[i] = histC[i - 1] + hist[i];
            }


            for (int i = 0; i < 256; i++)
            {
                transf[i] = (histC[i] * 255) / (workImage.Width * workImage.Height);
            }


            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    int intensity = (R + G + B) / 3;

                    Color newColor = Color.FromArgb(transf[intensity], transf[intensity], transf[intensity]);
                    workImage.SetPixel(i, j, newColor);

                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_reflexia_Click(object sender, EventArgs e)
        {
            workImage.Lock();
            workImage2.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    int newY = -j + (workImage.Height - 1);
                    Color newColor = workImage2.GetPixel(i, newY);
                    workImage.SetPixel(i, j, newColor);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
            workImage2.Unlock();
        }
    }
}