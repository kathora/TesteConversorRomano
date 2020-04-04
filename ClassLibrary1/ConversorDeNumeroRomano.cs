using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorNumeroRomano
{
    public class ConversorDeNumeroRomano
    {
        public string Converte(int numeroEmRomano) 
        {
            if (numeroEmRomano.Equals(1))
                return "I";
            else if (numeroEmRomano.Equals(5))
                return "V";
            return "0";
        }
    }
}
