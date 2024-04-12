using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    /// <summary>
    /// Classe que cria cores, recebendo de 0 a 255 o vermelho, verde, azul
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

        public byte Red{get; set; }
        public byte Green{get; set; }
        public byte Blue{get; set; }
        public byte Alpha{get; set; }

        public byte GetGrey()
        {
            return Convert.ToByte((red + green + blue) / 3);
        }
    }
}