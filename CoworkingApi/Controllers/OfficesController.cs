using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Appi.Application.Contracts.Services;
using CoworkingApi.Mappers;
using CoworkingApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoworkingApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficesService _officesService;

        public OfficesController(IOfficesService officesService)
        {
            officesService = _officesService;
        }

        /// <summary>
        /// Get Office
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(OfficeModel))]
        public async Task<IActionResult> Get(int id)
        {
            var admin = await _officesService.GetOffice(id);

            return Ok(admin);
        }

        /// <summary>
        /// Get all Office
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<AdminModel>))]
        public async Task<IActionResult> GetAll()
        {
            var admin = await _officesService.GetAllOffices();

            return Ok(admin);
        }

        /// <summary>
        /// Add a new Office
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(OfficeModel))]
        [HttpPost]
        public async Task<IActionResult> AddOffice([FromBody]OfficeModel office)
        {
            var name = await _officesService.AddOffice(OfficeMapper.Map(office));

            return Ok(name);
        }

        /// <summary>
        /// Borra un Office
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _officesService.DeleteOffice(id);

            return Ok();
        }

        /// <summary>
        /// Actualiza un Office
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(OfficeModel))]
        public async Task<IActionResult> UpdateAdmin([FromBody]OfficeModel office)
        {
            var name = await _officesService.UpdateOffice(OfficeMapper.Map(office));

            return Ok(name);
        }

    }
}