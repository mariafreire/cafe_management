using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Cafe_Management_System
{
    class Cafe
    {
        
        //Default construct
        public Cafe()
        {
            newcf_latte = 0.0;
            newcf_ilatte = 0.0;
            newcf_capp = 0.0;
            newcf_icapp = 0.0;
            newcf_african = 0.0;
            newcf_american = 0.0;
            newcf_vale = 0.0;
            newcf_espresso = 0.0;
            newck_coffee = 0.0;
            newck_velvet = 0.0;
            newck_florest = 0.0;
            newck_latte = 0.0;
            newck_carlton = 0.0;
            newck_kilburn = 0.0;
            newck_lagos = 0.0;
            newck_boston = 0.0;

        }

        //overload constructor
        public Cafe(double cf_latte, double cf_ilatte, double cf_capp, double cf_icapp,
            double cf_african, double cf_american, double cf_vale, double cf_espresso,
            double ck_coffee, double ck_velvet, double ck_florest, double ck_latte,
            double ck_carlton, double ck_kilburn, double ck_lagos, double ck_boston)
        {
            newcf_latte = cf_latte;
            newcf_ilatte = cf_ilatte;
            newcf_capp = cf_capp;
            newcf_icapp = cf_icapp;
            newcf_african = cf_african;
            newcf_american = cf_american;
            newcf_vale = cf_vale;
            newcf_espresso = cf_espresso;
            newck_coffee = ck_coffee;
            newck_velvet = ck_velvet;
            newck_florest = ck_florest;
            newck_latte = ck_latte;
            newck_carlton = ck_carlton;
            newck_kilburn = ck_kilburn;
            newck_lagos = ck_lagos;
            newck_boston = ck_boston;
        }

        //accessor funtion
        public double getLatte()
        {
            return newcf_latte;
        }

        public double getIlatte()
        {
            return newcf_ilatte;
        }

        public double getCapp()
        {
            return newcf_capp;
        }

        public double getIcapp()
        {
            return newcf_icapp;
        }

        public double getAfrican()
        {
            return newcf_african;
        }

        public double getAmerican()
        {
            return newcf_american;
        }

        public double getVale()
        {
            return newcf_vale;
        }

        public double getEspresso()
        {
            return newcf_espresso;
        }

        public double getCoffee()
        {
            return newck_coffee;
        }

        public double getVelvet()
        {
            return newck_velvet;
        }

        public double getFlorest()
        {
            return newck_florest;
        }

        public double getLatte1()
        {
            return newck_latte;
        }

        public double getCarlton()
        {
            return newck_carlton;
        }

        public double getKilburn()
        {
            return newck_kilburn;
        }

        public double getLagos()
        {
            return newck_lagos;
        }

        public double getBoston()
        {
            return newck_boston;
        }


        //member variables declared for coffe
        private double newcf_latte;
        private double newcf_ilatte;
        private double newcf_capp;
        private double newcf_icapp;
        private double newcf_african;
        private double newcf_american;
        private double newcf_vale;
        private double newcf_espresso;
        //member variables declared for cake
        private double newck_coffee;
        private double newck_velvet;
        private double newck_florest;
        private double newck_latte;
        private double newck_carlton;
        private double newck_kilburn;
        private double newck_lagos;
        private double newck_boston;
    }
}
