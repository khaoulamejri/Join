using Employee.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Infrasturcture
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IEmployeeRepository EmployeeRepository { get; }
    }
}
