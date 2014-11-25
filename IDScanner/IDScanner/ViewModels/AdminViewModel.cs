using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDScanner.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<IDScanner.Faculty> Faculty { get; set; }
        public IEnumerable<IDScanner.Student> Student { get; set; }
        public IEnumerable<IDScanner.Attendance> Attendance { get; set; }
        public IEnumerable<IDScanner.Schedule> Schedule { get; set; }
        public IEnumerable<IDScanner.Cours> Course { get; set; }
    }
}