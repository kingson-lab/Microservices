using System;
using System.Collections.Generic;
using CategoryService.Models;
using CategoryService.Repository;
using CategoryService.Exceptions;
using MongoDB.Driver;
using System.Linq;

namespace CategoryService.Service
{
    public class CategoryService:ICategoryService
    {
        //define a private variable to represent repository

        //Use constructor Injection to inject all required dependencies.
        public CategoryService(ICategoryRepository _repository)
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
        // This method should be used to get all category by userId
        public List<Category> GetAllCategoriesByUserId(string userId)
        {
            throw new NotImplementedException();
        }
        //This method should be used to get a category by categoryId.
        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }
        //This method should be used to update an existing category.
        public bool UpdateCategory(int categoryId, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
