﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidang_datar
{
    public class Bangun
    {
        public double persegi(double x)
        {
            return (x * x);

            
            
        }
        public double keliling_persegi(double x)
        {
            return (x * 4);


        }
        public double persegi_panjang(double x, double y)
        {
            return (x * y);
        }
        public double keliling_persegipanjang(double x, double y)
        {
            return (x * y * 2);



        }
        public double segitiga(double x, double y)
        {
            return (x * y / 2);
        }
        public double keliling_segitiga(double x, double y, double z)
        {
            return (x + y + z);


        }
    }
}