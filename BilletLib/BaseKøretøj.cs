using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem.BilletLib
{
    public abstract class BaseKøretøj
    {
        private string _nummerplade;
        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("nummerplade må maks. være syv tegn");
                }
                _nummerplade = value;
            }
        }
        public DateTime Dato { get; set; }

        public abstract int Pris();

        public abstract string Køretøj();
    }
}
