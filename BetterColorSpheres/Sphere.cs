using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    /// <summary>
    /// Classe que cria bolas, recebendo a sua cor e o seu raio
    /// </summary>
    public class Sphere
    {
        private int raio;
        private int vezesatirado;
        private Color cor;

        public Sphere(Color cor, int raio)
        {
            this.cor = cor;
            this.raio = raio;
            vezesatirado = 0;
        }

        public Color Cor
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
            string texto = $"({cor.Red},{cor.Green},"
            +$"{cor.Blue},{cor.Alpha})";
            return texto;
        }
    }
}