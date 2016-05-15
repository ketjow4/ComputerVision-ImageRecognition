using RecognitionOfCapillaryNetworks.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

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

        private void filesListBox_Click(object sender, EventArgs e)
        {
            if(((ListBox)sender).SelectedItem!=null)
                pictureArea.Image = Image.FromFile(((ListBox)sender).SelectedItem.ToString());
        }

        private void loadImages()
        {
            filesListBox.Items.Clear();
            List<string> fName = manager.GetAllFilesNameFromDirectory();
            foreach(string path in fName)
            {
                filesListBox.Items.Add(path);
            }
            
        }
    }
}
