//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDScanner
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.Schedules = new HashSet<Schedule>();
        }
    
        public string SID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
