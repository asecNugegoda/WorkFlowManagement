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
    
    public partial class STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATUS()
        {
            this.ENTITY_EMPLOYEE = new HashSet<ENTITY_EMPLOYEE>();
            this.ENTITY_WORK = new HashSet<ENTITY_WORK>();
            this.WORK_FLOW = new HashSet<WORK_FLOW>();
            this.WORKFLOW_MANAGER = new HashSet<WORKFLOW_MANAGER>();
            this.EMPLOYEEs = new HashSet<EMPLOYEE>();
        }
    
        public int STATUS_ID { get; set; }
        public string TYPE { get; set; }
        public string STATUS1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTITY_EMPLOYEE> ENTITY_EMPLOYEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTITY_WORK> ENTITY_WORK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORK_FLOW> WORK_FLOW { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORKFLOW_MANAGER> WORKFLOW_MANAGER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
