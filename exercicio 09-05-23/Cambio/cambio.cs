using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio
{
   public static class Cambi{
    public static double moeda{ get; set; }
    public static double value;

    public static double Realtodolar (double real)
    {
       moeda = real ;
       double dolar = value*0.20 ;
       return dolar;

    }
    public static double DolartoReal(double dolar)
    {
        moeda = dolar ;
       double real = value*4.99 ;
       return real;
    }
   } 
}