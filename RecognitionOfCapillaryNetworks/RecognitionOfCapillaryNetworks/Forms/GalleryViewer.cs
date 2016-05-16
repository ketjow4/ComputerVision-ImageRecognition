using RecognitionOfCapillaryNetworks.Managers;
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

        private static readonly CascadeClassifier Classifier = new CascadeClassifier(@"..\..\..\HaarClassifiers\haarcascade_frontalface_alt_tree.xml");

        public GalleryViewer()
        {
            manager = new GalleryViewerManager();
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            InitializeComponent();

#if DEBUG
            pictureArea.Image = Image.FromFile(@"..\..\..\Content\len_full.jpg");
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
                Image<Bgr, Byte> img = new Image<Bgr, Byte>(new Bitmap(pictureArea.Image));
                Image<Gray, byte> grayImage = img.Convert<Gray, byte>();

                var b = Classifier.DetectMultiScale(grayImage, 1.05, 3, new Size(20, 20), new Size(grayImage.Width, grayImage.Height));

                foreach (var rect in b)
                {
                    img.Draw(rect, new Bgr(Color.FromArgb(255, 0, 0)), 5);
                }
                pictureArea.Image = img.ToBitmap();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debugger.Log(1, "Exception", "Złapano wyjątek: " + ex.Message);
            }
        }

        #endregion

        #region LoadHaarButton

        #warning To coś w ogole robi?
        private void LoadHaarButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "*.xml|*.xml";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            //string directoryPath = Path.GetDirectoryName(ofd.FileName);
            
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

        System.Drawing.Bitmap MatToBitmap(Mat srcImg)
        {
            return srcImg.Bitmap;
        }
    }
}
