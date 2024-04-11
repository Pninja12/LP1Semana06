using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    /// <summary>
    /// Classe que cria cores, recebendo de 0 a 255 o vermelho, verde, azul
    /// e, caso seja necessário, a sua transparência
    /// </summary>
    public class Color
    {
        private byte red;
        private byte green;
        private byte Blue;
        private byte alpha;

        public byte Red()
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
        public byte Green()
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
        public byte Blue()
        {
            get
            {
                return Blue;
            }
            set
            {
                blue = value;
            }
        }

        public byte Alpha()
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }

        public byte GetGrey()
        {
            return Convert.ToByte((red + green + blue) / 3);
        }
    }
}