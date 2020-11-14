using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotezAPI.Data;
using NotezAPI.Data.Entities.Note;
using NotezAPI.Data.Entities.Role;
using NotezAPI.Features.Note;

namespace NotezAPI.Controllers
{
    [ApiController]
    [Route("api/note")]
    public class NoteController: ControllerBase
    {
        private readonly DataContext dataContext;

        public NoteController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpPost("normal")]
        [Authorize(Roles = Roles.StudentPlus)]
        public ActionResult Createn(CreateNoteDto targetValue)
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userId = int.Parse(userIdString);
            
            var data = dataContext.Set<Note>();

            data.Add(new Note
            {
                UserId = userId,
                NoteContent = targetValue.Content,
                Type = NoteType.Normal,
                CreationDate = DateTimeOffset.Now,
                LectureId = targetValue.LectureId
            });

            return Ok();
        }
        
        
        [HttpPost("main-idea")]
        [Authorize(Roles = Roles.StudentPlus)]
        public ActionResult CreateMI(CreateNoteDto targetValue)
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userId = int.Parse(userIdString);
            
            var data = dataContext.Set<Note>();

            data.Add(new Note
            {
                UserId = userId,
                NoteContent = targetValue.Content,
                Type = NoteType.MainIdea,
                CreationDate = DateTimeOffset.Now,
                LectureId = targetValue.LectureId
            });

            return Ok();
        }
        
        
        
        [HttpPost("summary")]
        [Authorize(Roles = Roles.StudentPlus)]
        public ActionResult CreateS(CreateNoteDto targetValue)
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userId = int.Parse(userIdString);
            
            var data = dataContext.Set<Note>();

            data.Add(new Note
            {
                UserId = userId,
                NoteContent = targetValue.Content,
                Type = NoteType.Summary,
                CreationDate = DateTimeOffset.Now,
                LectureId = targetValue.LectureId
            });

            return Ok();
        }
    }
}