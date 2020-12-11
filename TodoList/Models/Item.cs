using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Guid UserGuid { get; set; }
        public DateTime dateTime { get; set; }
    }
}