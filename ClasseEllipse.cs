using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseEllipse : ClasseRond
    {
        public double PR { get; set; } // Petit Rayon
        public double GR { get; set; } // Grand Rayon

        public new double Surface()
        {
            return Math.PI * PR * GR;
        }

        public void Dessin()
        {
            //  pour dessiner une ellipse
        }
    }

}
