using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NotebookAppApi.Context;
using NotebookAppApi.Model;

namespace NotebookAppApi.Accessors
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NoteContext _context = null;

        //public NoteRepository(IOptions<Settings> settings)
        //{
        //    _context = new NoteContext(settings);
        //}

        public CategoryRepository(IOptions<Settings> settings)
        {
            _context = new NoteContext(settings);
        }

        public Task AddCategory(Category item)
        {
            throw new NotImplementedException();
        }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            try
            {
                var a = await _context.Categories.Find(_ => true).ToListAsync();
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Category> GetCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategory(string id, string body)
        {
            throw new NotImplementedException();
        }
    }
}
