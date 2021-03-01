//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalClinic.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Anamnesis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anamnesis()
        {
            this.Conclusion = new HashSet<Conclusion>();
        }
    
        public int Id { get; set; }
        public bool Allergy { get; set; }
        public bool CHD { get; set; }
        public bool Convulsions { get; set; }
        public bool Diabetes { get; set; }
        public bool Onco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conclusion> Conclusion { get; set; }
    }
}