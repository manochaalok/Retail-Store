using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    class CustomerInfo
    {
        private int _CustomerId;
        private double _GrocAmount;
        private double _NonGrocAmount;
        private int _PercDiscount;
        private double _TotalAmount;
        private double _NetAmount;
        private double _CashDiscount;

        
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        public double GrocAmount
        {
            get { return _GrocAmount; }
            set { _GrocAmount = value; }
        }
        public double NonGrocAmount
        {
            get { return _NonGrocAmount; }
            set { _NonGrocAmount = value; }
        }
        public int PercDiscount
        {
            get { return _PercDiscount; }
            set { _PercDiscount = value; }
        }
        public double TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }
        public double NetAmount
        {
            get { return _NetAmount; }
            set { _NetAmount = value; }
        }
        public double CashDiscount
        {
            get { return _CashDiscount; }
            set { _CashDiscount = value; }
        }


    }
}


