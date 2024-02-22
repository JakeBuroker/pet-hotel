using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsController(ApplicationContext context) {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Pet> GetPets() {
            return _context.Pets.Include(pet => pet.ownedBy);
        }

 [HttpPost]
    public Pet Post(Pet pet) 
    {
        // Tell the DB context about our new bread object
        _context.Add(pet);
        // ...and save the bread object to the database
        _context.SaveChanges();

        // Respond back with the created bread object
        return pet;
    }
    }
}
