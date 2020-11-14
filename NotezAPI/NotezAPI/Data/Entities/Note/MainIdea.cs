using System;

namespace NotezAPI.Data.Entities.Note
{
    public class MainIdea
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        
        public virtual int UserId { get; set; }
        public virtual User.User User { get; set; }
    }
}