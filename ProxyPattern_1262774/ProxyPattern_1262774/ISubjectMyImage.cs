using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_1262774
{
    interface ISubjectMyImage
    {
        string ShortName { get; }
        string Category { get; }
        string GetFileName();
        Bitmap GetBitmap();
        Size GetImageSize();
    }
 
}
