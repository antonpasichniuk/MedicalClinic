﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedicalClinicContext : DbContext
    {
        public MedicalClinicContext()
            : base("name=MedicalClinicContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Anamnesis> Anamnesis { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Conclusion> Conclusion { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Examination> Examination { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Medcard> Medcard { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PersonalData> PersonalData { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
