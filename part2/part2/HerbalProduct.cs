using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class HerbalProduct:Product
    {
        // Derived class: HerbalProduct

        // Additional fields for HerbalProduct
        public string herbsUsed;
        public DateTime mfDate;
        public DateTime expDate;

        // Constructor to set default values and call base class constructor
        public HerbalProduct() : base()
        {
            herbsUsed = "Default Herbs";
            mfDate = DateTime.Now;
            expDate = DateTime.Now;
        }

        // Override base class method to add details of HerbalProduct fields
        public override void ShowDetails()
        {
            base.ShowDetails(); // Call base class method
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacturing Date: {mfDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Expiry Date: {expDate.ToString("yyyy-MM-dd")}");
        }

        // Override base class method to add details of HerbalProduct fields
        public void SetInformation(int id, string name, double price, string herbs, DateTime manufacturingDate, DateTime expiryDate)
        {
            base.SetInformation(id, name, price); // Call base class method
            herbsUsed = herbs;
            mfDate = manufacturingDate;
            expDate = expiryDate;
        }
    }




}

