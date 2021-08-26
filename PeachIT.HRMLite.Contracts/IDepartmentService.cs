using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.Models;

namespace PeachIT.HRMLite.Contracts
{
   public interface IDepartmentService
    {
        List<DepartmentModel> GetDepartment();
        public int SaveDepartment(DepartmentModel department);
    }
}
