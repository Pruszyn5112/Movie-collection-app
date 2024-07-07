namespace Movie_collection_app.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureUrl { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
