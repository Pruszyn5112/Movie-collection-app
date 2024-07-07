namespace Movie_collection_app.Models
{
    public class Friend
    {
        public int FriendshipId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int FriendId { get; set; }
        public User Friend { get; set; }
    }
}
