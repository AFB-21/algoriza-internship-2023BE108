using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoriza_internship_2023BE108.Data.MetaData
{
    public class Router
    {
        public const string root = "api/";
        public const string version = "v1/";
        public const string rule = root + version;

        public static class DoctorRouting
        {
            public const string prefix = rule + "doctor/";
            public const string list = prefix + "list";
            public const string GetById = prefix + "{id}";



        }
    }
}
