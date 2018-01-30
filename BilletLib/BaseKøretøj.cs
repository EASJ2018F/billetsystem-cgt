using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem.BilletLib
{
    public abstract class BaseKøretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public abstract int Pris();

        public abstract string Køretøj();
    }
}
