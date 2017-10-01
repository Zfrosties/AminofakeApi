using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aminofakeApi.Models;


namespace aminofakeApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public  IEnumerable<Fact> Get()
        {
            return new Fact[] {
                new Fact { title="zaid est un pd",content="je l'ai vu hihi",validated=true,fake=false },
                new Fact { title="jawad aussi",content="",validated=false }
                };
            //Fact { title="",content="",validated=true,fake=false }, { title="",content="",validated=true,fake=false };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
