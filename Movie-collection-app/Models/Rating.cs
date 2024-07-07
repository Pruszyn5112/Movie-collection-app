namespace Movie_collection_app.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Score { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
