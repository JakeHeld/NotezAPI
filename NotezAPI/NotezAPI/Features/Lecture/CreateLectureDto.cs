using System;

namespace NotezAPI.Features.Lecture
{
    public class CreateLectureDto
    {
        public string MeetingUrl { get; set; }
        public string Topic { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}