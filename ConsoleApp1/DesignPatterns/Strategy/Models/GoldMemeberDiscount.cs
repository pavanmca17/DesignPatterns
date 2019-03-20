using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy.Models
{
    public class GoldMemeberDiscount : Discount
    {
        public GoldMemeberDiscount(string _DiscountApprovedBy,DateTime DiscountAppliedOn, float _DiscountAmount) :
            base(_DiscountApprovedBy, DiscountAppliedOn)
        {
            DiscountAmount = _DiscountAmount;
        }
        public override float DiscountAmount { get; set; }

       
    }
}
