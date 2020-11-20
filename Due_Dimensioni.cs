using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disegno_Geometrico
{
    public class Due_Dimensioni : Piano
    {
        public double Y { get; private  set; }
        public double X { get; private  set; }

        public string Nome { get; private set; }

        public Due_Dimensioni(double y, double x, string nome)
        {
            Nome = nome;
            Y = y;
            X = x;
        }
        public override string CalcolaPunto()
        {
            return $"il {Nome} punto è {Y} ; {X} ";
        }
    }
}
