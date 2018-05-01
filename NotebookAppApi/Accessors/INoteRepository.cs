using NotebookAppApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Accessors
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task<Note> GetNote(string id);
        Task AddNote(Note item);
        Task<bool> RemoveNote(string id);
        Task<bool> UpdateNote(string id, string body);
        Task<bool> UpdateDocument(string id, Note item);
        Task<bool> RemoveAllNotes();
    }
}
