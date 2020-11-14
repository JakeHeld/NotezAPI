using System;
using System.Collections.Generic;
using NotezAPI.Data.Entities.Note;

namespace NotezAPI.Data.Entities.Lecture
{
    public class Lecture
    {
        public Guid Id { get; set; }
        
        public string MeetingUrl { get; set; }
        public string Topic { get; set; }

        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        //1:M Note stuff
        public virtual List<Summary> Summaries { get; set; }
        public virtual List<MainIdea> MainIdeas { get; set; }

        
        
        //M:M
        public List<User.User> Users{ get; set; }
    }
}