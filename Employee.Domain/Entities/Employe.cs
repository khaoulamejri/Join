using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public string NumeroPersonne { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }
    }
}
