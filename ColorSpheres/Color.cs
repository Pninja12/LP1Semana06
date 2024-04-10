using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        byte red;
        byte green;
        byte blue;
        byte alpha;

        public Color(byte red, byte green,byte blue,byte alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        
        public byte GetRed()
        {
            return red;
        }

        public byte GetBlue()
        {
            return blue;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetAlpha()
        {
            return alpha;
        }

        public byte GetGrey()
        {
            return Convert.ToByte((red + green + blue) / 3);
        }
    }
}