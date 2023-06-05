using System;

namespace DesignPatterns.Strategy.Models
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
