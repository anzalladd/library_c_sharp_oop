﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bidang_datar;

namespace isibidang_datar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun bangun_datar = new Bangun();
            Console.WriteLine("Luas dan Keliling");
            Console.Write("Input x   : ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Input y   :");
            double y = int.Parse(Console.ReadLine());
            Console.Write("Input z   :");
            double z = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Luas Persegi  =" + bangun_datar.persegi(x));
            Console.WriteLine("");
            Console.WriteLine("Keliling Persegi  =" + bangun_datar.keliling_persegi(x));
            Console.WriteLine("");
            Console.WriteLine("Luas Persegi Panjang  =" + bangun_datar.persegi_panjang(x,y));
            Console.WriteLine("");
            Console.WriteLine("Keliling Persegi Panjang  =" + bangun_datar.keliling_persegipanjang(x, y));
            Console.WriteLine("");
            Console.WriteLine("Luas Segitiga  =" + bangun_datar.segitiga(x, y));
            Console.WriteLine("");
            Console.WriteLine("Keliling Segitiga  =" + bangun_datar.keliling_segitiga(x,y,z));
            Console.WriteLine("");
            Console.ReadLine();



        }
    }
}
