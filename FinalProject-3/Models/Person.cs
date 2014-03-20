//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Donations = new HashSet<Donation>();
            this.Employees = new HashSet<Employee>();
            this.PersonAddresses = new HashSet<PersonAddress>();
            this.PersonContacts = new HashSet<PersonContact>();
            this.ServiceGrants = new HashSet<ServiceGrant>();
        }
    
        public int PersonKey { get; set; }
        public string PersonLastName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonUsername { get; set; }
        public string PersonPlainPassword { get; set; }
        public Nullable<int> Personpasskey { get; set; }
        public Nullable<System.DateTime> PersonEntryDate { get; set; }
        public byte[] PersonUserPassword { get; set; }
    
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        public virtual ICollection<PersonContact> PersonContacts { get; set; }
        public virtual ICollection<ServiceGrant> ServiceGrants { get; set; }
    }
}
