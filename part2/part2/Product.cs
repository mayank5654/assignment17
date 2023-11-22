using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Product
    {
        // Base class: Product
        // Base class: Product
        
            // Fields
            public int pid;
            public string pname;
            public double pprice;

            // Constructor to set default values
            public Product()
            {
                pid = 0;
                pname = "Default Product";
                pprice = 0.0;
            }

            // Method to show details of the product
            public virtual void ShowDetails()
            {
                Console.WriteLine($"Product ID: {pid}");
                Console.WriteLine($"Product Name: {pname}");
                Console.WriteLine($"Product Price: ${pprice}");
            }

            // Method to set information for the product
            public void SetInformation(int id, string name, double price)
            {
                pid = id;
                pname = name;
                pprice = price;
            }
        

    }
}
