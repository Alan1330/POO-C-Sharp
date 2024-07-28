using System;
using System.Globalization;

namespace Aula48Estaticos01 {
    internal class ConversorDeMoeda {

        public static double RealParaDolla(double cota, double compra) {
            return cota * 1.06 * compra; //onde .06 é 6% de IOF e cota + cota*0.06.
        }
    }
}
