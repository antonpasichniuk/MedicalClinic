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
    
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.Appointment = new HashSet<Appointment>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SpecialityId { get; set; }
        public int PersonalDataId { get; set; }
        public Nullable<System.DateTime> AbsentDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual PersonalData PersonalData { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual User User { get; set; }
    }
}
