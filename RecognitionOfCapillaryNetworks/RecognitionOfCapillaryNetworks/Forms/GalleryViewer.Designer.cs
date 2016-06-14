namespace RecognitionOfCapillaryNetworks.Forms
{
    partial class GalleryViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryViewer));
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.dirName = new System.Windows.Forms.Label();
            this.dirValue = new System.Windows.Forms.Label();
            this.dirChooserButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.RecognizeButton = new System.Windows.Forms.Button();
            this.LoadHaarButton = new System.Windows.Forms.Button();
            this.processPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scaleFactorBox = new System.Windows.Forms.TextBox();
            this.minNeighborsBox = new System.Windows.Forms.TextBox();
            this.minSizeBox = new System.Windows.Forms.TextBox();
            this.maxSizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noiseFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureArea
            // 
            this.pictureArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureArea.Location = new System.Drawing.Point(6, 19);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(384, 517);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureArea.TabIndex = 0;
            this.pictureArea.TabStop = false;
            // 
            // dirName
            // 
            this.dirName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dirName.AutoSize = true;
            this.dirName.Location = new System.Drawing.Point(6, 16);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(80, 13);
            this.dirName.TabIndex = 1;
            this.dirName.Text = "Aktualny folder:";
            // 
            // dirValue
            // 
            this.dirValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dirValue.AutoSize = true;
            this.dirValue.Location = new System.Drawing.Point(92, 16);
            this.dirValue.Name = "dirValue";
            this.dirValue.Size = new System.Drawing.Size(34, 13);
            this.dirValue.TabIndex = 2;
            this.dirValue.Text = "(brak)";
            // 
            // dirChooserButton
            // 
            this.dirChooserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dirChooserButton.Location = new System.Drawing.Point(16, 67);
            this.dirChooserButton.Name = "dirChooserButton";
            this.dirChooserButton.Size = new System.Drawing.Size(75, 23);
            this.dirChooserButton.TabIndex = 5;
            this.dirChooserButton.Text = "Wybierz";
            this.dirChooserButton.UseVisualStyleBackColor = true;
            this.dirChooserButton.Click += new System.EventHandler(this.dirChooserButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(16, 96);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(301, 420);
            this.filesListBox.TabIndex = 6;
            this.filesListBox.Click += new System.EventHandler(this.filesListBox_Click);
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // RecognizeButton
            // 
            this.RecognizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecognizeButton.Location = new System.Drawing.Point(97, 67);
            this.RecognizeButton.Name = "RecognizeButton";
            this.RecognizeButton.Size = new System.Drawing.Size(75, 23);
            this.RecognizeButton.TabIndex = 7;
            this.RecognizeButton.Text = "Rozpoznaj";
            this.RecognizeButton.UseVisualStyleBackColor = true;
            this.RecognizeButton.Click += new System.EventHandler(this.RecognizeButton_Click);
            // 
            // LoadHaarButton
            // 
            this.LoadHaarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadHaarButton.Location = new System.Drawing.Point(179, 67);
            this.LoadHaarButton.Name = "LoadHaarButton";
            this.LoadHaarButton.Size = new System.Drawing.Size(138, 23);
            this.LoadHaarButton.TabIndex = 8;
            this.LoadHaarButton.Text = "Załaduj klasyfikator";
            this.LoadHaarButton.UseVisualStyleBackColor = true;
            this.LoadHaarButton.Click += new System.EventHandler(this.LoadHaarButton_Click);
            // 
            // processPictureBox
            // 
            this.processPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processPictureBox.Location = new System.Drawing.Point(396, 19);
            this.processPictureBox.Name = "processPictureBox";
            this.processPictureBox.Size = new System.Drawing.Size(365, 517);
            this.processPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processPictureBox.TabIndex = 9;
            this.processPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureArea);
            this.groupBox1.Controls.Add(this.processPictureBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 542);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrazy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoadHaarButton);
            this.groupBox2.Controls.Add(this.filesListBox);
            this.groupBox2.Controls.Add(this.dirValue);
            this.groupBox2.Controls.Add(this.dirChooserButton);
            this.groupBox2.Controls.Add(this.dirName);
            this.groupBox2.Controls.Add(this.RecognizeButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(990, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 542);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.noiseFilter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maxSizeBox);
            this.groupBox3.Controls.Add(this.minSizeBox);
            this.groupBox3.Controls.Add(this.minNeighborsBox);
            this.groupBox3.Controls.Add(this.scaleFactorBox);
            this.groupBox3.Location = new System.Drawing.Point(767, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 542);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sterowanie parametrami";
            // 
            // scaleFactorBox
            // 
            this.scaleFactorBox.Location = new System.Drawing.Point(6, 51);
            this.scaleFactorBox.Name = "scaleFactorBox";
            this.scaleFactorBox.Size = new System.Drawing.Size(205, 20);
            this.scaleFactorBox.TabIndex = 13;
            // 
            // minNeighborsBox
            // 
            this.minNeighborsBox.Location = new System.Drawing.Point(6, 90);
            this.minNeighborsBox.Name = "minNeighborsBox";
            this.minNeighborsBox.Size = new System.Drawing.Size(205, 20);
            this.minNeighborsBox.TabIndex = 14;
            // 
            // minSizeBox
            // 
            this.minSizeBox.Location = new System.Drawing.Point(6, 129);
            this.minSizeBox.Name = "minSizeBox";
            this.minSizeBox.Size = new System.Drawing.Size(205, 20);
            this.minSizeBox.TabIndex = 15;
            // 
            // maxSizeBox
            // 
            this.maxSizeBox.Location = new System.Drawing.Point(6, 168);
            this.maxSizeBox.Name = "maxSizeBox";
            this.maxSizeBox.Size = new System.Drawing.Size(205, 20);
            this.maxSizeBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Współczynnik skali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Minimalni sąsiedzi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Minimalny rozmiar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Maksymalny rozmiar";
            // 
            // noiseFilter
            // 
            this.noiseFilter.AutoSize = true;
            this.noiseFilter.Location = new System.Drawing.Point(6, 194);
            this.noiseFilter.Name = "noiseFilter";
            this.noiseFilter.Size = new System.Drawing.Size(103, 17);
            this.noiseFilter.TabIndex = 21;
            this.noiseFilter.Text = "Filtracja szumów";
            this.noiseFilter.UseVisualStyleBackColor = true;
            // 
            // GalleryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1313, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(723, 577);
            this.Name = "GalleryViewer";
            this.Text = "GalleryViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label dirName;
        private System.Windows.Forms.Label dirValue;
        private System.Windows.Forms.Button dirChooserButton;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button RecognizeButton;
        private System.Windows.Forms.Button LoadHaarButton;
        private System.Windows.Forms.PictureBox processPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxSizeBox;
        private System.Windows.Forms.TextBox minSizeBox;
        private System.Windows.Forms.TextBox minNeighborsBox;
        private System.Windows.Forms.TextBox scaleFactorBox;
        private System.Windows.Forms.CheckBox noiseFilter;
    }
}