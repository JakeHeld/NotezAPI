using System;
namespace NotezAPI.Data.Entities.Note
{
    public class Summary
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public string Content { get; set; }
        
        public virtual int UserId { get; set; }
        public virtual User.User User { get; set; }
        
        public virtual int LectureId { get; set; }
        public virtual Lecture.Lecture Lecture { get; set; }
    }
}