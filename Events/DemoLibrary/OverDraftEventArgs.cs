using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverDraftEventArgs : EventArgs
    {
        public decimal AmountOverdrafted { get; set; }
        public string MoreInfo { get; set; }

        //public OverDraftEventArgs(decimal amountOverdrafted, string moreInfo)
        //{
        //    AmountOverdrafted = amountOverdrafted;
        //    MoreInfo = moreInfo;
        //}
    }
}
