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

        private void button_translatiaX_Click(object sender, EventArgs e)
        {
            workImage.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    int newY = j + 50;
                    if (newY < workImage.Height)
                    {
                        Color newColor = workImage.GetPixel(i, newY);
                        workImage.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        workImage.SetPixel(i, j, Color.Black);
                    }
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void button_translatiaY_Click(object sender, EventArgs e)
        {
            workImage.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    int newX = i + 50;
                    if (newX < workImage.Width)
                    {
                        Color newColor = workImage.GetPixel(newX, j);
                        workImage.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        workImage.SetPixel(i, j, Color.Black);
                    }
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void button_Marire_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            workImage2.Lock();
            for (int i = 0; i < (workImage.Width / 2); i++)
            {
                for (int j = 0; j < (workImage.Height / 2); j++)
                {
                    color = workImage2.GetPixel(i, j);
                    workImage.SetPixel(i * 2, j * 2, color);
                    workImage.SetPixel((i * 2) + 1, j * 2, color);
                    workImage.SetPixel(i * 2, (j * 2) + 1, color);
                    workImage.SetPixel((i * 2) + 1, (j * 2) + 1, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImage2.Unlock();
        }

        private void button_Micsorare_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i += 2)
            {
                for (int j = 0; j < workImage.Height; j += 2)
                {
                    color = workImage.GetPixel(i, j);

                    workImage.SetPixel(i / 2, j / 2, color);
                }
            }


            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    if (!(i < workImage.Width / 2 && j < workImage.Height / 2))
                        workImage.SetPixel(i, j, Color.Black);
                }
            }

            //var image = new Bitmap(workImage.Width, workImage.Height);
            //using (Graphics graphics = Graphics.FromImage(image2))
            //{
            //    using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0)))

            //        graphics.FillRectangle(brush, 0, 0, image.Width, image.Height);
            //}

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_Rotatia_Click(object sender, EventArgs e)
        {
            workImage.Lock();
            workImage2.Lock();
            float unghi = float.Parse(textBox_Rotatie.Text);
            double unghiRad = (double.Parse(textBox_Rotatie.Text) * Math.PI / 180);
            bool[,] testMat = new bool[workImage.Width, workImage.Height];

            int x0 = workImage.Width / 2, y0 = workImage.Height / 2;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {

                    workImage.SetPixel(i, j, Color.Black);


                }
            }

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    Color newColor = workImage2.GetPixel(i, j);
                    int x2 = (int)(Math.Cos(unghiRad) * (i - x0) - Math.Sin(unghiRad) * (j - y0) + x0);
                    int y2 = (int)(Math.Sin(unghiRad) * (i - x0) + Math.Cos(unghiRad) * (j - y0) + y0);

                    if (!(x2 < 0 || x2 >= workImage.Width || y2 < 0 || y2 >= workImage.Height))
                    {
                        testMat[x2, y2] = true;
                        workImage.SetPixel(x2, y2, newColor);
                    }
                }
            }

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    if (testMat[i, j] == false)
                    {
                        int x = i, y = j;
                        Color color1 = workImage.GetPixel(i - 1, j + 1);
                        Color color2 = workImage.GetPixel(i + 1, j - 1);
                        Color color3 = workImage.GetPixel(i + 1, j + 1);
                        Color color4 = workImage.GetPixel(i - 1, j - 1);
                        int R = (color1.R + color2.R + color3.R + color4.R) / 4;
                        int G = (color1.G + color2.G + color3.G + color4.G) / 4;
                        int B = (color1.B + color2.B + color3.B + color4.B) / 4;


                        Color colorNew = Color.FromArgb(R, G, B);

                        workImage.SetPixel(i, j, colorNew);
                    }
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImage2.Unlock();
        }

        private void button_FTJ_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();

            int n = int.Parse(textBox_FTJ.Text);

            int[,] h = new int[,]
            { { 1, n ,1},
            { n, n*n ,n},
            { 1, n ,1}};

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            color = workImage.GetPixel(k, l);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            sumB += h[k - i + 1, l - j + 1] * B;
                            sumG += h[k - i + 1, l - j + 1] * G;
                            sumR += h[k - i + 1, l - j + 1] * R;
                        }
                    }

                    int medieR = sumR / ((n + 2) * (n + 2));
                    int medieG = sumG / ((n + 2) * (n + 2));
                    int medieB = sumB / ((n + 2) * (n + 2));

                    color = Color.FromArgb(medieR, medieG, medieB);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_Outlier_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();
            int prag = int.Parse(textBox_outlier.Text);

            int[,] h = new int[,]
            { { 1, 1 ,1},
            { 1, 0 ,1},
            { 1, 1 ,1}};

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            color = workImage.GetPixel(k, l);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;

                            sumR += h[k - i + 1, l - j + 1] * R;
                            sumB += h[k - i + 1, l - j + 1] * B;
                            sumG += h[k - i + 1, l - j + 1] * G;
                        }
                    }

                    int medieR, medieG, medieB;
                    medieR = sumR / 8;
                    medieG = sumG / 8;
                    medieB = sumB / 8;

                    color = workImage.GetPixel(i, j);
                    int intR = color.R;
                    int intG = color.G;
                    int intB = color.B;

                    if (Math.Abs(intR - medieR) > prag &&
                        Math.Abs(intG - medieG) > prag &&
                        Math.Abs(intB - medieB) > prag)
                    {
                        color = Color.FromArgb(medieR, medieG, medieB);
                        workImage.SetPixel(i, j, color);
                    }
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }
    }
}