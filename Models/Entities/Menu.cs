using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Domain.Entities
{
    public class Menu
    {
        public Guid Id { private set; get; }
        public string Text { private set; get; }
        public int Price { private set; get; }

        public Menu(Guid id, string text, int price)
        {
            Id = id;
            Text = text;
            Price = price;
        }
    }
}
