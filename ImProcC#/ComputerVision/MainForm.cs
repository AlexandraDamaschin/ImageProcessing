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

        private void button_median_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();

            int[,] h = new int[,]
            { { 1, 1 ,1},
            { 1, 0 ,1},
            { 1, 1 ,1}};

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    Color colorA = workImage.GetPixel(i - 1, j);
                    Color colorB = workImage.GetPixel(i, j - 1);
                    Color colorC = workImage.GetPixel(i, j);
                    Color colorD = workImage.GetPixel(i, j + 1);
                    Color colorE = workImage.GetPixel(i + 1, j);

                    #region RED
                    float min1R, min2R, min3R, min4R, min5R, min6R, min7R, min8R, min9R, min10R;
                    min1R = Math.Min(Math.Min(colorA.R, colorB.R), colorC.R);
                    min2R = Math.Min(Math.Min(colorA.R, colorB.R), colorD.R);
                    min3R = Math.Min(Math.Min(colorA.R, colorB.R), colorE.R);
                    min4R = Math.Min(Math.Min(colorA.R, colorC.R), colorD.R);
                    min5R = Math.Min(Math.Min(colorA.R, colorE.R), colorC.R);
                    min6R = Math.Min(Math.Min(colorA.R, colorD.R), colorE.R);
                    min7R = Math.Min(Math.Min(colorD.R, colorB.R), colorC.R);
                    min8R = Math.Min(Math.Min(colorE.R, colorB.R), colorC.R);
                    min9R = Math.Min(Math.Min(colorE.R, colorB.R), colorD.R);
                    min10R = Math.Min(Math.Min(colorC.R, colorD.R), colorE.R);

                    float maxR = Math.Max(min1R, Math.Max(min2R, Math.Max(min3R, Math.Max(min4R,
                         Math.Max(min5R, Math.Max(min6R, Math.Max(min7R, Math.Max(min8R,
                         Math.Max(min9R, min10R)))))))));
                    #endregion

                    #region GREEN
                    float min1G, min2G, min3G, min4G, min5G, min6G, min7G, min8G, min9G, min10G;
                    min1G = Math.Min(Math.Min(colorA.G, colorB.G), colorC.G);
                    min2G = Math.Min(Math.Min(colorA.G, colorB.G), colorD.G);
                    min3G = Math.Min(Math.Min(colorA.G, colorB.G), colorE.G);
                    min4G = Math.Min(Math.Min(colorA.G, colorC.G), colorD.G);
                    min5G = Math.Min(Math.Min(colorA.G, colorE.G), colorC.G);
                    min6G = Math.Min(Math.Min(colorA.G, colorD.G), colorE.G);
                    min7G = Math.Min(Math.Min(colorD.G, colorB.G), colorC.G);
                    min8G = Math.Min(Math.Min(colorE.G, colorB.G), colorC.G);
                    min9G = Math.Min(Math.Min(colorE.G, colorB.G), colorD.G);
                    min10G = Math.Min(Math.Min(colorC.G, colorD.G), colorE.G);

                    float maxG = Math.Max(min1G, Math.Max(min2G, Math.Max(min3G, Math.Max(min4G,
                         Math.Max(min5G, Math.Max(min6G, Math.Max(min7G, Math.Max(min8G,
                         Math.Max(min9G, min10G)))))))));
                    #endregion

                    #region blue
                    float min1B, min2B, min3B, min4B, min5B, min6B, min7B, min8B, min9B, min10B;
                    min1B = Math.Min(Math.Min(colorA.B, colorB.B), colorC.B);
                    min2B = Math.Min(Math.Min(colorA.B, colorB.B), colorD.B);
                    min3B = Math.Min(Math.Min(colorA.B, colorB.B), colorE.B);
                    min4B = Math.Min(Math.Min(colorA.B, colorC.B), colorD.B);
                    min5B = Math.Min(Math.Min(colorA.B, colorE.B), colorC.B);
                    min6B = Math.Min(Math.Min(colorA.B, colorD.B), colorE.B);
                    min7B = Math.Min(Math.Min(colorD.B, colorB.B), colorC.B);
                    min8B = Math.Min(Math.Min(colorE.B, colorB.B), colorC.B);
                    min9B = Math.Min(Math.Min(colorE.B, colorB.B), colorD.B);
                    min10B = Math.Min(Math.Min(colorC.B, colorD.B), colorE.B);

                    float maxB = Math.Max(min1B, Math.Max(min2B, Math.Max(min3B, Math.Max(min4B,
                         Math.Max(min5B, Math.Max(min6B, Math.Max(min7B, Math.Max(min8B,
                         Math.Max(min9B, min10B)))))))));
                    #endregion

                    color = Color.FromArgb((int)maxR, (int)maxG, (int)maxB);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_pseudomedian_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();

            int[,] h = new int[,]
            { { 1, 1 ,1},
            { 1, 0 ,1},
            { 1, 1 ,1}};

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    Color colorA, colorB, colorC, colorD, colorE;
                    colorA = workImage.GetPixel(i - 1, j);
                    colorB = workImage.GetPixel(i, j - 1);
                    colorC = workImage.GetPixel(i, j);
                    colorD = workImage.GetPixel(i, j + 1);
                    colorE = workImage.GetPixel(i + 1, j);

                    #region RED
                    float min1R, min2R, min3R;
                    min1R = Math.Min(Math.Min(colorA.R, colorB.R), colorC.R);
                    min2R = Math.Min(Math.Min(colorC.R, colorB.R), colorD.R);
                    min3R = Math.Min(Math.Min(colorD.R, colorC.R), colorE.R);

                    float max1R, max2R, max3R;
                    max1R = Math.Max(Math.Max(colorA.R, colorB.R), colorC.R);
                    max2R = Math.Max(Math.Max(colorC.R, colorB.R), colorD.R);
                    max3R = Math.Max(Math.Max(colorD.R, colorC.R), colorE.R);

                    double pmedR = (Math.Max(min1R, Math.Max(min2R, min3R)) + Math.Min(max1R, Math.Min(max2R, max3R))) / 2;
                    #endregion

                    #region GREEN
                    float min1G, min2G, min3G;
                    min1G = Math.Min(Math.Min(colorA.G, colorB.G), colorC.G);
                    min2G = Math.Min(Math.Min(colorC.G, colorB.G), colorD.G);
                    min3G = Math.Min(Math.Min(colorD.G, colorC.G), colorE.G);

                    float max1G, max2G, max3G;
                    max1G = Math.Max(Math.Max(colorA.G, colorB.G), colorC.G);
                    max2G = Math.Max(Math.Max(colorC.G, colorB.G), colorD.G);
                    max3G = Math.Max(Math.Max(colorD.G, colorC.G), colorE.G);

                    double pmedG = (Math.Max(min1G, Math.Max(min2G, min3G)) + Math.Min(max1G, Math.Min(max2G, max3G))) / 2;
                    #endregion

                    #region BLUE
                    float min1B, min2B, min3B;
                    min1B = Math.Min(Math.Min(colorA.B, colorB.B), colorC.B);
                    min2B = Math.Min(Math.Min(colorC.B, colorB.B), colorD.B);
                    min3B = Math.Min(Math.Min(colorD.B, colorC.B), colorE.B);

                    float max1B, max2B, max3B;
                    max1B = Math.Max(Math.Max(colorA.B, colorB.B), colorC.B);
                    max2B = Math.Max(Math.Max(colorC.B, colorB.B), colorD.B);
                    max3B = Math.Max(Math.Max(colorD.B, colorC.B), colorE.B);

                    double pmedB = (Math.Max(min1B, Math.Max(min2B, min3B)) + Math.Min(max1B, Math.Min(max2B, max3B))) / 2;
                    #endregion

                    color = Color.FromArgb((int)pmedR, (int)pmedG, (int)pmedB);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_filtruZgomot_Click(object sender, EventArgs e)
        {
            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    int index = 0;
                    int[] vectR = new int[9];
                    int[] vectG = new int[9];
                    int[] vectB = new int[9];

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            Color newColor = workImage.GetPixel(k, l);
                            vectR[index] = newColor.R;
                            vectG[index] = newColor.G;
                            vectB[index] = newColor.B;
                            index++;
                        }
                    }

                    for (int k = 0; k < 9 - 1; k++)
                    {
                        for (int l = k + 1; l < 9; l++)
                        {
                            if (vectB[k] < vectB[l])
                            {
                                int temp = vectB[k];
                                vectB[k] = vectB[l];
                                vectB[l] = temp;
                            }
                            if (vectG[k] < vectG[l])
                            {
                                int temp = vectG[k];
                                vectG[k] = vectG[l];
                                vectG[l] = temp;
                            }
                            if (vectR[k] < vectR[l])
                            {
                                int temp = vectR[k];
                                vectR[k] = vectR[l];
                                vectR[l] = temp;
                            }
                        }
                    }
                    Color colorNew = Color.FromArgb(vectR[4], vectG[4], vectB[4]);
                    workImage.SetPixel(i, j, colorNew);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button_FTS_Click(object sender, EventArgs e)
        {
            Color color;
            workImage.Lock();
            workImage2.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    color = workImage.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    int sumR = 0, sumG = 0, sumB = 0;

                    //RED
                    sumR += -(workImage.GetPixel(i, j - 1).R +
                              workImage.GetPixel(i, j + 1).R +
                              workImage.GetPixel(i - 1, j).R +
                              workImage.GetPixel(i + 1, j).R +
                              workImage.GetPixel(i - 1, j - 1).R +
                              workImage.GetPixel(i - 1, j + 1).R +
                              workImage.GetPixel(i + 1, j - 1).R +
                              workImage.GetPixel(i + 1, j + 1).R);
                    sumR += 9 * R;

                    if (sumR < 0)
                        sumR = 0;
                    else if (sumR > 255)
                        sumR = 255;

                    //GREEN
                    sumG += -(workImage.GetPixel(i, j - 1).G +
                              workImage.GetPixel(i, j + 1).G +
                              workImage.GetPixel(i - 1, j).G +
                              workImage.GetPixel(i + 1, j).G +
                              workImage.GetPixel(i - 1, j - 1).G +
                              workImage.GetPixel(i - 1, j + 1).G +
                              workImage.GetPixel(i + 1, j - 1).G +
                              workImage.GetPixel(i + 1, j + 1).G);
                    sumG += 9 * G;

                    if (sumG < 0)
                        sumG = 0;
                    else if (sumG > 255)
                        sumG = 255;

                    //BLUE
                    sumB += -(workImage.GetPixel(i, j - 1).B +
                              workImage.GetPixel(i, j + 1).B +
                              workImage.GetPixel(i - 1, j).B +
                              workImage.GetPixel(i + 1, j).B +
                              workImage.GetPixel(i - 1, j - 1).B +
                              workImage.GetPixel(i - 1, j + 1).B +
                              workImage.GetPixel(i + 1, j - 1).B +
                              workImage.GetPixel(i + 1, j + 1).B);
                    sumB += 9 * B;

                    if (sumB < 0)
                        sumB = 0;
                    else if (sumB > 255)
                        sumB = 255;

                    color = Color.FromArgb((byte)sumR, (byte)sumG, (byte)sumB);
                    workImage2.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage2.GetBitMap();
            workImage.Unlock();
            workImage2.Unlock();
        }
    }
}