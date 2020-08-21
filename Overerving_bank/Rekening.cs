using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_bank
{
    class Rekening
    {
        public string MyType { get; set; }
        public long RekNr { get; }
        public double Saldo { get; set; }

        public Rekening(long rekNr)
        {
            RekNr = rekNr;
        }
        public Rekening(long rekNr, double saldo)
        {
            RekNr = rekNr;
            Saldo = saldo;
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
