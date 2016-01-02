using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateForListItemsExample.Models;
using Windows.UI;

namespace TemplateForListItemsExample.ViewModels
{
    public class ItemsViewModel
    {
        public List<Item> Items { get; set; }

        public ItemsViewModel()
        {
            Items = new List<Item>
            {
                new Item { Title = "Denver", SymbolColor = Colors.Red },
                new Item { Title = "Easy", SymbolColor = Colors.Green },
                new Item { Title = "Frank", SymbolColor = Colors.Blue }
            };
        }
    }
}
