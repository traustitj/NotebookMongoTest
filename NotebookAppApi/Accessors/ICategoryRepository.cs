using NotebookAppApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Accessors
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategory(string id);
        Task AddCategory(Category item);
        Task<bool> RemoveCategory(string id);
        Task<bool> UpdateCategory(string id, string body);
        Task<bool> RemoveAllCategories();
    }
}
