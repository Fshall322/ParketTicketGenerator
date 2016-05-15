using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParketTicketGenerator
{
    public class Car
    {
        private String _make;
        private String _model;
        private String _color;
        private String _plateNum;
        private String _year;

        public Car()
        {
            _make = "";
            _model = "";
            _color = "";
            _plateNum = "";
            _year = "";
        }

        public String Make
        {
            get{ return _make; }
            set{ _make = value; }
        }

        public String Model
        {
            get{ return _model; }
            set{ _model = value; }
        }

        public String Color
        {
            get{ return _color; }
            set{ _color = value; }
        }

        public String PlateNumber
        {
            get { return _plateNum; }
            set { _plateNum = value; }
        }

        public String Year
        {
            get { return _year; }
            set { _year = value; }

        }
    }
}
