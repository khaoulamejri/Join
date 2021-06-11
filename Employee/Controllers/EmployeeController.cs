using AutoMapper;
using Employee.Entities;
using Employee.Repositories;
using EventBus.Event;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api / v1 /[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //private readonly IEmpolyeeRepositories _empolyeeRepositories;

        //public EmployeeController(IEmpolyeeRepositories empolyeeRepositories)
        //{
        //    _empolyeeRepositories = empolyeeRepositories;
        //}
        private IEmployeService _service;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;


        public EmployeeController(IEmployeService service, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _service = service;
            _mapper = mapper;
            _publishEndpoint = publishEndpoint;
        }

        [HttpGet("/api/employes")]
        public ActionResult<List<Employe>> GetEmployes()
        {
            return _service.GetEmployes();
             
        }

        [HttpPost("/api/employes")]
        public ActionResult<Employe> AddEmploye(Employe employe)
        {
            _service. AddEmployet(employe);
            return employe;
        }
        [HttpDelete("/api/employe/{id}")]
        public ActionResult<string> DeleteEmploye(string id)
        {
            _service. DeleteEmploye(id);
            return id;
        }
        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Checkout([FromBody] CongeCheckout congeCheckout)
        {
            // get existing Employe            
            // Set EmployeID on EmployeCheckout eventMessage
            // send checkout event to rabbitmq
            // remove the employe

            // get existing employe
             var emp = _service.GetEmployesByNom(congeCheckout.UserName);


            if (emp == null)
            {
                return BadRequest();
            }

            // send checkout event to rabbitmq
            var eventMessage = _mapper.Map<CongeCheckoutEvent>(congeCheckout);
            eventMessage.NumeroPersonne = emp.NumeroPersonne;
            await _publishEndpoint.Publish<CongeCheckoutEvent>(eventMessage);

            // remove the Epmploye
         

            return Accepted();
        }
    }
     
}
