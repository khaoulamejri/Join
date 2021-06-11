using Employee.Data.Infrasturcture;
using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Repositories
{

        public class EmployeeRepository : RepositoryBase<Employe>, IEmployeeRepository
    {
            public EmployeeRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
        }
        public interface IEmployeeRepository : IRepository<Employe> { }
    }


