using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.Services.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
    }
}
