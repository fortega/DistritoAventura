using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace POS
{
    public partial class Persona
    {
        private static Regex regexRut = new Regex("^\\d{7,8}[0-9k]$", RegexOptions.IgnoreCase);
        public static bool ValidaRUT(string rut)
        {
            if (!string.IsNullOrEmpty(rut))
            {
                if (regexRut.Match(rut).Success)
                {
                    int total = 0;
                    int cur = 2;
                    for (int i = rut.Length - 2; i >= 0; i--)
                    {
                        total += ((int)rut[i]-48) * cur;

                        if (++cur > 7)
                            cur = 2;
                    }

                    int verificador = 11 - (total % 11);
                    if (verificador == 10)
                        return rut[rut.Length - 1] == 'k';
                    else if(verificador == 11)
                        return rut[rut.Length - 1] == '0';
                    else
                        return rut[rut.Length - 1] == (char)(verificador + 48);
                }
            }

            return false;
        }

        public void ImprimeContrato()
        {
        }
        public bool RutValido
        {
            get { return ValidaRUT(RUT); }
        }
    }
}
