using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem.BilletLib
{
    public class Bil : BaseKøretøj
    {
        public override int Pris()
        {
            return FratrækRabat(240);
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
