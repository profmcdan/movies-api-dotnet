using System;
using System.Collections.Generic;
using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();
        public Genre GetGenreById(int id);
    }
}
