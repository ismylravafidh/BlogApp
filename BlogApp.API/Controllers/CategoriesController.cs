using BlogApp.Business.DTOs.CategoryDTOs;
using BlogApp.Business.Service.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _service;

        public CategoriesController(ICategoryService categoryService)
        {
            _service = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var categories = await _service.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, categories);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            Category category = await _service.GetByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, category);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CategoryCreateDto categoryDto)
        {
            await _service.Create(categoryDto);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm]CategoryUpdateDto categoryDto)
        {
            await _service.Update(categoryDto);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _service.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
