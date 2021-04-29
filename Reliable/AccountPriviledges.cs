using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reliable
{

    //The below class is used to identify which modules in the main menu of the program (Reliable.cs) that the user has access to based on the account used for login
    public class AccountPriviledges
    {
        private static bool accountsPayable;
        private static bool generalLedger;
        private static bool sales;
        private static bool management;
        private static bool warehouse;
        private static bool adminFlag;


        public static void setAP(bool x)
        {
            accountsPayable = x;
        }
        public static void setGL(bool x)
        {
            generalLedger = x;
        }
        public static void setSales(bool x)
        {
            sales = x;
        }
        public static void setManage(bool x)
        {
            management = x;
        }
        public static void setWarehouse(bool x)
        {
            warehouse = x;
        }
        public static void setAdminFlag(bool x)
        {
            adminFlag = x;
        }


        public static bool getAP()
        {
            return accountsPayable;
        }
        public static bool getGL()
        {
            return generalLedger;
        }
        public static bool getSales()
        {
            return sales;
        }
        public static bool getManage()
        {
            return management;
        }
        public static bool getWarehouse()
        {
            return warehouse;
        }
        public static bool getAdminFlag()
        {
            return adminFlag;
        }
    }
}
