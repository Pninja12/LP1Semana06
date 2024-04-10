using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    /// <summary>
    /// Classe que criar cores, recebendo de 0 a 255 o vermelho, verde, azul
    /// e, caso seja necessário, a sua transparência
    /// </summary>
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

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

        public void SetRed(byte newred)
        {
            red = newred;
        }

        public void SetBlue(byte newblue)
        {
            blue = newblue;
        }
        public void SetGreen(byte newgreen)
        {
            green = newgreen;
        }
        public void SetAlpha(byte newalpha)
        {
            alpha = newalpha;
        }
    }
}