using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disegno_Geometrico
{
    public class Tre_Dimensioni : Piano
    {
        private double z;

        public double Y { get; private set; }
        public double X { get; private set; }
        public double Z { get; private set; }
        public string Nome { get; private set; }

        public Tre_Dimensioni(double z,double x,double y,string nome)
        {
            Nome = nome;
            Y = y;
            X = x;
            Z = z;
        }
        public override string CalcolaPunto()
        {
            return $"il {Nome} punto è {Y} ; {X} ; {Z} ";
        }
    }
}
