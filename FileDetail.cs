using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class FileDetail
    {
        string fileName;
        string fileDirectory;

        private static int index;
        private static int[] ItemNo ;

        public static int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public FileDetail(string fileName,string fileDirectory)
        {
            this.fileName = fileName;
            this.fileDirectory = fileDirectory;
            index++;
        }
       
    }
}
