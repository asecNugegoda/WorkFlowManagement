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
    
    public partial class ORGANIZATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORGANIZATION()
        {
            this.EMPLOYEEs = new HashSet<EMPLOYEE>();
        }
    
        public int ORG_ID { get; set; }
        public string ORGANIZATION1 { get; set; }
        public string ADR1 { get; set; }
        public string ADR2 { get; set; }
        public string CITY { get; set; }
        public string CONTATC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
