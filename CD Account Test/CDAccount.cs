using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        //Fields
        private string _maturityDate;

        //Constructor
        public CDAccount()
        {
            _maturityDate = "";
        }

        //MaturityDate property
        public string MaturityRate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }

    }
}
