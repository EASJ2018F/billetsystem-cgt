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

        public bool BroBizz { get; set; }

        protected int FratrækRabat(int pris)
        {
            if (BroBizz)
            {
                return (int)(pris * 0.95);
            } else
            {
                return pris;
            }
        }

        public DateTime Dato { get; set; }

        /// <summary>
        /// Pris returner prisen for køretøjet at køre over broen.
        /// Implementeringer skal kalde FratrækRabat på deres endelige resultat,
        /// før de returnerer det.
        /// </summary>
        public abstract int Pris();

        public abstract string Køretøj();
    }
}
