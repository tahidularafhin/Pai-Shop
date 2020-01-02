using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPaiShop.Models;

namespace BethanysPaiShop.ViewModels
{
    public class HomeViewModel
    { 
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
