using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Appi.Application.Contracts.Services;
using CoworkingApi.ViewModels;
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


        /// <summary>
        /// Add new Admin
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("aplication/json",Type= typeof(AdminModel))]
        [HttpPost]
        public async Task<IActionResult> AddAdmin([FromBody] AdminModel admin)
        {
            var name = await _adminService.AddAdmin(Mappers.AdminMapper.Map(admin));
            return Ok(name);
        }
    }
}