namespace Service.Services.DTOs.Movie
{
    public class MovieUpdateDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Poster { get; set; }
        public byte[]? Photo { get; set; }
        public int Length { get; set; }
        public int ReleaseYear { get; set; }
        public string? Country { get; set; }
        public int MovieCategoryId { get; set; }
    }
}
