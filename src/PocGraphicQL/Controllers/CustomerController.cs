using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PocGraphicQL.Application.Queries;

namespace PocGraphicQL.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{customerId}")]
        public async Task<IActionResult> Get([FromRoute]string customerId)
        {
            var query = new CustomerByIdQuery(customerId);
            var response = await _mediator.Send(query);
            return Ok(response.Value);
        }
    }
}