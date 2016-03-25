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
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.dirName = new System.Windows.Forms.Label();
            this.dirValue = new System.Windows.Forms.Label();
            this.dirChooserButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureArea
            // 
            this.pictureArea.Location = new System.Drawing.Point(12, 12);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(376, 514);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArea.TabIndex = 0;
            this.pictureArea.TabStop = false;
            // 
            // dirName
            // 
            this.dirName.AutoSize = true;
            this.dirName.Location = new System.Drawing.Point(394, 12);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(80, 13);
            this.dirName.TabIndex = 1;
            this.dirName.Text = "Aktualny folder:";
            // 
            // dirValue
            // 
            this.dirValue.AutoSize = true;
            this.dirValue.Location = new System.Drawing.Point(481, 11);
            this.dirValue.Name = "dirValue";
            this.dirValue.Size = new System.Drawing.Size(34, 13);
            this.dirValue.TabIndex = 2;
            this.dirValue.Text = "(brak)";
            // 
            // dirChooserButton
            // 
            this.dirChooserButton.Location = new System.Drawing.Point(484, 27);
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
            this.filesListBox.Location = new System.Drawing.Point(394, 67);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(301, 459);
            this.filesListBox.TabIndex = 6;
            this.filesListBox.Click += new System.EventHandler(this.filesListBox_Click);
            // 
            // GalleryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 538);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.dirChooserButton);
            this.Controls.Add(this.dirValue);
            this.Controls.Add(this.dirName);
            this.Controls.Add(this.pictureArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GalleryViewer";
            this.Text = "GalleryViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label dirName;
        private System.Windows.Forms.Label dirValue;
        private System.Windows.Forms.Button dirChooserButton;
        private System.Windows.Forms.ListBox filesListBox;
    }
}