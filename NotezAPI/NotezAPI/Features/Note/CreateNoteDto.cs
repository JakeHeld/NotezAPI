using System;
using NotezAPI.Data.Entities.Note;

namespace NotezAPI.Features.Note
{
    public class CreateNoteDto
    {
        public string Content { get; set; }
        public Guid LectureId { get; set; }
    }
}