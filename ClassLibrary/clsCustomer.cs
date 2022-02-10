using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime CustomerDOB { get; set; }
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAddress { get; set; }

        public void Find(int v)
        {
            throw new NotImplementedException();
        }
    }

}
