//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WORKFLOW_MANAGER
    {
        public int WB_ID { get; set; }
        public Nullable<int> WORK_FLOW { get; set; }
        public int MANAGER { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string REMARK { get; set; }
    
        public virtual STATUS STATUS1 { get; set; }
        public virtual WORK_FLOW WORK_FLOW1 { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}