using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disegno_Geometrico
{
    public abstract class Piano
    {
        private double y;
        private double x;
        private string nome;
        public abstract string CalcolaPunto();
        
    }
}
