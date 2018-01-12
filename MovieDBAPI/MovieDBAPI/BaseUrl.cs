using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBAPI
{
    public class BaseUrl
    {
        public static string ApiUrl
        {
            get { return Properties.Settings.Default.BaseUrl; }
        }
    }
}
