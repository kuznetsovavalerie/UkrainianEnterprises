using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace UkrainianEnterprises.App_Code
{
    public static class UIConfiguration
    {
        public static string GoogleMapsAPIUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["GoogleMapsAPIUrl"];
            }
        }
    }
}