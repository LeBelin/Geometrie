using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseRectangle : Classe4Angles
    {
        public double Largeur { get; set; }
        public double Longueur { get; set; }

        public override void Init()
        {
            // Initialise les valeurs
        }

        public double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public double Surface()
        {
            return Longueur * Largeur;
        }

        public void Dessin()
        {
            // pour dessiner un rectangle
        }
    }

}
