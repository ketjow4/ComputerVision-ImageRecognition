using RecognitionOfCapillaryNetworks.Managers;
using RecognitionOfCapillaryNetworks.SingletonClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace RecognitionOfCapillaryNetworks.Forms
{
    public partial class GalleryViewer : Form
    {
        private FolderBrowserDialog folderBrowserDialog;

        private GalleryViewerManager manager;
        

        public GalleryViewer()
        {
            manager = new GalleryViewerManager();
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            InitializeComponent();
            threshold.Value = 40;
            
#if DEBUG
            pictureArea.Image = Image.FromFile(@"..\..\..\Content\len_full.jpg");

            processPictureBox.Image = Image.FromFile(@"..\..\..\Content\lena.jpg");
#endif

        }

        #region dirChooserButton

        private void dirChooserButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                manager.FolderDirectory = folderBrowserDialog.SelectedPath;
                dirValue.Text = manager.FolderDirectory;
                loadImages();
            }
            else
            {

            }
        }

        #endregion

        #region filesListBox

        private void filesListBox_Click(object sender, EventArgs e)
        {
            if(((ListBox)sender).SelectedItem!=null)
                pictureArea.Image = Image.FromFile(((ListBox)sender).SelectedItem.ToString());
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
                pictureArea.Image = Image.FromFile(((ListBox)sender).SelectedItem.ToString());
        }

        #endregion

        #region RecognizeButton

        private void RecognizeButton_Click(object sender, EventArgs e)
        {
            //Mat a = BitmapToMat(new Bitmap(pictureArea.Image));
            try
            {
                int detection;
                int scaleFactor, minNeighbors, minSize, maxSize;
                int.TryParse(scaleFactorBox.Text,out scaleFactor);
                int.TryParse(minNeighborsBox.Text, out minNeighbors);
                int.TryParse(minSizeBox.Text, out minSize);
                int.TryParse(maxSizeBox.Text, out maxSize);

                pictureArea.Image = HaarClassifierClass.Instance.DetectUsingCurrendClassifier(new Bitmap(pictureArea.Image),
                    scaleFactor, minNeighbors, minSize, maxSize, noiseFilter.Checked,
                    out detection).ToBitmap();
#if DEBUG
                MessageBox.Show("Found: " + detection.ToString() + " features");
#endif
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debugger.Log(1, "Exception", "Złapano wyjątek: " + ex.Message);
            }
        }

        #endregion

        #region LoadHaarButton

        private void LoadHaarButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "*.xml|*.xml";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HaarClassifierClass.Instance.ClassifierPath = ofd.FileName;
            }
        }

        #endregion

        private void loadImages()
        {
            filesListBox.Items.Clear();
            List<string> fName = manager.GetAllFilesNameFromDirectory();
            foreach (string path in fName)
            {
                filesListBox.Items.Add(path); 
            }

        }

        Bitmap MatToBitmap(Mat srcImg)
        {
            return srcImg.Bitmap;
        }

        private void segmentationButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "*.jpg|*.jpg|*.png|*.png|*.gif|*.gif|*.tif|*.tif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap masterImage = (Bitmap)Image.FromFile(ofd.FileName);
                Image<Gray, Byte> normalizedMasterImage = new Image<Gray, Byte>(masterImage);

                Bitmap processImage = (Bitmap)processPictureBox.Image;
                Image<Gray, Byte> normalizedProcessImage = new Image<Gray, Byte>(processImage);

                var result = QualityManager.ComputeQualityOfImages(normalizedMasterImage, normalizedProcessImage, threshold.Value);
                SetQualityInformationLables(result);

            }
        }

        private void SetQualityInformationLables(QualityResult info)
        {
            tpLabel.Text = info.TruePositives.ToString();
            tnLabel.Text = info.TrueNegatives.ToString();
            fpLabel.Text = info.FalsePositives.ToString();
            fnLabel.Text = info.FalseNegatives.ToString();
            sensivityLabel.Text = info.Sensivity.ToString();
            specificityLabel.Text = info.Specificity.ToString();
        }
    }
}
