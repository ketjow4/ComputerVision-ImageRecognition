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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.segmentationButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DrawDetections = new System.Windows.Forms.CheckBox();
            this.UseManyClassifiers = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.threshold = new System.Windows.Forms.NumericUpDown();
            this.noiseFilter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxSizeBox = new System.Windows.Forms.TextBox();
            this.minSizeBox = new System.Windows.Forms.TextBox();
            this.minNeighborsBox = new System.Windows.Forms.TextBox();
            this.scaleFactorBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.specificityLabel = new System.Windows.Forms.Label();
            this.tpLabel = new System.Windows.Forms.Label();
            this.sensivityLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fpLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tnLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureArea
            // 
            this.pictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureArea.Location = new System.Drawing.Point(3, 3);
            this.pictureArea.Name = "pictureArea";
            this.tableLayoutPanel1.SetRowSpan(this.pictureArea, 2);
            this.pictureArea.Size = new System.Drawing.Size(387, 537);
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
            this.dirChooserButton.Location = new System.Drawing.Point(4, 67);
            this.dirChooserButton.Name = "dirChooserButton";
            this.dirChooserButton.Size = new System.Drawing.Size(75, 23);
            this.dirChooserButton.TabIndex = 5;
            this.dirChooserButton.Text = "Wybierz";
            this.dirChooserButton.UseVisualStyleBackColor = true;
            this.dirChooserButton.Click += new System.EventHandler(this.dirChooserButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(4, 96);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(301, 433);
            this.filesListBox.TabIndex = 6;
            this.filesListBox.Click += new System.EventHandler(this.filesListBox_Click);
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // RecognizeButton
            // 
            this.RecognizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecognizeButton.Location = new System.Drawing.Point(85, 67);
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
            this.LoadHaarButton.Location = new System.Drawing.Point(167, 67);
            this.LoadHaarButton.Name = "LoadHaarButton";
            this.LoadHaarButton.Size = new System.Drawing.Size(138, 23);
            this.LoadHaarButton.TabIndex = 8;
            this.LoadHaarButton.Text = "Załaduj klasyfikator";
            this.LoadHaarButton.UseVisualStyleBackColor = true;
            this.LoadHaarButton.Click += new System.EventHandler(this.LoadHaarButton_Click);
            // 
            // processPictureBox
            // 
            this.processPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processPictureBox.Location = new System.Drawing.Point(396, 3);
            this.processPictureBox.Name = "processPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.processPictureBox, 2);
            this.processPictureBox.Size = new System.Drawing.Size(387, 537);
            this.processPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processPictureBox.TabIndex = 9;
            this.processPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.segmentationButton);
            this.groupBox2.Controls.Add(this.LoadHaarButton);
            this.groupBox2.Controls.Add(this.filesListBox);
            this.groupBox2.Controls.Add(this.dirValue);
            this.groupBox2.Controls.Add(this.dirChooserButton);
            this.groupBox2.Controls.Add(this.dirName);
            this.groupBox2.Controls.Add(this.RecognizeButton);
            this.groupBox2.Location = new System.Drawing.Point(999, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(311, 537);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sterowanie plikami";
            // 
            // segmentationButton
            // 
            this.segmentationButton.Location = new System.Drawing.Point(4, 38);
            this.segmentationButton.Name = "segmentationButton";
            this.segmentationButton.Size = new System.Drawing.Size(156, 23);
            this.segmentationButton.TabIndex = 12;
            this.segmentationButton.Text = "Oblicz miary jakości";
            this.segmentationButton.UseVisualStyleBackColor = true;
            this.segmentationButton.Click += new System.EventHandler(this.segmentationButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.DrawDetections);
            this.groupBox3.Controls.Add(this.UseManyClassifiers);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.threshold);
            this.groupBox3.Controls.Add(this.noiseFilter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maxSizeBox);
            this.groupBox3.Controls.Add(this.minSizeBox);
            this.groupBox3.Controls.Add(this.minNeighborsBox);
            this.groupBox3.Controls.Add(this.scaleFactorBox);
            this.groupBox3.Location = new System.Drawing.Point(789, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 346);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sterowanie parametrami";
            // 
            // DrawDetections
            // 
            this.DrawDetections.AutoSize = true;
            this.DrawDetections.Location = new System.Drawing.Point(6, 281);
            this.DrawDetections.Name = "DrawDetections";
            this.DrawDetections.Size = new System.Drawing.Size(130, 17);
            this.DrawDetections.TabIndex = 25;
            this.DrawDetections.Text = "Rysuj wykryte obszary";
            this.DrawDetections.UseVisualStyleBackColor = true;
            // 
            // UseManyClassifiers
            // 
            this.UseManyClassifiers.AutoSize = true;
            this.UseManyClassifiers.Location = new System.Drawing.Point(6, 257);
            this.UseManyClassifiers.Name = "UseManyClassifiers";
            this.UseManyClassifiers.Size = new System.Drawing.Size(143, 17);
            this.UseManyClassifiers.TabIndex = 24;
            this.UseManyClassifiers.Text = "Użyj wielu klasyfikatorów";
            this.UseManyClassifiers.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Wartość progowa czerni";
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(6, 230);
            this.threshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(193, 20);
            this.threshold.TabIndex = 22;
            this.threshold.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // noiseFilter
            // 
            this.noiseFilter.AutoSize = true;
            this.noiseFilter.Checked = true;
            this.noiseFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noiseFilter.Location = new System.Drawing.Point(6, 194);
            this.noiseFilter.Name = "noiseFilter";
            this.noiseFilter.Size = new System.Drawing.Size(103, 17);
            this.noiseFilter.TabIndex = 21;
            this.noiseFilter.Text = "Filtracja szumów";
            this.noiseFilter.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Minimalny rozmiar";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Współczynnik skali";
            // 
            // maxSizeBox
            // 
            this.maxSizeBox.Location = new System.Drawing.Point(6, 168);
            this.maxSizeBox.Name = "maxSizeBox";
            this.maxSizeBox.Size = new System.Drawing.Size(205, 20);
            this.maxSizeBox.TabIndex = 16;
            this.maxSizeBox.Text = "200";
            // 
            // minSizeBox
            // 
            this.minSizeBox.Location = new System.Drawing.Point(6, 129);
            this.minSizeBox.Name = "minSizeBox";
            this.minSizeBox.Size = new System.Drawing.Size(205, 20);
            this.minSizeBox.TabIndex = 15;
            this.minSizeBox.Text = "10";
            // 
            // minNeighborsBox
            // 
            this.minNeighborsBox.Location = new System.Drawing.Point(6, 90);
            this.minNeighborsBox.Name = "minNeighborsBox";
            this.minNeighborsBox.Size = new System.Drawing.Size(205, 20);
            this.minNeighborsBox.TabIndex = 14;
            this.minNeighborsBox.Text = "1";
            // 
            // scaleFactorBox
            // 
            this.scaleFactorBox.Location = new System.Drawing.Point(6, 51);
            this.scaleFactorBox.Name = "scaleFactorBox";
            this.scaleFactorBox.Size = new System.Drawing.Size(205, 20);
            this.scaleFactorBox.TabIndex = 13;
            this.scaleFactorBox.Text = "1,1";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.specificityLabel);
            this.groupBox4.Controls.Add(this.tpLabel);
            this.groupBox4.Controls.Add(this.sensivityLabel);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.fnLabel);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.fpLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tnLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(789, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 185);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miary jakości segmentacji";
            // 
            // specificityLabel
            // 
            this.specificityLabel.AutoSize = true;
            this.specificityLabel.Location = new System.Drawing.Point(91, 136);
            this.specificityLabel.Name = "specificityLabel";
            this.specificityLabel.Size = new System.Drawing.Size(28, 13);
            this.specificityLabel.TabIndex = 11;
            this.specificityLabel.Text = "brak";
            // 
            // tpLabel
            // 
            this.tpLabel.AutoSize = true;
            this.tpLabel.Location = new System.Drawing.Point(91, 71);
            this.tpLabel.Name = "tpLabel";
            this.tpLabel.Size = new System.Drawing.Size(28, 13);
            this.tpLabel.TabIndex = 10;
            this.tpLabel.Text = "brak";
            // 
            // sensivityLabel
            // 
            this.sensivityLabel.AutoSize = true;
            this.sensivityLabel.Location = new System.Drawing.Point(91, 123);
            this.sensivityLabel.Name = "sensivityLabel";
            this.sensivityLabel.Size = new System.Drawing.Size(28, 13);
            this.sensivityLabel.TabIndex = 9;
            this.sensivityLabel.Text = "brak";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Specyficzność:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Wrażliwość:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "FN:";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(91, 110);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(28, 13);
            this.fnLabel.TabIndex = 5;
            this.fnLabel.Text = "brak";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "FP:";
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.Location = new System.Drawing.Point(91, 97);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(28, 13);
            this.fpLabel.TabIndex = 3;
            this.fpLabel.Text = "brak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "TN:";
            // 
            // tnLabel
            // 
            this.tnLabel.AutoSize = true;
            this.tnLabel.Location = new System.Drawing.Point(91, 84);
            this.tnLabel.Name = "tnLabel";
            this.tnLabel.Size = new System.Drawing.Size(28, 13);
            this.tnLabel.TabIndex = 1;
            this.tnLabel.Text = "brak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TP:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.processPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1313, 543);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // GalleryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1313, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1329, 581);
            this.Name = "GalleryViewer";
            this.Text = "GalleryViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label specificityLabel;
        private System.Windows.Forms.Label tpLabel;
        private System.Windows.Forms.Label sensivityLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fpLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tnLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button segmentationButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown threshold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox DrawDetections;
        private System.Windows.Forms.CheckBox UseManyClassifiers;
    }
}