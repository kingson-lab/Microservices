using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CategoryService.Models;

namespace CategoryService.Repository
{
    public interface ICategoryRepository
    {
        Category CreateCategory(Category category);
        bool DeleteCategory(string categoryId);
        bool UpdateCategory(string categoryId,Category category);
        Category GetCategoryById(string categoryId);
        List<Category> GetAllCategoriesByUserId(string userId);
    }
}
