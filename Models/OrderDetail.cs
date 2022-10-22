// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1_NorthWind_N.Models
{
    public class OrderDetail
    {
        // class variables
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = double.MaxValue;
        private int quantity = 0;
        private double discount = 0.0;
        // gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                { this.orderId = value; }
            }
        }
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                { this.productId = value; }
            }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0.0)
                { this.unitPrice = value; }
            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                { this.quantity = value; }
            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                if (value > 0.0)
                { this.discount = value; }
            }
        }

        // constructors
        public OrderDetail() : this(-1, -1, 0.0, 0, 0.0)
        {
            //empty constructor
        }

        public OrderDetail(int aOrderId, int aProductId, double aUnitPrice) : this(aOrderId, aProductId, aUnitPrice, 0, 0.0)
        {
            //partial constructor
        }


        // full constructor
        public OrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {
            this.OrderId = aOrderId;
            this.ProductId = aProductId;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }
        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "OrderId:" + this.OrderId + "\n";
            msg = msg + "ProductId:" + this.ProductId + "\n";
            msg = msg + "UnitPrice:" + this.UnitPrice + "\n";
            msg = msg + "Quantity:" + this.Quantity + "\n";
            msg = msg + "Discount:" + this.Discount + "\n";
            return msg;
        }
    }
}
