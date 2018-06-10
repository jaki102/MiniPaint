using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPlugin;

namespace RotatingPlugin
{
    public class Rotating : IPlugin.IPlugin
    {
        public string getName()
        {
            return "Rotating";
        }

        public void run(Bitmap image)
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
    }
}
