using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sturdevant_s_Application
{
    class MoneyDenomination
    {
        // keep things easy vars
        public decimal dollarBills;
        public decimal changeCoins;
        public decimal rightSideAmounts;

        // left side of app
        public decimal noHundred;
        public decimal noFifty;
        public decimal noTwenty;
        public decimal noTen;
        public decimal noFive;
        public decimal noOne;
        public decimal noQtr;
        public decimal noDime;
        public decimal noNickel;
        public decimal noPenny;

        // right side of app
        public decimal bankRoll;
        public decimal checkAmount;
        public decimal ccAmount;
        public decimal otherAmount;
        public decimal saeDeposit;
        public decimal grandTotal;
        public decimal removeTill;

        public MoneyDenomination()
        {
            dollarBills = 0;
            changeCoins = 0.0m;
            rightSideAmounts = 0.0m;
            noHundred = 0;
            noFifty = 0;
            noTwenty = 0;
            noTen = 0;
            noFive = 0;
            noOne = 0;
            noQtr = 0.0m;
            noDime = 0.0m;
            noNickel = 0.0m;
            noPenny = 0.0m;
            bankRoll = 0.0m;
            checkAmount = 0.0m;
            ccAmount = 0.0m;
            otherAmount = 0.0m;
            saeDeposit = 0.0m;
            grandTotal = 0.0m;
            removeTill = 0.0m;
        }
    }
}
