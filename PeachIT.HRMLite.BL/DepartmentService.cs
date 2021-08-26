using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.DAL;
using AutoMapper;
using PeachIT.HRMLite.BL;
using PeachIT.HRMLite.Models;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Contracts;


namespace PeachIT.HRMLite.BL
{
   public class DepartmentService : IDepartmentService
    {
        private readonly HRMLiteContext context;
        private readonly IMapper mapper;

        public DepartmentService(HRMLiteContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<DepartmentModel> GetDepartment()
        {
            var departments = context.Departments.ToList();
            return mapper.Map<List<DepartmentModel>>(departments);
        }

        public int SaveDepartment(DepartmentModel departmentModel)
        {
            if (departmentModel == null)
                throw new ArgumentNullException();

            Department department = departmentModel.Id > 0 ?
                context.Departments.Single<Department>(p => p.Id == departmentModel.Id) :
                new Department();

            department = mapper.Map<Department>(departmentModel);
            context.Add(department);
            context.SaveChanges();

            return department.Id;
        }
    }
}
