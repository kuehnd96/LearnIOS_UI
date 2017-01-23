using System;

namespace TablesAndCells.Data
{
    public sealed class GroceryItem
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Department { get; private set; }

        public GroceryItem(string name, double price, string department)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrEmpty(department))
            {
                throw new ArgumentNullException(nameof(department));
            }

            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative.", nameof(price));
            }

            Name = name;
            Price = price;
            Department = department;
        }
    }
}