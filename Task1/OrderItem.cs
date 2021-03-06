﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApplication
{
    class OrderItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public OrderItem(int itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }

        public override string ToString()
        {
            return "Item ID: " + ItemId + " Item name: " + ItemName;
        }
    }
}
