using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overerving_bank
{
    class CreditCard : Rekening
    {
        public int Code { get; }

        public CreditCard(long rekNr) : base (rekNr)
        {
            Code = NewCode();
        }

        private int NewCode()
        {
            Random randCode = new Random();
            int newCode = randCode.Next(100, 1000);

            return newCode;
        }
    }
}
