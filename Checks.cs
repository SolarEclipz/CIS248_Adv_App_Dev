using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sturdevant_s_Application
{
    class Checks
    {
        private decimal ckAmount;

        public Checks() { }

        public Checks(decimal ckAmount)
        {
            this.ckAmount = ckAmount;
        }

        public decimal Price
        {
            get { return ckAmount; }
            set { ckAmount = value; }
        }

        public string GetDisplayText(string sep)
        {
            return sep + ckAmount.ToString("c") + sep;
        }
    }
}
