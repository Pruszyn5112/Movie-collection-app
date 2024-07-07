using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Movie_collection_app.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string PosterUrl { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
