using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Shoe
    {
        private string type;
        private string gender;
        private string manufacturer;
        private double price;
        private string image;

        public Shoe()
        {
            type = "";
            gender = "";
            manufacturer = "";
            price = 0.00;
            image = "";

        }

        //private double price;
        //private string image;

        public Shoe(string type, string gender, string manufacturer, double price, string image)
        {
            this.type = type;
            this.gender = gender;
            this.manufacturer = manufacturer;
            this.price = price;
            this.image = image;
        }


        public string Type
        {
            get { return type; }
            set { type = value; }

        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }

        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public double calculatePrice()
        {
            double totalPrice = 0;
            if (Type == "Basketball") 
            {
                totalPrice += 15;
            }
            else if (Type == "Casual")
            {
                totalPrice += 10;
            }
            else if (Type == "Hiking")
            {
                totalPrice += 15;
            }
            else if (Type == "Running")
            {
                totalPrice += 20;
            }
            else if (Type == "Dress")
            {
                totalPrice += 25;
            }

            if (Manufacturer == "Nike") {
                totalPrice += 30;
            }
            else if (Manufacturer == "Adidas")
            {
                totalPrice += 25;
            }
            else if (Manufacturer == "Hoka")
            {
                totalPrice += 35;
            }
            else if (Manufacturer == "Vans")
            {
                totalPrice += 15;
            }
            else if (Manufacturer == "Polo")
            {
                totalPrice += 40;
            }

            return totalPrice;




        }
    }
        
}
