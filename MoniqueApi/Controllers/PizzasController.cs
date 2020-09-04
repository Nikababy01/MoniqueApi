using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoniqueApi.Models;

namespace MoniqueApi.Controllers
{
    // these are attributes:
    //adds where this should be exposed on the internet/ replace [controller] with pizzas below
    //[Route("api/[controller]")]
    // returns JSON data
    [Route("api/pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        List<Pizza> _pizzas;
        public PizzasController()
        {
            //breaking out the below
            var pizza = new Pizza { Id = 1, Size = "Medium", Toppings = new List<string> { "Pepperoni" } };
            var pizza2 = new Pizza { Id = 2, Size = "Medium", Toppings = new List<string> { "Sausage" } };
            var pizza3 = new Pizza { Id = 3, Size = "Medium", Toppings = new List<string> { "Mushroom" } };

            _pizzas = new List<Pizza> { pizza, pizza2, pizza3 };

        }
        //method GetAllPizzas, does not need any parms, we just return the list of pizzas
        //create the Model folder to hold the class for pizza
        [HttpGet]
        public List<Pizza> GetAllPizzas()
        {
            //other way of writing this
            //var pizza = new Pizza { Id = 1, Size = "Medium", Toppings = new List<string> { "Pepperoni" } };
            //var pizza2 = new Pizza { Id = 2, Size = "Medium", Toppings = new List<string> { "Sausage" } };
            //var pizza3 = new Pizza { Id = 3, Size = "Medium", Toppings = new List<string> { "Mushroom" } };
            // return new List<Pizza> {pizza,pizza2,pizza3};
            return _pizzas;
        }
        // get a single pizza

        [HttpGet("{id}")]
        public IActionResult GetPizzaById(int id)
        {
            var result = _pizzas.SingleOrDefault(pizza => pizza.Id == id);
            if (result == null)
            {
                return NotFound($"Could not find a pizza with the id {id}");
            }

            return Ok(result);
        }
    }
}

