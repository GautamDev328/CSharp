using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normal_inheritance_program
{
    public class Bike
    {
        string Bikename;
        string Bikemodel;
        string Bikedesign;
        int  Bikewheel;
       string Bikecolor;

        public Bike( string Bn, string Bm, string Bd,int Bw,string Bc)
        {
            Bikename = Bn;
            Bikemodel = Bm;
            Bikedesign = Bd;
            Bikewheel = Bw;
            Bikecolor = Bc;

            Console.WriteLine( Bn+ " " + Bm + " " + Bd + " " + Bw+" "+Bc );
           // Console.WriteLine(Bikename+" "+Bikemodel+" "+Bikedesign+" "+Bikewheel+" "+Bikecolor);
        }


        public static void Main(string[] args)
        {
            Bike b = new Bike("HeroHounda","Hounda240","Diamond",2,"Red");
            //b.Bikename = "HeroHounda";
            Console.ReadLine();
        }

        
    }
}

    