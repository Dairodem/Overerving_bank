using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_bank
{
    class Rekening
    {
        public long RekNr { get; }
        public double saldo { get; set; }

        public Rekening(long rekNr)
        {
            RekNr = rekNr;
        }
        public override string ToString()
        {
            return "BE" + RekNr.ToString();
        }
        public void Overschrijven(long vanRek, long naarRek, double bedrag)
        {

        }
    }
}
