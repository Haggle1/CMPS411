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
    
    public partial class Schedule
    {
        public string ID { get; set; }
        public string CourseID { get; set; }
        public int ScheduleID { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
