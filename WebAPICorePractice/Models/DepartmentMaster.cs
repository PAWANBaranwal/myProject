using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICorePractice.Models
{
    public class DepartmentMaster
    {

        public int DepartmentID { get; set; }
        
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string DepartmentStatus { get; set; }
        public string CreatedBy { get; set; }

        
    }
}
