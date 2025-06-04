
using Esce.Application.Features.Products.Queries;
using MediatR;

﻿using Esce.Application.Interface.Repository;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {

            var products = await _mediator.Send(new GetProductListQuery());

            return Ok(products);
        }
    }
}
