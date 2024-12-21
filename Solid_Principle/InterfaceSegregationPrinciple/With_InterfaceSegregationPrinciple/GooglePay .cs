﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.InterfaceSegregationPrinciple.With_InterfaceSegregationPrinciple
{
    public class GooglePay : UPIPayments, CashbackManager
    {
        public void GetCashBackAsCreditBalance()
        {
            //Write logic
        }

        public void GetScratchCard()
        {
            //Write logic
        }

        public void PayMoney()
        {
            //Write logic
        }

    }
}