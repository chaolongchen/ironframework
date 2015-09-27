//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using IronFramework.Common.Data.EntityFramework;
    
    [DataContract]
    public partial class Employee : IEntity
    {
        public Employee()
        {
            this.Employee1 = new HashSet<Employee>();
            this.EmployeePayHistories = new HashSet<EmployeePayHistory>();
        }
    
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string NationalIDNumber { get; set; }
        [DataMember]
        public int ContactID { get; set; }
        [DataMember]
        public string LoginID { get; set; }
        [DataMember]
        public Nullable<int> ManagerID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public System.DateTime BirthDate { get; set; }
        [DataMember]
        public string MaritalStatus { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public System.DateTime HireDate { get; set; }
        [DataMember]
        public bool SalariedFlag { get; set; }
        [DataMember]
        public short VacationHours { get; set; }
        [DataMember]
        public short SickLeaveHours { get; set; }
        [DataMember]
        public bool CurrentFlag { get; set; }
        [DataMember]
        public System.Guid rowguid { get; set; }
        [DataMember]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Employee> Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
    
        #region IEntity Members
    
        public State State { get; set; }
    
        #endregion
    }
}
