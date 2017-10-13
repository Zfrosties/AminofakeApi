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

        public List<Fact> GetFacts()
        {
            return _context.Facts.ToList();
        }

        public String CreateFact(Fact fact)
        {
            _context.Facts.Add(fact);
            return "c'est ok";
        }
    }
}