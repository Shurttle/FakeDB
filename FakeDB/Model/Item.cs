using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public static class FakeDatabase
    {
        public static List<Item> Items = new()
        {
        new Item { Id = 1, Name = "Item 1", Description = "Description for Item 1" },
        new Item { Id = 2, Name = "Item 2", Description = "Description for Item 2" },
        new Item { Id = 3, Name = "Item 3", Description = "Description for Item 3" }
        };
    }
}
