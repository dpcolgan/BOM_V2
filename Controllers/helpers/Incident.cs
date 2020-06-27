using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOM_V2.Controllers.helpers
{
    public class Incident
    {
        int IncidentStatusID { get; set; }
        int IncidentTypeID { get; set; }
        DateTime IncidentReportDate { get; set; }
        DateTime IncidentLastUpdated { get; set; }
        string LastUpdatedBy { get; set; }
        string IncidentReportedBy { get; set; }
        string IncidentReportedByContactPhone { get; set; }
        string ViolationCode { get; set; }
        string IncidentReportText { get; set; }
        string IncidentStreetAddress1 { get; set; }
        string IncidentStreetAddress2 { get; set; }
    }
}