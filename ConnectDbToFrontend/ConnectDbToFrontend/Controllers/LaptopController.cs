using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectDbToFrontend.Models;
using ConnectDbToFrontend.Models.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectDbToFrontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        private readonly LaptopDbContext _laptopDbContext;
        public LaptopController(LaptopDbContext laptop)
        {
            _laptopDbContext = laptop;
        }



        // GET: api/Laptop
        [HttpGet]
        public IActionResult Get()
        {
            var getLaptops = _laptopDbContext.Laptop.ToList();
            return Ok(getLaptops);
        }

        //Get method for fetching data from single id
        [HttpGet ("{id:int}")]
        public IActionResult Get2(int id)
        {
            try
            {
                var response = _laptopDbContext.Laptop.First(obj => obj.LaptopId == id);
                if (response == null)
                    return NotFound();
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error! The laptop you are looking for does not exist in the database");
            }
        }




        // GET: api/Laptop/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/


        //post method for inserting data into single row

        // POST: api/Laptop
        [HttpGet("Laptop/{value}")]
        public IActionResult Get(string value)
        {



            var result = _laptopDbContext.Laptop.Where(obj => obj.LaptopName.Contains(value));
            return Ok(result);



        }


        [HttpPost]
        public void Post([FromBody] LaptopRequest value)
        {
            Laptop obj = new Laptop();
            obj.LaptopName = value.LaptopName;
            obj.LaptopBrand = value.LaptopBrand;
            obj.LaptopSize = value.LaptopSize;
            obj.LaptopStorage = value.LaptopStorage;
            obj.LaptopPrice = value.LaptopPrice;
            _laptopDbContext.Laptop.Add(obj);
            _laptopDbContext.SaveChanges();
        }

        // PUT: api/Laptop/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
