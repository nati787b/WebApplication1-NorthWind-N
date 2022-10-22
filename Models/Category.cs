// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1_NorthWind_N.Models
{
    public class Category
    {
        // class variables 
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        // gets and sets 
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // constructors
        public Category() : this(-1, "n/a", "n/a")
        {
            //empty constructor
        }
        public Category(string aCategoryname) : this(-1, aCategoryname, "n/a")
        {
            //partial consstructor
        }
        public Category(int aCategoryid, string aCategoryName, string aDescription)
        {
            this.CategoryId = aCategoryid;
            this.CategoryName = aCategoryName;
            this.Description = aDescription;
        }
        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "Category Id:" + this.CategoryId + "\n";
            msg = msg + "Category Name:" + this.CategoryName + "\n";
            msg = msg + "Description:" + this.Description + "\n";
            return msg;
        }
    }
}
