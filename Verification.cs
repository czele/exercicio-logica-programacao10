using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace ex10
{
    public static class Verification
    {
        public static bool Verify(PropriedadeLados propriedadeLados)
        {
            double a = propriedadeLados.a;
            double b = propriedadeLados.b;
            double c = propriedadeLados.c;

            if (a < b + c)
                return true;
            else
            {
                if (b < a + c)
                    return true;
                else
                {
                    if (c < a + b)
                        return true;
                }
                return false;
            }

        }
            
    }
  
}
