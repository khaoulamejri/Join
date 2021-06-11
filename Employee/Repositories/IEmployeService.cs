using Employee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Repositories
{
    public interface IEmployeService
    {
        public List<Employe> GetEmployes();
        public Employe GetEmployesByNom(String nom);

        public Employe AddEmployet(Employe empl);

        public Employe UpdateEmploye(string id, Employe empl);

        public string DeleteEmploye(string id);
    }
}
