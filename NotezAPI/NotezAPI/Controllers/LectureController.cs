using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotezAPI.Data;
using NotezAPI.Data.Entities.Lecture;
using NotezAPI.Data.Entities.Role;
using NotezAPI.Features.Lecture;

namespace NotezAPI.Controllers
{
    [ApiController]
    [Route("api/lecture")]
    public class LectureController: ControllerBase
    {
        private readonly DataContext dataContext;

        public LectureController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpPost]
        [Authorize(Roles = Roles.Lecturer)]
        public ActionResult Create(CreateLectureDto targetValue)
        {
            var data = dataContext.Set<Lecture>();
            data.Add(
                new Lecture 
                    { MeetingUrl = targetValue.MeetingUrl, 
                        Topic = targetValue.Topic, 
                        StartDate = targetValue.StartDate, 
                        EndDate = targetValue.EndDate
                    });
            dataContext.SaveChanges();
            return Ok();
        }
    }
}