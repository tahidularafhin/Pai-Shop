using System.Collections.Generic;

namespace BethanysPaiShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
