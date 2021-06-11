using Employee.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Repositories
{
    public class EmployeService : IEmployeService
    {
        private List<Employe> _emp;
        private readonly ApplicationDbContext _context;

        public EmployeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public EmployeService()
        {
            _emp = new List<Employe>();
        }

        public Employe AddEmployet(Employe empl)
        {
            _emp.Add(empl);
            return empl;
        }

        public string DeleteEmploye(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employe> GetEmployes()
        {
            return _emp;
        }

        //public Employe GetEmployesById(int Id)
        //{
        //    var employe = _emp.FirstOrDefault(t => t.Id == Id);
        //    return employe;
        //}

        public Employe GetEmployesByNom(string nom)
        {
           // var employe = _emp.FirstOrDefault(t => t.Nom == nom);
            //var employe = _emp.Find(t => t.Nom == nom);
           // return employe;
            
            var employe =  _context.employees
                  .FirstOrDefault(m => m.Nom == nom);
            return employe;
        }

        public Employe UpdateEmploye(string id, Employe empl)
        {
            throw new NotImplementedException();
        }
    }
}
