using Microsoft.AspNetCore.Mvc;
using NotebookAppApi.Accessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Controllers
{
    [Route("api/[controller]")]
    public class SystemController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public SystemController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        [HttpGet("{setting}")]
        public string Get(string setting)
        {
            if (setting == "init")
            {
                _noteRepository.RemoveAllNotes();
                for (var i = 1; i < 5; i++)
                {
                    _noteRepository.AddNote(new Model.Note() { Id = $"{i}", Body = $"Test note {i}" });
                }

                return "Done";
            }
            return "Unknown";
        }
    }
}
