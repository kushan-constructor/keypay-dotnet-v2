using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunWarningDto
    {
        public PayRunWarningType WarningType { get; set; }
        public int EmployeeId { get; set; }
        public string Warning { get; set; }
        public string EmployeeName { get; set; }
        public int PayRunTotalId { get; set; }
        public Object MetaData { get; set; }
        public string MetaDataJson { get; set; }
        public string EmployeeExternalId { get; set; }
        public string FormattedWarningMessage { get; set; }
    }
}
