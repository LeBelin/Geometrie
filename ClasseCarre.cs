using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseCarre : Classe4Angles
    {
        public double Cote { get; set; }

        public override void Init()
        {
            // Initialise les valeurs
        }

        public double Perimetre()
        {
            return 4 * Cote;
        }

        public double Surface()
        {
            return Cote * Cote;
        }

        public void Dessin()
        {
            // pour dessiner un carré 
        }
    }

}
