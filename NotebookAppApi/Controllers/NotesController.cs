using Microsoft.AspNetCore.Mvc;
using NotebookAppApi.Accessors;
using NotebookAppApi.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotebookAppApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public NotesController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        [HttpGet]
        public string Get() //async Task<IEnumerable<Note>> Get()
        {
            return "Hello world";
        }

        [HttpGet("{id}")]
        public async Task<Note> Get(string id)
        {
            return await _noteRepository.GetNote(id) ?? new Note();
        }

        [HttpPost]
        public void Post([FromBody] Note newNote)
        {
            _noteRepository.AddNote(new Note
            {
                Id = newNote.Id,
                Body = newNote.Body,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                UserId = newNote.UserId
            });
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value)
        {
            _noteRepository.UpdateNote(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _noteRepository.RemoveNote(id);
        }
    }
}
