using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_bank
{
    class Bank
    {
        public List<Rekening> RekList { get; set; }

        public Bank()
        {
            RekList = new List<Rekening>();
            RekList.Add(new CreditCard(13748944003232));
            RekList[0].saldo = 10000;
        }
    }
}
