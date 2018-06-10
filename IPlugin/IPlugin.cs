using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlugin
{
    public interface IPlugin
    {
        void run(Bitmap image);
        string getName();
    }
}
