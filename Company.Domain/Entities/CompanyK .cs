using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entities
{
   public class CompanyK
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string LegalStatus { get; set; }
        public string FiscalNumber { get; set; }
        public string TradeRegister { get; set; }

        public string Numero { get; set; }
    }
}
