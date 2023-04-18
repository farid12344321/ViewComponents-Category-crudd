using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.Services.Interface
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GettAll();
        Task<BlogHeader> GetBlogHeader();
    }
}
