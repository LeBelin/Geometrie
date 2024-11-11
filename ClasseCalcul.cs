using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class ClasseCalcul
    {
        public double UneValeur { get; set; }

        public virtual double Addition(double a, double b)
        {
            return a + b;
        }

        public virtual double Multiplication(double a, double b)
        {
            return a * b;
        }

        public virtual void Init()
        {
            
        }
    }

}
