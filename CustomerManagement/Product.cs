﻿using System;
using Common;

namespace CustomerManagement
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return StringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;
            }
        }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;

            if (CurrentPrice == null)  isValid = false;

            return isValid;
        }
    }
}
