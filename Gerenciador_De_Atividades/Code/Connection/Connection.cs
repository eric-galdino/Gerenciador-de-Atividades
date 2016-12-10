using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Gerenciador_De_Atividades.Code.Connection
{
    public class Connection
    {
        public static string ConString()
        {
            return ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        }
    }
}