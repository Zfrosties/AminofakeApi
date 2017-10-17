using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aminofakeApi.Models;

namespace aminofakeApi.Controllers
{
    [Route("api/Facts")]
    public class FactsController : Controller
    {

        private readonly FactsContext _context;

        public FactsController(FactsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Fact> Get()
        {
            return _context.Facts.ToList();
        }

        [HttpGet("{id}")]
        public Fact Get(int id)
        {
            return _context.Facts.First(f => f.ID == id);
        }

        [HttpPost]
        public String Post([FromBody]Fact fact)
        {
            _context.Facts.Add(fact);
            _context.SaveChanges();
            return "c'est ok";
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Fact fact)
        {
            int a = 0;
            var factFromDB = _context.Facts.First(f => f.ID == id);
            factFromDB.Title = fact.Title;
            factFromDB.Content = fact.Content;
            factFromDB.IsValidated = fact.IsValidated;
            factFromDB.IsFake = fact.IsFake;
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var factFromDB = _context.Facts.First(f => f.ID == id);
            _context.Remove(factFromDB);
            _context.SaveChanges();
        }

        public class FactPost
        {
            public String Title { get; set; }
            public String Content { get; set; }
        }

    }
}