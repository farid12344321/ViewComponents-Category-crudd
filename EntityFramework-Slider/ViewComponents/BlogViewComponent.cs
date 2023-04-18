using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.Services.Interface;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Slider.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(new BlogVm { Blogs = await _blogService.GettAll() , BlogHeader = await _blogService.GetBlogHeader() }));
        }
    }
}
