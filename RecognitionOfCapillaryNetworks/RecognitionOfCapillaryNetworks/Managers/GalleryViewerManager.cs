using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecognitionOfCapillaryNetworks.Managers
{
    public class GalleryViewerManager
    {
        private String directory;

        /// <summary>
        /// Obsługiwane zakonczenia plikow z obrazami
        /// </summary>
        private string fileFilter = "*.jpg|*.png|*.gif";

        public GalleryViewerManager()
        {
            
        }

        public List<string> GetAllFilesNameFromDirectory()
        {
            return GetFiles(FolderDirectory, fileFilter, SearchOption.TopDirectoryOnly)
                .ToList();
        }

        private string[] GetFiles(string SourceFolder, string Filter, SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return (string[])alFiles.ToArray(typeof(string));
        }

        public string FolderDirectory
        {
            get
            {
                return directory;
            }

            set
            {
                directory = value;
            }
        }
    }
}
