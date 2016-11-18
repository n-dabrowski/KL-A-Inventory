using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testerino.Data;
using testerino.Models;
using testerino.ViewModels;

namespace testerino.Controllers.Api
{
    [Route("api/Item")]
    public class ItemController : Controller
    {
        private ApplicationDbContext _context;
        private IInventoryRepository _repository;

        public ItemController(ApplicationDbContext context, IInventoryRepository repository)
        {
            _context = context;
            _repository = repository;
        }


        [HttpGet("")]
        public IActionResult Get()
        {
            //var results = _context.Inventory.ToListAsync();

            var results = _repository.getAllInventories();

            return Ok(Mapper.Map<IEnumerable<InventoryViewModel>>(results));

            //return Ok(_context.Inventory.ToListAsync());
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]InventoryViewModel inventory)
        {
            if (ModelState.IsValid)
            {
                var newInventory = Mapper.Map<Inventory>(inventory);
                _repository.AddInventory(newInventory);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"api/Item/{inventory.Name}", Mapper.Map<InventoryViewModel>(newInventory));
                }
                
                //return Ok();
            }

            return BadRequest("Failed to save changes");
        }

    }
}