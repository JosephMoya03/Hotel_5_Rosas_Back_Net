﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities_Hotel_5_Rosas;
using Hotel_5_Rosas_Proyect.Data;
using System.Web.Http.Cors;

namespace Hotel_5_Rosas_Proyect.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS")]
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class Entity_TelefonoController : Controller
    {
        private readonly DA_Hotel_5_Rosas_Telefono _context;

        public Entity_TelefonoController(DA_Hotel_5_Rosas_Telefono context)
        {
            _context = context;
        }




        // GET: api/Entity_Telefono/GetPhones
        [HttpGet]
        public async Task<IEnumerable<Entities_Hotel_5_Rosas.Entity_Telefono>> GetPhones()
        {
            return await _context.Set<Entities_Hotel_5_Rosas.Entity_Telefono>().ToListAsync();
        }

        private bool Entity_TelefonoExists(int id)
        {
            return _context.Entity_Telefono.Any(e => e.PK_Telefono == id);
        }
    }
}
