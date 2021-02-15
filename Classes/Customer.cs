using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //field
        //public string FirstName;

        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string TcNo { get { return "TcNo : "+_tcNo; } set { _tcNo = value; } }

        //public string TcNo { get { return _tcNo; } set { _tcNo = value; } }
        string _tcNo;

    }
}
