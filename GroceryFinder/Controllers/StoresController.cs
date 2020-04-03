using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {

        private readonly GroceryFinderContext _db;
        public StoresController(GroceryFinderContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Store>> Get(string name, string city, string openHour)
        {
            var query = _db.Stores.AsQueryable();
            if(name != null)
            {
                query = query.Where(entry => entry.Name.ToLower() == name.ToLower());
            }
            if(city != null)
            {
                query = query.Where(entry => entry.City.ToLower() == city.ToLower());
            }
            if(openHour != null)
            {
                int checkHour = int.Parse(openHour);
                query = query.Where(entry => (entry.OpenHour <= checkHour && entry.CloseHour > checkHour));
            }
            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Store Get(int id)
        {
            Store thisStore = _db.Stores.FirstOrDefault(store => store.StoreId == id);
            return thisStore;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Store store)
        {
            store.StoreId = id;
            _db.Entry(store).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Store thisStore = _db.Stores.FirstOrDefault(store => store.StoreId == id);
            _db.Stores.Remove(thisStore);
            _db.SaveChanges();
        }
    }
}
