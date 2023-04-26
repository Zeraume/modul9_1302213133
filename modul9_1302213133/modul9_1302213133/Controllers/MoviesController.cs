using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302213133.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public static List<Movies> mov = new List<Movies>
        {
            new Movies("The Shawshank Redemption (1994)", "Frank Darabont",
                new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"},
                "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movies("The Godfather",
                "Francis Ford Coppola",
                new List<string>{"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"},
                "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight",
                "Christopher Nolan",
                new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"},
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
        return mov;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return mov[id];
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            mov.Add(value);
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mov.RemoveAt(id);
        }
    }
}
