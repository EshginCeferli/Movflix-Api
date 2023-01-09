using Service.Services.DTOs.MovieCategory;

namespace Service.Services.DTOs.Movie
{
    public class MovieListDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Poster { get; set; }
        public byte[]? Photo { get; set; }
        public int Length { get; set; }
        public string? Country { get; set; }
        public int ReleaseYear { get; set; }
        public int MovieCategoryId { get; set; }
        public MovieCategoryListDto? MovieCategory { get; set; }
    }
  
}
