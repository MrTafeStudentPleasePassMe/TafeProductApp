﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
        private decimal totalCharge;
        private decimal wrapCharge;
        private decimal gstCharge;
        decimal gstRate = 1.1m;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public decimal calTotalCharge()
        {
            totalCharge = Price * Quantity + 25;
            return totalCharge;
        }

        public decimal calWrapCharge()
        {
            wrapCharge = totalCharge + 5;
            return wrapCharge;
        }

        public decimal calGstCharge()
        {
            
            gstCharge = wrapCharge * gstRate;
            return gstCharge;
        }
    }
}
