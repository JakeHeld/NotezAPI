using System;

namespace NotezAPI.Data.Entities.Note
{
    public class Note
    {
        public Guid Id { get; set; }
        
        public string NoteContent { get; set; }
        
        public DateTimeOffset CreationDate { get; set; }
        
        public NoteType Type { get; set; }
        
        public virtual Guid LectureId { get; set; }
        public virtual int UserId { get; set; }
        public virtual User.User User { get; set; }
    }

    public enum NoteType
    {
        MainIdea,
        Normal,
        Summary
    }
}