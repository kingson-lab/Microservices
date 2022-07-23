using System;
using Microsoft.AspNetCore.Mvc;
using CategoryService.Service;
using CategoryService.Models;
using CategoryService.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace CategoryService.API.Controllers
{
    /*
    As in this assignment, we are working with creating RESTful web service to create microservices, hence annotate
    the class with [ApiController] annotation and define the controller level route as per REST Api standard.
    */
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        /*
     CategoryService should  be injected through constructor injection. Please note that we should not create service
     object using the new keyword
    */
        private readonly ICategoryService _categoryService; 
        public CategoryController(ICategoryService _service)
        {
            _categoryService = _service;    
        }

        /*
	 * Define a handler method which will create a category by reading the
	 * Serialized category object from request body and save the category in
	 * database. This handler method should return any one of the status messages basis on
	 * different situations: 
	 * 1. 201(CREATED - In case of successful creation of the category
	 * 2. 409(CONFLICT) - In case of duplicate categoryId
	 *
	 * 
	 * This handler method should map to the URL "/api/category" using HTTP POST
	 * method".
	 */
        // POST /api/category
        [HttpPost]
        public ActionResult<Category> Post([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            category.CreationDate = DateTime.Now;
            var result = _categoryService.CreateCategory(category);
            return CreatedAtAction(nameof(Post), new { id = result.Id }, result);
        }


        /*
         * Define a handler method which will delete a category from a database.
         * 
         * This handler method should return any one of the status messages basis on
         * different situations: 1. 200(OK) - If the category deleted successfully from
         * database. 2. 404(NOT FOUND) - If the category with specified categoryId is
         * not found. 
         * 
         * This handler method should map to the URL "/api/category/{id}" using HTTP Delete
         * method" where "id" should be replaced by a valid categoryId without {}
         */
        // DELETE api/category/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var category = _categoryService.GetCategoryById(id);

            if (category == null)
            {
                return NotFound($"category with Id = {id} not found");
            }

            _categoryService.DeleteCategory(category.Id);

            return Ok($"Category with Id = {id} deleted");
        }

        /*
         * Define a handler method which will update a specific category by reading the
         * Serialized object from request body and save the updated category details in
         * database. This handler method should return any one of the status
         * messages basis on different situations: 1. 200(OK) - If the category updated
         * successfully. 2. 404(NOT FOUND) - If the category with specified categoryId
         * is not found. 
         * This handler method should map to the URL "/api/category/{id}" using HTTP PUT
         * method.
         */
        // PUT /api/category/{id}
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Category category)
        {
            var existingCategory = _categoryService.GetCategoryById(id);

            if (existingCategory == null)
            {
                return NotFound($"Category with Id = {id} not found");
            }
            bool result =_categoryService.UpdateCategory(id, category);
            if (result)
            {
                return Ok($"Category with Id = {id} Updated");
            }
            return Ok("NO Content Updated.");
        }



        /*
         * Define a handler method which will get us the category by a userId.
         * This handler method should return any one of the status messages basis on
         * different situations: 1. 200(OK) - If the category found successfully. 
         * This handler method should map to the URL "/api/category/{userId}" using HTTP GET method
         */
        // GET /api/category/{userId}
        [HttpGet("GetByUserId/{Id}")]
        public ActionResult<List<Category>> GetUserId(string Id)
        {
            var category = _categoryService.GetAllCategoriesByUserId(Id);
            if (category.Count == 0)
            {
                return NotFound($"Category with userId = {Id} not found");
            }
            return category;
        }


        /*
     * Define a handler method which will get us the category by a categoryId.
     * This handler method should return any one of the status messages basis on
     * different situations: 1. 200(OK) - If the category found successfully. 
     * This handler method should map to the URL "/api/category/{categoryId}" using HTTP GET method. categoryId must be an integer
     */
        // GET /api/category/{userId}
        [HttpGet("GetByCategoryId/{Id}")]
        public ActionResult<Category> GetByCategoryId(string Id)
        {
            var category = _categoryService.GetCategoryById(Id);
            if (category == null)
            {
                return NotFound($"Category with categoryId = {Id} not found");
            }
            return category;
        }
    }
}
