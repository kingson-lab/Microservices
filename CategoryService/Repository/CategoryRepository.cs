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
        private readonly CategoryContext categoryContext;

        public CategoryRepository(CategoryContext _context)
        {
            categoryContext = _context;
        }

        //This method should be used to save a new category.
        public Category CreateCategory(Category category)
        {
            categoryContext.Category.InsertOne(category);
            return category;
        }

        //This method should be used to delete an existing category.
        public bool DeleteCategory(string categoryId)
        {
            var result =  categoryContext.Category.DeleteOne(Category => Category.Id == categoryId);
            if(result.IsAcknowledged && result.DeletedCount>0)
            {
                return true;
            }
            return false;
        }

        //This method should be used to get all category by userId
        public List<Category> GetAllCategoriesByUserId(string userId)
        {
            var result = categoryContext.Category.Find(Category => Category.CreatedBy == userId).ToList();
            return result;  
        }

        //This method should be used to get a category by categoryId
        public Category GetCategoryById(string categoryId)
        {
            return categoryContext.Category.Find(Category => Category.Id == categoryId).FirstOrDefault();
        }

        // This method should be used to update an existing category.
        public bool UpdateCategory(string categoryId, Category category)
        {
            var result = categoryContext.Category.ReplaceOne(Category => Category.Id == categoryId, category);

            if(result.IsModifiedCountAvailable && result.ModifiedCount > 0)
            {
                return true;
            }
            return false;
                   
        }
    }
}
