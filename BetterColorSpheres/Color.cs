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
        private byte red{ get; set; };
        private byte green{ get; set; };
        private byte blue{ get; set; };
        private byte alpha{ get; set; };

        public Color(byte red, byte green,byte blue,byte alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public byte GetGrey()
        {
            return Convert.ToByte((red + green + blue) / 3);
        }
    }
}