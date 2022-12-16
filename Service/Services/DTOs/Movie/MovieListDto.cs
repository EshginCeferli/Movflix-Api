using Domain.Entities;
using Service.Services.DTOs.MovieCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Movie
{
    public class MovieListDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Poster { get; set; }
        public int Length { get; set; }
        public string? Country { get; set; }
        public int MovieCategoryId { get; set; }
        public MovieCategoryListDto? MovieCategory { get; set; }
    }
    //public class MovieCategoryGetAllDto
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //}
}
