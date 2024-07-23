using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Utils
{
    internal class Verificacoes
    {


        public bool verificarCaracteres(string value, int max = 100, int min = 5) {

            if (value.Trim().Length < min) {
                return false;
            }
            if (value.Trim().Length > max)
            {
                return false;
            }
           return true;
        }


    }
}
