using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class GetLeaveBalancesQueryModel
    {
        public DateTime? AsAtDate { get; set; }
    }
}
