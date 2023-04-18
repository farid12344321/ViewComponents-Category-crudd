using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Slider.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
     
        public async Task<IEnumerable<Blog>> GettAll()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task<BlogHeader> GetBlogHeader()
        {
            return await _context.BlogHeaders.FirstOrDefaultAsync();
        }

    }
}
