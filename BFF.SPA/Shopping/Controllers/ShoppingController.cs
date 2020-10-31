﻿using System.Threading.Tasks;
using BFF.SPA.Services.Core.Services;
using BFF.SPA.Services.Shopping.Services.Interfaces;
using BFF.SPA.Services.Shopping.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BFF.SPA.Shopping.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly ICustomerOrderService _service;

        public ShoppingController(ICustomerOrderService service)
        {
            _service = service;
        }

        [HttpGet("{customerId}")]
        public async Task<ServiceResponse<CustomerOrderListVM>> GetOrdersByCustomerAsync(string customerId)
        {
            return await _service.GetOrdersByCustomerAsync(customerId);
        }
    }
}
