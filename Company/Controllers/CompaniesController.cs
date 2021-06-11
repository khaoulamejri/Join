using AutoMapper;
using Company.Domain.Entities;
using Company.Service;
using EventBus.Event;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyServices companyServices;
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyServices companyServices, IPublishEndpoint publishEndpoint, IMapper mapper)
        {
            this.companyServices = companyServices;
            _publishEndpoint = publishEndpoint;
            _mapper = mapper;
        }

        [ProducesResponseType(200)]
        [HttpGet, Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            var listCompany = companyServices.GetAllCompany();
            return StatusCode(200, listCompany);
        }

        [ProducesResponseType(200)]
        [HttpGet, Route("GetCompanyById")]
        public IActionResult GetCompanyById(int id)
        {
            var Company = companyServices.GetCompanyByID(id);
            return StatusCode(200, Company);
           
        }





        [ProducesResponseType(200)]
        [HttpGet, Route("GetCompanyByName")]
        public IActionResult GetCompanyByName(string name)
        {
            var Company = companyServices.GetCompanyByName(name);
            return StatusCode(200, Company);
        }

        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [HttpDelete, Route("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var Societe = companyServices.Delete(id);
                if (Societe == null)
                {
                    return StatusCode(400, "FailDeleteCompany");
                }
                return StatusCode(200, Societe);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
        public async Task<IActionResult> Checkout([FromBody] CongeCheckout congeCheckout)
        {
            // get existing Employe            
            // Set EmployeID on EmployeCheckout eventMessage
            // send checkout event to rabbitmq
            // remove the company

            // get existing company
            var company = companyServices.GetCompanyByName(congeCheckout.UserName);


            if (company == null)
            {
                return BadRequest();
            }

            // send checkout event to rabbitmq
            var eventMessage = _mapper.Map<CongeCheckoutEvent>(congeCheckout);
            //publish
            eventMessage.Numero = company.Numero;
            await _publishEndpoint.Publish<CongeCheckoutEvent>(eventMessage);

            // remove the company


            return Accepted();
        }
    }

}
