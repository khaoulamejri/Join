using AutoMapper;
using Employee.Domain.Entities;
using Employee.Services;
using EventBus.Event;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices employeeServices;
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeServices employeeServices, IPublishEndpoint publishEndpoint, IMapper mapper)
        {
            this.employeeServices = employeeServices;
            _publishEndpoint = publishEndpoint;
            _mapper = mapper;
        }

        [ProducesResponseType(200)]
        [HttpGet, Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var listEmployee = employeeServices.GetAllEmployees();
            return StatusCode(200, listEmployee);
        }

        [ProducesResponseType(200)]
        [HttpGet, Route("GetEmployeeByID")]
        public IActionResult GetEmployeeByID(int id)
        {
            var Employee = employeeServices.GetEmployeeByID(id);
            return StatusCode(200, Employee);

        }





        [ProducesResponseType(200)]
        [HttpGet, Route("GetCompanyByName")]
        public IActionResult GetCompanyByName(string name)
        {
            var Employee = employeeServices.GetEmployeeByUserName(name);
            return StatusCode(200, Employee);
        }

        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [HttpDelete, Route("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var Employee = employeeServices.Delete(id);
                if (Employee == null)
                {
                    return StatusCode(400, "FailDeleteEmployee");
                }
                return StatusCode(200, Employee);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
     
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
            var employee = employeeServices.GetEmployeeByUserName(congeCheckout.UserName);


            if (employee == null)
            {
                return BadRequest();
            }

            // send checkout event to rabbitmq
            var eventMessage = _mapper.Map<CongeCheckoutEvent>(congeCheckout);
            //publish
            eventMessage.NumeroPersonne = employee.NumeroPersonne;
            await _publishEndpoint.Publish<CongeCheckoutEvent>(eventMessage);

            // remove the Epmploye


            return Accepted();
        }
    }

}

