using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Appi.Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoworkingApi.Controllers
{
    [Route("Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var name =await _adminService.GetAdminName(id);
            return Ok(name);
        }
    }
}