using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem.BilletLib
{
    public class MC : BaseKøretøj
    {
        public override int Pris()
        {
            return FratrækRabat(125);
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
