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
        // Tell the DB context about our new object
        _context.Add(pet);
        // ...and save the object to the database
        _context.SaveChanges();

        return pet;
    }
    
    
      [HttpPut("{id}")]
    public Pet Put(int id, Pet pet) 
    {
        
       pet.id = id;

        _context.Update(pet);
 
        _context.SaveChanges();

        return pet;
    }

       // DELETE /api/breads/:id
    [HttpDelete("{id}")]
    public void Delete(int id) 
    {
        // Find the bread, by ID
        Pet pet = _context.Pets.Find(id);

        // Tell the DB that we want to remove this bread
        _context.Pets.Remove(pet);

        // ...and save the changes to the database
        _context.SaveChanges();;
    }
    }
}
