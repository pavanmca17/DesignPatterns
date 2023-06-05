﻿using System;

namespace DesignPatterns.Strategy.Models
{
    public class Discount
    {
        public string DiscountApprovedBy { get; set; }

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
