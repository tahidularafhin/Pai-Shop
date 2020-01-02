using System.Collections.Generic;
using BethanysPaiShop.Models;

namespace BethanysPaiShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
