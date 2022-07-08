using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructura.Datos;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class LugaresController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LugaresController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Lugar>>> GetLugares(){
            return Ok(await _context.Lugares.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Lugar>> GetLugar(int id){
            return await _context.Lugares.FindAsync(id);
        }
    }
}