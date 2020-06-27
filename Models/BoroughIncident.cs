//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOM_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoroughIncident
    {
        public int IncidentID { get; set; }
        public Nullable<int> IncidentStatusID { get; set; }
        public Nullable<int> IncidentTypeID { get; set; }
        public Nullable<System.DateTime> IncidentReportDate { get; set; }
        public Nullable<System.DateTime> IncidentLastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string IncidentReportedBy { get; set; }
        public string IncidentReportedByContactPhone { get; set; }
        public string ViolationCode { get; set; }
        public string IncidentReportText { get; set; }
        public string IncidentStreetAddress1 { get; set; }
        public string IncidentStreetAddress2 { get; set; }
    
        public virtual IncidentStatus IncidentStatus { get; set; }
    }
}