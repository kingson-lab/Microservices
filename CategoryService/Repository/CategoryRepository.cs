using System;
using System.Collections.Generic;
using System.Linq;
using CategoryService.Models;
using MongoDB.Driver;

namespace CategoryService.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        //define a private variable to represent CategoryContext

        public CategoryRepository(CategoryContext _context)
        {
            
        }

        //This method should be used to save a new category.
        public Category CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        //This method should be used to delete an existing category.
        public bool DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        //This method should be used to get all category by userId
        public List<Category> GetAllCategoriesByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        //This method should be used to get a category by categoryId
        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        // This method should be used to update an existing category.
        public bool UpdateCategory(int categoryId, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
