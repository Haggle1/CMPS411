using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDScanner.ViewModels
{
    public class TeacherViewModel
    {
        public IEnumerable<IDScanner.Student> Student{ get; set; }
        public IEnumerable<IDScanner.aspnet_Users> Users { get; set; }
        public IEnumerable<IDScanner.Attendance> Attendance { get; set; }
        public IEnumerable<IDScanner.Schedule> Schedule { get; set; }
        public IEnumerable<IDScanner.Cours> Course { get; set; }


    }

}