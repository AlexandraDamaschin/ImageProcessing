namespace ComputerVision
{
    partial class MainForm
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
            this.panelSource = new System.Windows.Forms.Panel();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_corelation = new System.Windows.Forms.Button();
            this.textBox_pragSplit = new System.Windows.Forms.TextBox();
            this.button_split = new System.Windows.Forms.Button();
            this.button_Gabor = new System.Windows.Forms.Button();
            this.button_Frei_Chen = new System.Windows.Forms.Button();
            this.button_Sobel = new System.Windows.Forms.Button();
            this.button_Kirsch = new System.Windows.Forms.Button();
            this.button_unsharpMasking = new System.Windows.Forms.Button();
            this.button_FTS = new System.Windows.Forms.Button();
            this.button_filtruZgomot = new System.Windows.Forms.Button();
            this.button_median = new System.Windows.Forms.Button();
            this.button_pseudomedian = new System.Windows.Forms.Button();
            this.textBox_outlier = new System.Windows.Forms.TextBox();
            this.button_Outlier = new System.Windows.Forms.Button();
            this.textBox_FTJ = new System.Windows.Forms.TextBox();
            this.button_FTJ = new System.Windows.Forms.Button();
            this.textBox_Rotatie = new System.Windows.Forms.TextBox();
            this.button_Rotatia = new System.Windows.Forms.Button();
            this.button_Micsorare = new System.Windows.Forms.Button();
            this.button_Marire = new System.Windows.Forms.Button();
            this.button_translatiaY = new System.Windows.Forms.Button();
            this.button_translatiaX = new System.Windows.Forms.Button();
            this.button_reflexia = new System.Windows.Forms.Button();
            this.button_egalizare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2_contrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1_luminozitate = new System.Windows.Forms.TrackBar();
            this.button_negativizare = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_LoadSecondImage = new System.Windows.Forms.Button();
            this.button_BlockMatching = new System.Windows.Forms.Button();
            this.textBox_SearchSize = new System.Windows.Forms.TextBox();
            this.textBox_dimension = new System.Windows.Forms.TextBox();
            this.button_translation_afina = new System.Windows.Forms.Button();
            this.textBox_trans_afinaB1 = new System.Windows.Forms.TextBox();
            this.textBox_trans_afinaB2 = new System.Windows.Forms.TextBox();
            this.button_rotation_afina = new System.Windows.Forms.Button();
            this.textBox_tetha_afina = new System.Windows.Forms.TextBox();
            this.button_scalation_afina = new System.Windows.Forms.Button();
            this.textBox_scalation_afinaA11 = new System.Windows.Forms.TextBox();
            this.textBox_scalation_afinaA22 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_luminozitate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(18, 18);
            this.panelSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(478, 367);
            this.panelSource.TabIndex = 0;
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDestination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDestination.Location = new System.Drawing.Point(522, 18);
            this.panelDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(478, 367);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(18, 675);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(112, 35);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_corelation);
            this.panel1.Controls.Add(this.textBox_pragSplit);
            this.panel1.Controls.Add(this.button_split);
            this.panel1.Controls.Add(this.button_Gabor);
            this.panel1.Controls.Add(this.button_Frei_Chen);
            this.panel1.Controls.Add(this.button_Sobel);
            this.panel1.Controls.Add(this.button_Kirsch);
            this.panel1.Controls.Add(this.button_unsharpMasking);
            this.panel1.Controls.Add(this.button_FTS);
            this.panel1.Controls.Add(this.button_filtruZgomot);
            this.panel1.Controls.Add(this.button_median);
            this.panel1.Controls.Add(this.button_pseudomedian);
            this.panel1.Controls.Add(this.textBox_outlier);
            this.panel1.Controls.Add(this.button_Outlier);
            this.panel1.Controls.Add(this.textBox_FTJ);
            this.panel1.Controls.Add(this.button_FTJ);
            this.panel1.Controls.Add(this.textBox_Rotatie);
            this.panel1.Controls.Add(this.button_Rotatia);
            this.panel1.Controls.Add(this.button_Micsorare);
            this.panel1.Controls.Add(this.button_Marire);
            this.panel1.Controls.Add(this.button_translatiaY);
            this.panel1.Controls.Add(this.button_translatiaX);
            this.panel1.Controls.Add(this.button_reflexia);
            this.panel1.Controls.Add(this.button_egalizare);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar2_contrast);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1_luminozitate);
            this.panel1.Controls.Add(this.button_negativizare);
            this.panel1.Controls.Add(this.buttonGrayscale);
            this.panel1.Location = new System.Drawing.Point(522, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 291);
            this.panel1.TabIndex = 3;
            // 
            // button_corelation
            // 
            this.button_corelation.Location = new System.Drawing.Point(868, 238);
            this.button_corelation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_corelation.Name = "button_corelation";
            this.button_corelation.Size = new System.Drawing.Size(127, 35);
            this.button_corelation.TabIndex = 42;
            this.button_corelation.Text = "Corelation";
            this.button_corelation.UseVisualStyleBackColor = true;
            this.button_corelation.Click += new System.EventHandler(this.button_corelation_Click);
            // 
            // textBox_pragSplit
            // 
            this.textBox_pragSplit.Location = new System.Drawing.Point(868, 176);
            this.textBox_pragSplit.Name = "textBox_pragSplit";
            this.textBox_pragSplit.Size = new System.Drawing.Size(127, 26);
            this.textBox_pragSplit.TabIndex = 41;
            // 
            // button_split
            // 
            this.button_split.Location = new System.Drawing.Point(868, 112);
            this.button_split.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_split.Name = "button_split";
            this.button_split.Size = new System.Drawing.Size(127, 35);
            this.button_split.TabIndex = 40;
            this.button_split.Text = "Split by:";
            this.button_split.UseVisualStyleBackColor = true;
            this.button_split.Click += new System.EventHandler(this.button_split_Click);
            // 
            // button_Gabor
            // 
            this.button_Gabor.Location = new System.Drawing.Point(868, 64);
            this.button_Gabor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Gabor.Name = "button_Gabor";
            this.button_Gabor.Size = new System.Drawing.Size(127, 35);
            this.button_Gabor.TabIndex = 39;
            this.button_Gabor.Text = "Gabor";
            this.button_Gabor.UseVisualStyleBackColor = true;
            this.button_Gabor.Click += new System.EventHandler(this.button_Gabor_Click);
            // 
            // button_Frei_Chen
            // 
            this.button_Frei_Chen.Location = new System.Drawing.Point(868, 15);
            this.button_Frei_Chen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Frei_Chen.Name = "button_Frei_Chen";
            this.button_Frei_Chen.Size = new System.Drawing.Size(127, 35);
            this.button_Frei_Chen.TabIndex = 38;
            this.button_Frei_Chen.Text = " Frei-Chen";
            this.button_Frei_Chen.UseVisualStyleBackColor = true;
            this.button_Frei_Chen.Click += new System.EventHandler(this.button_Frei_Chen_Click);
            // 
            // button_Sobel
            // 
            this.button_Sobel.Location = new System.Drawing.Point(717, 112);
            this.button_Sobel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Sobel.Name = "button_Sobel";
            this.button_Sobel.Size = new System.Drawing.Size(127, 35);
            this.button_Sobel.TabIndex = 37;
            this.button_Sobel.Text = "Sobel";
            this.button_Sobel.UseVisualStyleBackColor = true;
            this.button_Sobel.Click += new System.EventHandler(this.button_Sobel_Click);
            // 
            // button_Kirsch
            // 
            this.button_Kirsch.Location = new System.Drawing.Point(717, 60);
            this.button_Kirsch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Kirsch.Name = "button_Kirsch";
            this.button_Kirsch.Size = new System.Drawing.Size(127, 35);
            this.button_Kirsch.TabIndex = 36;
            this.button_Kirsch.Text = "Kirsch";
            this.button_Kirsch.UseVisualStyleBackColor = true;
            this.button_Kirsch.Click += new System.EventHandler(this.button_Kirsch_Click);
            // 
            // button_unsharpMasking
            // 
            this.button_unsharpMasking.Location = new System.Drawing.Point(717, 15);
            this.button_unsharpMasking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_unsharpMasking.Name = "button_unsharpMasking";
            this.button_unsharpMasking.Size = new System.Drawing.Size(127, 35);
            this.button_unsharpMasking.TabIndex = 35;
            this.button_unsharpMasking.Text = "Unsharp Masking";
            this.button_unsharpMasking.UseVisualStyleBackColor = true;
            this.button_unsharpMasking.Click += new System.EventHandler(this.button_unsharpMasking_Click);
            // 
            // button_FTS
            // 
            this.button_FTS.Location = new System.Drawing.Point(717, 238);
            this.button_FTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FTS.Name = "button_FTS";
            this.button_FTS.Size = new System.Drawing.Size(127, 35);
            this.button_FTS.TabIndex = 34;
            this.button_FTS.Text = "Filtru FTS";
            this.button_FTS.UseVisualStyleBackColor = true;
            this.button_FTS.Click += new System.EventHandler(this.button_FTS_Click);
            // 
            // button_filtruZgomot
            // 
            this.button_filtruZgomot.Location = new System.Drawing.Point(717, 176);
            this.button_filtruZgomot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_filtruZgomot.Name = "button_filtruZgomot";
            this.button_filtruZgomot.Size = new System.Drawing.Size(127, 35);
            this.button_filtruZgomot.TabIndex = 33;
            this.button_filtruZgomot.Text = "Filtru zgomot";
            this.button_filtruZgomot.UseVisualStyleBackColor = true;
            this.button_filtruZgomot.Click += new System.EventHandler(this.button_filtruZgomot_Click);
            // 
            // button_median
            // 
            this.button_median.Location = new System.Drawing.Point(566, 176);
            this.button_median.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_median.Name = "button_median";
            this.button_median.Size = new System.Drawing.Size(127, 35);
            this.button_median.TabIndex = 32;
            this.button_median.Text = "Median";
            this.button_median.UseVisualStyleBackColor = true;
            this.button_median.Click += new System.EventHandler(this.button_median_Click);
            // 
            // button_pseudomedian
            // 
            this.button_pseudomedian.Location = new System.Drawing.Point(566, 238);
            this.button_pseudomedian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_pseudomedian.Name = "button_pseudomedian";
            this.button_pseudomedian.Size = new System.Drawing.Size(127, 35);
            this.button_pseudomedian.TabIndex = 31;
            this.button_pseudomedian.Text = "Pseudomedian";
            this.button_pseudomedian.UseVisualStyleBackColor = true;
            this.button_pseudomedian.Click += new System.EventHandler(this.button_pseudomedian_Click);
            // 
            // textBox_outlier
            // 
            this.textBox_outlier.Location = new System.Drawing.Point(622, 116);
            this.textBox_outlier.Name = "textBox_outlier";
            this.textBox_outlier.Size = new System.Drawing.Size(56, 26);
            this.textBox_outlier.TabIndex = 30;
            // 
            // button_Outlier
            // 
            this.button_Outlier.Location = new System.Drawing.Point(486, 112);
            this.button_Outlier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Outlier.Name = "button_Outlier";
            this.button_Outlier.Size = new System.Drawing.Size(112, 35);
            this.button_Outlier.TabIndex = 29;
            this.button_Outlier.Text = "Outlier";
            this.button_Outlier.UseVisualStyleBackColor = true;
            this.button_Outlier.Click += new System.EventHandler(this.button_Outlier_Click);
            // 
            // textBox_FTJ
            // 
            this.textBox_FTJ.Location = new System.Drawing.Point(622, 64);
            this.textBox_FTJ.Name = "textBox_FTJ";
            this.textBox_FTJ.Size = new System.Drawing.Size(56, 26);
            this.textBox_FTJ.TabIndex = 28;
            // 
            // button_FTJ
            // 
            this.button_FTJ.Location = new System.Drawing.Point(486, 60);
            this.button_FTJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FTJ.Name = "button_FTJ";
            this.button_FTJ.Size = new System.Drawing.Size(112, 35);
            this.button_FTJ.TabIndex = 27;
            this.button_FTJ.Text = "FTJ";
            this.button_FTJ.UseVisualStyleBackColor = true;
            this.button_FTJ.Click += new System.EventHandler(this.button_FTJ_Click);
            // 
            // textBox_Rotatie
            // 
            this.textBox_Rotatie.Location = new System.Drawing.Point(622, 19);
            this.textBox_Rotatie.Name = "textBox_Rotatie";
            this.textBox_Rotatie.Size = new System.Drawing.Size(56, 26);
            this.textBox_Rotatie.TabIndex = 26;
            // 
            // button_Rotatia
            // 
            this.button_Rotatia.Location = new System.Drawing.Point(486, 15);
            this.button_Rotatia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Rotatia.Name = "button_Rotatia";
            this.button_Rotatia.Size = new System.Drawing.Size(112, 35);
            this.button_Rotatia.TabIndex = 25;
            this.button_Rotatia.Text = "Rotatia";
            this.button_Rotatia.UseVisualStyleBackColor = true;
            this.button_Rotatia.Click += new System.EventHandler(this.button_Rotatia_Click);
            // 
            // button_Micsorare
            // 
            this.button_Micsorare.Location = new System.Drawing.Point(425, 238);
            this.button_Micsorare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Micsorare.Name = "button_Micsorare";
            this.button_Micsorare.Size = new System.Drawing.Size(112, 35);
            this.button_Micsorare.TabIndex = 24;
            this.button_Micsorare.Text = "Micsorare";
            this.button_Micsorare.UseVisualStyleBackColor = true;
            this.button_Micsorare.Click += new System.EventHandler(this.button_Micsorare_Click);
            // 
            // button_Marire
            // 
            this.button_Marire.Location = new System.Drawing.Point(425, 176);
            this.button_Marire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Marire.Name = "button_Marire";
            this.button_Marire.Size = new System.Drawing.Size(112, 35);
            this.button_Marire.TabIndex = 23;
            this.button_Marire.Text = "Marire";
            this.button_Marire.UseVisualStyleBackColor = true;
            this.button_Marire.Click += new System.EventHandler(this.button_Marire_Click);
            // 
            // button_translatiaY
            // 
            this.button_translatiaY.Location = new System.Drawing.Point(289, 176);
            this.button_translatiaY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_translatiaY.Name = "button_translatiaY";
            this.button_translatiaY.Size = new System.Drawing.Size(112, 35);
            this.button_translatiaY.TabIndex = 22;
            this.button_translatiaY.Text = "TranslatiaY";
            this.button_translatiaY.UseVisualStyleBackColor = true;
            this.button_translatiaY.Click += new System.EventHandler(this.button_translatiaY_Click);
            // 
            // button_translatiaX
            // 
            this.button_translatiaX.Location = new System.Drawing.Point(289, 238);
            this.button_translatiaX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_translatiaX.Name = "button_translatiaX";
            this.button_translatiaX.Size = new System.Drawing.Size(112, 35);
            this.button_translatiaX.TabIndex = 21;
            this.button_translatiaX.Text = "TranslatiaX";
            this.button_translatiaX.UseVisualStyleBackColor = true;
            this.button_translatiaX.Click += new System.EventHandler(this.button_translatiaX_Click);
            // 
            // button_reflexia
            // 
            this.button_reflexia.Location = new System.Drawing.Point(146, 176);
            this.button_reflexia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_reflexia.Name = "button_reflexia";
            this.button_reflexia.Size = new System.Drawing.Size(112, 35);
            this.button_reflexia.TabIndex = 20;
            this.button_reflexia.Text = "Reflexia";
            this.button_reflexia.UseVisualStyleBackColor = true;
            this.button_reflexia.Click += new System.EventHandler(this.button_reflexia_Click);
            // 
            // button_egalizare
            // 
            this.button_egalizare.Location = new System.Drawing.Point(146, 238);
            this.button_egalizare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_egalizare.Name = "button_egalizare";
            this.button_egalizare.Size = new System.Drawing.Size(112, 35);
            this.button_egalizare.TabIndex = 19;
            this.button_egalizare.Text = "Egalizare";
            this.button_egalizare.UseVisualStyleBackColor = true;
            this.button_egalizare.Click += new System.EventHandler(this.button_egalizare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contrast";
            // 
            // trackBar2_contrast
            // 
            this.trackBar2_contrast.Location = new System.Drawing.Point(10, 78);
            this.trackBar2_contrast.Maximum = 120;
            this.trackBar2_contrast.Minimum = -120;
            this.trackBar2_contrast.Name = "trackBar2_contrast";
            this.trackBar2_contrast.Size = new System.Drawing.Size(450, 69);
            this.trackBar2_contrast.TabIndex = 17;
            this.trackBar2_contrast.Scroll += new System.EventHandler(this.trackBar2_contrast_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Luminozitate";
            // 
            // trackBar1_luminozitate
            // 
            this.trackBar1_luminozitate.Location = new System.Drawing.Point(10, 3);
            this.trackBar1_luminozitate.Maximum = 150;
            this.trackBar1_luminozitate.Minimum = -150;
            this.trackBar1_luminozitate.Name = "trackBar1_luminozitate";
            this.trackBar1_luminozitate.Size = new System.Drawing.Size(450, 69);
            this.trackBar1_luminozitate.TabIndex = 15;
            this.trackBar1_luminozitate.ValueChanged += new System.EventHandler(this.trackBar1_luminozitate_ValueChanged);
            // 
            // button_negativizare
            // 
            this.button_negativizare.Location = new System.Drawing.Point(10, 176);
            this.button_negativizare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_negativizare.Name = "button_negativizare";
            this.button_negativizare.Size = new System.Drawing.Size(112, 35);
            this.button_negativizare.TabIndex = 14;
            this.button_negativizare.Text = "Negativizare";
            this.button_negativizare.UseVisualStyleBackColor = true;
            this.button_negativizare.Click += new System.EventHandler(this.button_negativizare_Click);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Location = new System.Drawing.Point(10, 238);
            this.buttonGrayscale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(112, 35);
            this.buttonGrayscale.TabIndex = 13;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // button_LoadSecondImage
            // 
            this.button_LoadSecondImage.Location = new System.Drawing.Point(158, 675);
            this.button_LoadSecondImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_LoadSecondImage.Name = "button_LoadSecondImage";
            this.button_LoadSecondImage.Size = new System.Drawing.Size(169, 35);
            this.button_LoadSecondImage.TabIndex = 4;
            this.button_LoadSecondImage.Text = "Load Second Image";
            this.button_LoadSecondImage.UseVisualStyleBackColor = true;
            this.button_LoadSecondImage.Click += new System.EventHandler(this.button_LoadSecondImage_Click);
            // 
            // button_BlockMatching
            // 
            this.button_BlockMatching.Location = new System.Drawing.Point(353, 673);
            this.button_BlockMatching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_BlockMatching.Name = "button_BlockMatching";
            this.button_BlockMatching.Size = new System.Drawing.Size(132, 35);
            this.button_BlockMatching.TabIndex = 15;
            this.button_BlockMatching.Text = "BlockMatching";
            this.button_BlockMatching.UseVisualStyleBackColor = true;
            this.button_BlockMatching.Click += new System.EventHandler(this.button_BlockMatching_Click);
            // 
            // textBox_SearchSize
            // 
            this.textBox_SearchSize.Location = new System.Drawing.Point(359, 639);
            this.textBox_SearchSize.Name = "textBox_SearchSize";
            this.textBox_SearchSize.Size = new System.Drawing.Size(56, 26);
            this.textBox_SearchSize.TabIndex = 31;
            // 
            // textBox_dimension
            // 
            this.textBox_dimension.Location = new System.Drawing.Point(421, 639);
            this.textBox_dimension.Name = "textBox_dimension";
            this.textBox_dimension.Size = new System.Drawing.Size(56, 26);
            this.textBox_dimension.TabIndex = 32;
            // 
            // button_translation_afina
            // 
            this.button_translation_afina.Location = new System.Drawing.Point(353, 596);
            this.button_translation_afina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_translation_afina.Name = "button_translation_afina";
            this.button_translation_afina.Size = new System.Drawing.Size(132, 35);
            this.button_translation_afina.TabIndex = 33;
            this.button_translation_afina.Text = "Translation";
            this.button_translation_afina.UseVisualStyleBackColor = true;
            this.button_translation_afina.Click += new System.EventHandler(this.button_translation_afina_Click);
            // 
            // textBox_trans_afinaB1
            // 
            this.textBox_trans_afinaB1.Location = new System.Drawing.Point(359, 562);
            this.textBox_trans_afinaB1.Name = "textBox_trans_afinaB1";
            this.textBox_trans_afinaB1.Size = new System.Drawing.Size(56, 26);
            this.textBox_trans_afinaB1.TabIndex = 34;
            // 
            // textBox_trans_afinaB2
            // 
            this.textBox_trans_afinaB2.Location = new System.Drawing.Point(421, 562);
            this.textBox_trans_afinaB2.Name = "textBox_trans_afinaB2";
            this.textBox_trans_afinaB2.Size = new System.Drawing.Size(56, 26);
            this.textBox_trans_afinaB2.TabIndex = 35;
            // 
            // button_rotation_afina
            // 
            this.button_rotation_afina.Location = new System.Drawing.Point(353, 519);
            this.button_rotation_afina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_rotation_afina.Name = "button_rotation_afina";
            this.button_rotation_afina.Size = new System.Drawing.Size(132, 35);
            this.button_rotation_afina.TabIndex = 36;
            this.button_rotation_afina.Text = "Rotation";
            this.button_rotation_afina.UseVisualStyleBackColor = true;
            this.button_rotation_afina.Click += new System.EventHandler(this.button_rotation_afina_Click);
            // 
            // textBox_tetha_afina
            // 
            this.textBox_tetha_afina.Location = new System.Drawing.Point(359, 482);
            this.textBox_tetha_afina.Name = "textBox_tetha_afina";
            this.textBox_tetha_afina.Size = new System.Drawing.Size(118, 26);
            this.textBox_tetha_afina.TabIndex = 37;
            // 
            // button_scalation_afina
            // 
            this.button_scalation_afina.Location = new System.Drawing.Point(353, 439);
            this.button_scalation_afina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_scalation_afina.Name = "button_scalation_afina";
            this.button_scalation_afina.Size = new System.Drawing.Size(132, 35);
            this.button_scalation_afina.TabIndex = 38;
            this.button_scalation_afina.Text = "Scalation";
            this.button_scalation_afina.UseVisualStyleBackColor = true;
            this.button_scalation_afina.Click += new System.EventHandler(this.button_scalation_afina_Click);
            // 
            // textBox_scalation_afinaA11
            // 
            this.textBox_scalation_afinaA11.Location = new System.Drawing.Point(359, 405);
            this.textBox_scalation_afinaA11.Name = "textBox_scalation_afinaA11";
            this.textBox_scalation_afinaA11.Size = new System.Drawing.Size(56, 26);
            this.textBox_scalation_afinaA11.TabIndex = 39;
            // 
            // textBox_scalation_afinaA22
            // 
            this.textBox_scalation_afinaA22.Location = new System.Drawing.Point(421, 405);
            this.textBox_scalation_afinaA22.Name = "textBox_scalation_afinaA22";
            this.textBox_scalation_afinaA22.Size = new System.Drawing.Size(56, 26);
            this.textBox_scalation_afinaA22.TabIndex = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 728);
            this.Controls.Add(this.textBox_scalation_afinaA22);
            this.Controls.Add(this.textBox_scalation_afinaA11);
            this.Controls.Add(this.button_scalation_afina);
            this.Controls.Add(this.textBox_tetha_afina);
            this.Controls.Add(this.button_rotation_afina);
            this.Controls.Add(this.textBox_trans_afinaB2);
            this.Controls.Add(this.textBox_trans_afinaB1);
            this.Controls.Add(this.button_translation_afina);
            this.Controls.Add(this.textBox_dimension);
            this.Controls.Add(this.textBox_SearchSize);
            this.Controls.Add(this.button_BlockMatching);
            this.Controls.Add(this.button_LoadSecondImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_luminozitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGrayscale;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_negativizare;
        private System.Windows.Forms.TrackBar trackBar1_luminozitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2_contrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_egalizare;
        private System.Windows.Forms.Button button_reflexia;
        private System.Windows.Forms.Button button_translatiaX;
        private System.Windows.Forms.Button button_translatiaY;
        private System.Windows.Forms.Button button_Marire;
        private System.Windows.Forms.Button button_Micsorare;
        private System.Windows.Forms.Button button_Rotatia;
        private System.Windows.Forms.TextBox textBox_Rotatie;
        private System.Windows.Forms.Button button_FTJ;
        private System.Windows.Forms.TextBox textBox_FTJ;
        private System.Windows.Forms.Button button_Outlier;
        private System.Windows.Forms.TextBox textBox_outlier;
        private System.Windows.Forms.Button button_pseudomedian;
        private System.Windows.Forms.Button button_median;
        private System.Windows.Forms.Button button_filtruZgomot;
        private System.Windows.Forms.Button button_FTS;
        private System.Windows.Forms.Button button_unsharpMasking;
        private System.Windows.Forms.Button button_Kirsch;
        private System.Windows.Forms.Button button_Sobel;
        private System.Windows.Forms.Button button_Frei_Chen;
        private System.Windows.Forms.Button button_Gabor;
        private System.Windows.Forms.Button button_split;
        private System.Windows.Forms.TextBox textBox_pragSplit;
        private System.Windows.Forms.Button button_corelation;
        private System.Windows.Forms.Button button_LoadSecondImage;
        private System.Windows.Forms.Button button_BlockMatching;
        private System.Windows.Forms.TextBox textBox_SearchSize;
        private System.Windows.Forms.TextBox textBox_dimension;
        private System.Windows.Forms.Button button_translation_afina;
        private System.Windows.Forms.TextBox textBox_trans_afinaB1;
        private System.Windows.Forms.TextBox textBox_trans_afinaB2;
        private System.Windows.Forms.Button button_rotation_afina;
        private System.Windows.Forms.TextBox textBox_tetha_afina;
        private System.Windows.Forms.Button button_scalation_afina;
        private System.Windows.Forms.TextBox textBox_scalation_afinaA11;
        private System.Windows.Forms.TextBox textBox_scalation_afinaA22;
    }
}

