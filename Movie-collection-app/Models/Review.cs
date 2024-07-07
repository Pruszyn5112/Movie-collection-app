namespace Movie_collection_app.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
