// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.IO;


namespace WebApplication1_NorthWind_N.Models
{
    public class File_Gateway
    {
        public List<Category> GetCategory(string aPath)
        {
            // Filename Path
            List<Category> aListOfCategories = new List<Category>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Category aCategory;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aCategory = new Category(Convert.ToInt32(aRow[0]), aRow[1], aRow[2]);
                aListOfCategories.Add(aCategory);
                index = index + 1;
            }

            return aListOfCategories;
        }




        public List<Employee> GetEmployee(string aPath)
        {

            // Filename Path
            List<Employee> aListOfEmployees = new List<Employee>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Employee aEmployee;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aEmployee = new Employee(Convert.ToInt32(aRow[0]), aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], 
                    aRow[9], aRow[10], aRow[11], aRow[12], aRow[13], aRow[15],Convert.ToInt32(aRow[16]));
                aListOfEmployees.Add(aEmployee);
                index = index + 1;
            }

            return aListOfEmployees;
        }


        public List<OrderDetail> GetOrderDetail(string aPath)
        {
            // Filename Path
            List<OrderDetail> aListOfOrderDetails = new List<OrderDetail>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            OrderDetail aOrderDetail;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aOrderDetail = new OrderDetail(Convert.ToInt32(aRow[0]), Convert.ToInt32(aRow[1]), Convert.ToDouble(aRow[2]), Convert.ToInt32(aRow[3]), Convert.ToDouble(aRow[4]));
                aListOfOrderDetails.Add(aOrderDetail);
                index = index + 1;
            }

            return aListOfOrderDetails;


        }
        public List<Product> GetProduct(string aPath)
        {
            // Filename Path
            List<Product> aListOfProducts = new List<Product>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Product aProduct;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aProduct = new Product(Convert.ToInt32(aRow[0]), aRow[1], Convert.ToInt32(aRow[2]), Convert.ToInt32(aRow[3]), aRow[4],
                   Convert.ToDouble(aRow[5]), Convert.ToInt32(aRow[6]), Convert.ToInt32(aRow[7]), Convert.ToInt32(aRow[8]), Convert.ToBoolean(aRow[9]));

                aListOfProducts.Add(aProduct);
                index = index + 1;
            }

            return aListOfProducts;
        }
        public List<Shipper> GetShipper(string aPath)
        {

            // Filename Path
            List<Shipper> aListOfShippers = new List<Shipper>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Shipper aShipper;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aShipper = new Shipper(Convert.ToInt32(aRow[0]), aRow[1], aRow[2]);

                aListOfShippers.Add(aShipper);
                index = index + 1;
            }

            return aListOfShippers;



        }
        public List<Supplier> GetSupplier(string aPath)
        {
            // Filename Path
            List<Supplier> aListOfSuppliers = new List<Supplier>();
            string[] allRows;
            int index = 1;
            string[] aRow;
            Supplier aSupplier;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aSupplier = new Supplier(Convert.ToInt32(aRow[0]), aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], aRow[9], aRow[10], aRow[11]);



                aListOfSuppliers.Add(aSupplier);
                index = index + 1;
            }

            return aListOfSuppliers;
        }
    }
}
