using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/v1/genres")]
    [ApiController]
    public class GenresController: ControllerBase
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Genre> Get()
        {
            return repository.GetAllGenres();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Genre> GetById(int id)
        {
            var genre = repository.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
    }
            return genre;
        }

        [HttpPost]
        public ActionResult Post()
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
