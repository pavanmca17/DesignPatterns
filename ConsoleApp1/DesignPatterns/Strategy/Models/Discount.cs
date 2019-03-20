using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy.Models
{
    public class Discount
    {
        public String DiscountApprovedBy { get; set; }

        public DateTime DiscountAppliedOn { get; set; }

        public virtual float DiscountAmount { get; set; } 

        public Discount(String _DiscountApprovedBy,DateTime _DiscountAppliedOn)
        {
            DiscountAmount = 0;
            DiscountApprovedBy = _DiscountApprovedBy;
            DiscountAppliedOn = _DiscountAppliedOn;

        }
    }
}
