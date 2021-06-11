using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entities
{
    public class CongeCheckout
    {
        public string UserName { get; set; }
        public DateTime DateDemande { get; set; } = DateTime.Today;

        public DateTime DateDebutConge { get; set; } = DateTime.Today;

        public DateTime DateRepriseConge { get; set; } = DateTime.Today;

        public float NbrConge { get; set; }
    }
}
