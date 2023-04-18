using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class BlogVm
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public BlogHeader BlogHeader { get; set; }

    }
}
