using RecognitionOfCapillaryNetworks.Managers;
using RecognitionOfCapillaryNetworks.SingletonClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;


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
                pictureArea.Image = HaarClassifierClass.Instance.DetectUsingCurrendClassifier(new Bitmap(pictureArea.Image),out detection).ToBitmap();
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
    }
}
