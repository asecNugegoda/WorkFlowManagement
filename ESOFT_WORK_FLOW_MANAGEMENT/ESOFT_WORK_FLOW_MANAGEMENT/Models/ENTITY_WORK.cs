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
    
    public partial class ENTITY_WORK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENTITY_WORK()
        {
            this.ENTITY_EMPLOYEE = new HashSet<ENTITY_EMPLOYEE>();
        }
    
        public int EW_WORK { get; set; }
        public Nullable<int> WF_ID { get; set; }
        public string ENTITY_NAME { get; set; }
        public string REMARK { get; set; }
        public Nullable<System.DateTime> ASSIGN_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<int> STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTITY_EMPLOYEE> ENTITY_EMPLOYEE { get; set; }
        public virtual STATUS STATUS1 { get; set; }
        public virtual WORK_FLOW WORK_FLOW { get; set; }
    }
}
