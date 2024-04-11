using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    /// <summary>
    /// Classe que cria bolas, recebendo a sua cor e o seu raio
    /// </summary>
    public class Sphere
    {
        private int raio;
        private int vezesatirado;

        public Sphere(Color cor, int raio)
        {
            this.cor = cor;
            this.raio = raio;
            vezesatirado = 0;
        }

        public Color cor
        {
            get
            {
                return cor;
            }
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio > 0)
            {
                vezesatirado += 1;
            }
        }

        public int GetTimesThrown()
        {
            return vezesatirado;
        }

        public int GetRaio()
        {
            return raio;
        }
        public string GetCor()
        {
            string texto = $"({cor.GetRed()},{cor.GetGreen()},"
            +$"{cor.GetBlue()},{cor.GetAlpha()})";
            return texto;
        }
    }
}