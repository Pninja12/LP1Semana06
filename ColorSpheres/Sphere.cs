using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color cor;
        private int raio;
        private int vezesatirado;

        public Sphere(Color cor, int raio)
        {
            this.cor = cor;
            this.raio = raio;
            vezesatirado = 0;
        }
    }
}