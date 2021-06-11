using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Event
{
  public class CongeCheckoutEvent : IntegrationBaseEvent
    {
       
        public string UserName{ get; set; }
        public DateTime DateDemande { get; set; } = DateTime.Today;

        public DateTime DateDebutConge { get; set; } = DateTime.Today;

        public DateTime DateRepriseConge { get; set; } = DateTime.Today;
        public float NbrConge { get; set; }
        public string NumeroPersonne { get; set; }
        public string Numero { get; set; }
    }
}
