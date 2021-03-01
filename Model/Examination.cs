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
    
    public partial class Examination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examination()
        {
            this.Conclusion = new HashSet<Conclusion>();
        }
    
        public int Id { get; set; }
        public double BodyTemperature { get; set; }
        public string BloodPressure { get; set; }
        public int Pulse { get; set; }
        public int RespiratoryRate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conclusion> Conclusion { get; set; }
    }
}
