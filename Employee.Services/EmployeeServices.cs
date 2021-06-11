using Employee.Data;
using Employee.Data.Infrasturcture;
using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        private readonly ApplicationDbContext Context;


        public EmployeeServices(ApplicationDbContext ctx)
        {
            Context = ctx;
            dbFactory = new DatabaseFactory(ctx);
            utOfWork = new UnitOfWork(dbFactory);

        }
        public Employe Create(Employe Employee)
        {
            utOfWork.EmployeeRepository.Add(Employee);
            utOfWork.Commit();
            return Employee; ;
        }

        public Employe Delete(int EmployeeId)
        {
            try
            {
                var employe = utOfWork.EmployeeRepository.Get(a => a.Id == EmployeeId);
                if (employe != null)
                {
                    utOfWork.EmployeeRepository.Delete(employe);
                    utOfWork.Commit();
                    return employe;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public Employe Edit(Employe Employee)
        {
            try
            {
                utOfWork.EmployeeRepository.Update(Employee);
                utOfWork.Commit();
                return Employee;
            }
            catch (Exception e)
            {
                return null;
            }

        }

            public List<Employe> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public List<Employe> GetAllEmployees()
        {
            return utOfWork.EmployeeRepository.GetAll().ToList();
        }

        public Employe GetEmployeeByID(int id)
        {
            return utOfWork.EmployeeRepository.Get(a => a.Id == id);
        }

        public Employe GetEmployeeByUserName(string user)
        {
            return utOfWork.EmployeeRepository.GetMany(a => a.Nom == user).First();
        }

        public byte[] GetProfileImage(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
