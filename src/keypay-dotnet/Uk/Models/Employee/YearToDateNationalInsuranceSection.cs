using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class YearToDateNationalInsuranceSection
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public YearToDateNationalInsuranceComponent[] Components { get; set; }
    }
}
