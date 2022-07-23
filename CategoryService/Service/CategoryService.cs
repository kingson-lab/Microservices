using System;
using System.Collections.Generic;
using CategoryService.Models;
using CategoryService.Repository;
using CategoryService.Exceptions;
using MongoDB.Driver;
using System.Linq;

namespace CategoryService.Service
{
    public class CategoryService : ICategoryService
    {
        //define a private variable to represent repository
        private readonly ICategoryRepository _categoryRepository;

        //Use constructor Injection to inject all required dependencies.
        public CategoryService(ICategoryRepository _repository)
        {
            _categoryRepository = _repository;
        }

        //This method should be used to save a new category.
        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }
        //This method should be used to delete an existing category.
        public bool DeleteCategory(string categoryId)
        {
            return _categoryRepository.DeleteCategory(categoryId);
        }
        // This method should be used to get all category by userId
        public List<Category> GetAllCategoriesByUserId(string userId)
        {
            return _categoryRepository.GetAllCategoriesByUserId(userId);
        }
        //This method should be used to get a category by categoryId.
        public Category GetCategoryById(string categoryId)
        {
            return _categoryRepository.GetCategoryById(categoryId);
        }
        //This method should be used to update an existing category.
        public bool UpdateCategory(string categoryId, Category category)
        {
            return _categoryRepository.UpdateCategory(categoryId, category);
        }
    }
}
