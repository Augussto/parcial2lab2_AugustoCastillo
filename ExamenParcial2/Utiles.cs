using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExamenParcial2
{
    static class Utiles
    {
        public static Boolean validaCampos(String data)
        {
            if (data.Trim() != "")
            {
                try
                {
                    Convert.ToInt32(data);

                    if(Convert.ToInt32(data) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }


    }
}
