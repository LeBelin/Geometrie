using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseTriangle : ClasseAvecAngle
    {
        public double C1 { get; set; }
        public double C2 { get; set; }
        public double Haut { get; set; }

        public override void Init()
        {
            // Initialise les valeurs spécifiques au triangle
        }

        public double Perimetre()
        {
            return C1 + C2 + Haut;
        }

        public double Surface()
        {
            return (C1 * Haut) / 2;
        }

        public void Dessin()
        {
            // Logique pour dessiner un triangle
        }
    }

}
