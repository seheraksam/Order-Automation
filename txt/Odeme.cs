using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public abstract class Odeme
    {
        public double Miktar  { get; set; }
        public abstract void OdenecekTutar(double tutar);
            


    }
}
