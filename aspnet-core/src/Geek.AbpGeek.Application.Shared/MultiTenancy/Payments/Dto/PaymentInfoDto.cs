﻿using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }
    }
}
