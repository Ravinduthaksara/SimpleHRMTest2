using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeachIT.HRMLite.Domain
{
   public class Department : BaseModel
    {
        public string DepartmentName { get; set; }
        public int ContactNo { get; set; }
        public string DeptMail { get; set; }
        public string Purpose { get; set; }
        public string PhotoUpload { get; set; }
        public int EmpCount { get; set; }
    }
}
