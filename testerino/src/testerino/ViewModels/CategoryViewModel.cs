using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using testerino.Models;

namespace testerino.ViewModels
{
    public class CategoryViewModel
    {
        public List<Inventory> inventories;
        public SelectList categories;
        public string Category { get; set; }
    }
}
