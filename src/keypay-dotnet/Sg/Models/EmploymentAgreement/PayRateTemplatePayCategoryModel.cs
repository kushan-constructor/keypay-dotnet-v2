using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmploymentAgreement
{
    public class PayRateTemplatePayCategoryModel
    {
        public int PayCategoryId { get; set; }
        public decimal UserSuppliedRate { get; set; }
        public decimal CalculatedRate { get; set; }
        public decimal StandardWeeklyHours { get; set; }
        public decimal? SuperRate { get; set; }
    }
}
