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
    
    public partial class IncidentStatusHistory
    {
        public int IncidentID { get; set; }
        public Nullable<int> IncidentStatus { get; set; }
        public System.DateTime StatusChangeDate { get; set; }
        public string StatusChangedBy { get; set; }
    }
}
