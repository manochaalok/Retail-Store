using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BO;

namespace RetailStore
{
    class calculateDiscount
    {
        private static calculateDiscount objDiscount;
        static public Hashtable dtDiscountData = new Hashtable();
        CustomerInfo oBALCustomerInfo = new CustomerInfo();
        static int remainder = 0;
        private calculateDiscount() { }

        public static calculateDiscount CreateInstance()
        {
            object myObject = new object();
            lock (myObject)
            {
                if (objDiscount == null)
                {
                    objDiscount = new calculateDiscount();
                    dtDiscountData = getData.getDiscountData(dtDiscountData);
                }
            }
            return objDiscount;
        }
        // public method which will be called
        public int GetPercentageDiscount(string custID)
        {
            int dbDiscount = Convert.ToInt16(dtDiscountData[getData.getCustomerType(custID)].ToString());
            return dbDiscount;
        }
        public static CustomerInfo getNetAmount(CustomerInfo oCustomerInfo)
        {
            oCustomerInfo.TotalAmount = oCustomerInfo.GrocAmount + (oCustomerInfo.NonGrocAmount - (oCustomerInfo.NonGrocAmount * oCustomerInfo.PercDiscount) / 100);
            if (oCustomerInfo.PercDiscount == 0)
            {
                oCustomerInfo.TotalAmount = oCustomerInfo.GrocAmount + oCustomerInfo.NonGrocAmount;
            }
            oCustomerInfo.NetAmount = oCustomerInfo.TotalAmount - Convert.ToDouble((Math.DivRem(Convert.ToInt32(oCustomerInfo.TotalAmount), 100, out remainder) * 5));
            oCustomerInfo.CashDiscount = Convert.ToDouble((Math.DivRem(Convert.ToInt32(oCustomerInfo.TotalAmount), 100, out remainder) * 5));
            return oCustomerInfo;

        }

    }
}
