using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Size { get; set; }    //Enum with size

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public bool IsAvailable { get; set; } = true;

        public Category Category { get; set; }

        public int MyProperty { get; set; }   // TO DO  

        public int MyProperty1 { get; set; }   // TO DO
    }
}
