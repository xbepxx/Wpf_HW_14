using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_14
{
    public enum CategoryProduct
    {
        Food,
        Technic
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image1 { get; set; }
        public CategoryProduct CategoryProduct { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
