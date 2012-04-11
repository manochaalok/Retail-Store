using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace RetailStore
{
    static public class getData
    {
        public static Hashtable getDiscountData( Hashtable dtDiscountData)
        {   //This function fill the <<CustomerType - Discount%age>> Criteria one time (from database table when connected with database)
            dtDiscountData.Add("Employee", 30);
            dtDiscountData.Add("Affiliate", 10);
            dtDiscountData.Add("ExistingCustomerMoreThanTwoyrs", 5);
            dtDiscountData.Add("NonExistingCust", 0);
            return dtDiscountData;
        }
        
        public static string getCustomerType(string strCustID)
        {
            // This function is created to get customer specific information based on customerId
            //Replacing Database with Hashtable
            Hashtable dtCustomerType = new Hashtable();
            dtCustomerType.Add("11111", "Employee");
            dtCustomerType.Add("22222", "Affiliate");
            dtCustomerType.Add("33333", "ExistingCustomerMoreThanTwoyrs");
            return (dtCustomerType[strCustID] != null ? dtCustomerType[strCustID].ToString() : "NonExistingCust");
        }
    }
}
