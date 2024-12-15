using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_1262774
{
    class SubjectMyImage : ISubjectMyImage
    {
        Bitmap bmp = null;
        Size sz;
        string shortName = "";
        string fileName;
        string category = "";
        public SubjectMyImage(string filename, string sName, string cat)
        {
            fileName = filename;
            category = cat;
            shortName = sName;
            bmp = new Bitmap(Image.FromFile(filename));
            sz = new Size(bmp.Width, bmp.Height);
        }

        public string ShortName
        {
            get { return shortName; }
        }

        public string GetFileName()
        {
            return fileName;
        }
        public string Category
        {
            get { return category; }
        }

        public Bitmap GetBitmap()
        {
            return bmp;
        }
        public Size GetImageSize()
        {
            return sz;
        }
    }
}
