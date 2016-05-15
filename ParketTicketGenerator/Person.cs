using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParketTicketGenerator
{
    public class Person
    {
        private String _userFName;
        private String _userLName;

        public Person()
        {
            _userFName = "";
            _userLName = "";
        }

        public String UserFName
        {
           get {return _userFName;}
           set { _userFName = value;} 
        }

        public String UserLName
        {
            get { return _userLName; }
            set { _userLName = value; }            
        }
    }
}
