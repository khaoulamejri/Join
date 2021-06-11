using Employee.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Infrasturcture
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        protected ApplicationDbContext DataContext
        {
            get { return dataContext = dbFactory.DataContext; }
        }
        private IEmployeeRepository employeeRepository;
        public IEmployeeRepository EmployeeRepository
        {
            get { return employeeRepository = new EmployeeRepository(dbFactory); }
        }

        public void Commit() { DataContext.SaveChanges(); }
        public void Dispose()
        {
            dbFactory.Dispose();
        }
    }
}
