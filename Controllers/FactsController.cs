using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aminofakeApi.Models;

namespace aminofakeApi.Controllers
{
    [Route("api/[controller]")]
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
            return _context.Facts.First(c => c.ID == id);
        }

        public String CreateFact(Fact fact)
        {
            _context.Facts.Add(fact);
            return "c'est ok";
        }
    }
}