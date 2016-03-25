using System;
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

        public GalleryViewerManager()
        {
            
        }

        public List<string> GetAllFilesNameFromDirectory()
        {
            return Directory.GetFiles(FolderDirectory, "*.*", SearchOption.AllDirectories)
                .ToList();
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
