using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class TimesheetReferenceData
    {
        public List<EssWorkTypeModel> WorkTypes { get; set; }
        public List<EssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ClassificationSelectModel> Classifications { get; set; }
    }
}
