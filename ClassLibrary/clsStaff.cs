using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary 
{

    public class clsStaff
    {
        private Int32 mStaffID;
        public string StaffAddress { get; set; }
        public string StaffContactNo { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public int StaffID { get; set; }

        public bool Find(int staffID)
        {
            return true;
        }
    }

    public class clsStock
    {
    }
}
