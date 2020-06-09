using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone6_CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Capstone6_CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly VehicleDbContext _context;
        public CarController(VehicleDbContext context)
        {
            _context = context;
        }

        // GET: api/Car
        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            var cars = await _context.Car.ToListAsync();
            return cars;
        }

        //public iactionresult index()
        //{
        //    return view();
        //}
    }
}
