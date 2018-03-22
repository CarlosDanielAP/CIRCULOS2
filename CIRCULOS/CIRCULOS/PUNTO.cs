using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCULOS
{
    class Punto
    {
         
        private double _x;
        private double _y;

        public Punto()
        {
            _x = 0;
            _y = 0;

        }

        public Punto(double Coorx, double Coory)
        {
            _x = Coorx;
            _y = Coory;

        }

        public void valores(double Coorx, double Coory)
        {
            _x = Coorx;
            _y = Coory;
        }
        public double x
        {
            set { _x = value; }
            get { return _x; }
        }
        public double y
        {
            set { _y = value; }
            get { return _y; }
        }
    }
}

 