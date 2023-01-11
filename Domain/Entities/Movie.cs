using Domain.Common;

namespace Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        //public string? Poster { get; set; }
        public byte[]? Photo { get; set; }
        public int Length { get; set; }
        public int ReleaseYear { get; set; }
        public string? Country { get; set; }
        public float Rating { get; set; }
        public MovieCategory? MovieCategory { get; set; }
        public int MovieCategoryId { get; set; }
        public List<MovieComment>? Comments { get; set; }

    }
}
