using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseRond : ClasseCalcul
    {
        public double Rayon { get; set; }

        public double Perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public double Surface()
        {
            return Math.PI * Rayon * Rayon;
        }

        public void Dessin()
        {
            // pour dessiner un rond
        }
    }

}
