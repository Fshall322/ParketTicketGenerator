using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParketTicketGenerator
{
        public class Cop
        {
            private String _name;
            private String _badgeNum;

            public Cop()
            {
                _name = " Tom Johson";
                _badgeNum = "C7104";
            }

            public String Name
            {
            //hello
                get { return _name; }
            }

            public String BadgeNumber
            {
                get { return _badgeNum; }
            }
       }
 }
