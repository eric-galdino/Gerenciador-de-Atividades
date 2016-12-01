using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GerenciadorDeAtividades.App_Code.ConnectionBD
{
    public class ConnectionFactory
    {
        public static string ConString()
        {
            return ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        }
    }
}