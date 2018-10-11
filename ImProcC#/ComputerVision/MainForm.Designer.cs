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
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2_contrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1_luminozitate = new System.Windows.Forms.TrackBar();
            this.button_negativizare = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_egalizare = new System.Windows.Forms.Button();
            this.button_reflexia = new System.Windows.Forms.Button();
            this.button_translatia = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button_translatia);
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
            this.panel1.Size = new System.Drawing.Size(479, 291);
            this.panel1.TabIndex = 3;
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
            // button_translatia
            // 
            this.button_translatia.Location = new System.Drawing.Point(289, 238);
            this.button_translatia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_translatia.Name = "button_translatia";
            this.button_translatia.Size = new System.Drawing.Size(112, 35);
            this.button_translatia.TabIndex = 21;
            this.button_translatia.Text = "Translatia";
            this.button_translatia.UseVisualStyleBackColor = true;
            this.button_translatia.Click += new System.EventHandler(this.button_translatia_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 728);
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
        private System.Windows.Forms.Button button_translatia;
    }
}

