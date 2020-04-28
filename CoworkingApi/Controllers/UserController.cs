﻿using System;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;      

        public UserController(IUserService userService)
        {
            _userService = userService;           
        }

        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(UserModel))]
        public async Task<IActionResult> Get(int id)
        {
            var admin = await _userService.GetUser(id);
            return Ok(admin);
        }

        /// <summary>
        /// Get all User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<UserModel>))]
        public async Task<IActionResult> GetAll()
        {
            var admin = await _userService.GetAllUsers();

            return Ok(admin);
        }

        /// <summary>
        /// Add a new User
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(UserModel))]
        [HttpPost]
        public async Task<IActionResult> AddAdmin([FromBody]UserModel user)
        {
            var name = await _userService.AddUser(UserMapper.Map(user));

            return Ok(name);
        }

        /// <summary>
        /// Borra un User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _userService.DeleteUser(id);

            return Ok();
        }

        /// <summary>
        /// Actualiza un User
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(UserModel))]
        public async Task<IActionResult> UpdateAdmin([FromBody]UserModel admin)
        {
            var name = await _userService.UpdateUser(UserMapper.Map(admin));

            return Ok(name);
        }
    }
}