using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210113
{
    [Route("api/Movies")]
    [ApiController]
    public class Movie1
    {
        public static List<Movie> data = new List<Movie>
        {
            new Movie("The Shawshank Redemption", " Frank Darabont", ("Tim Robbins", " Morgan Freeman", "William Sadler"), "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie("The Godfather", " Francis Ford Coppola", (" Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"), "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Peter Jackson", (" Elijah Wood", "SViggo Mortensen", "Ian McKellen", "Orlando Bloom"), "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
        };
        [HttpGet] //Untuk get semua
        public IEnumerable<Movie> Get()
        {
            return data;
        }

        [HttpGet("[id]")] //Untuk get pake ID
        public Movie Get(int id)
        {
            if (id < 0 || id >= data.Count)
            {
                NotFound();
            }
            return data[id];
        }
        [HttpPost] //Untuk Post
        public void Post([FromBody] Movie movie)
        {
            data.Add(movie);
        }

        [HttpDelete("[id]")] //Untuk delete
        public void Delete(int id)
        {
            if (id < 0 || id >= data.Count)
            {
                NotFound();
            }
            data.RemoveAt(id);
        }

        private void NotFound()
        {
            throw new NotImplementedException();
        }


    }
}

