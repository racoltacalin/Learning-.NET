using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConstructorsInCsharp
{
    public class SystemInfo
    {
        private static double version = 0.1;
        private static string vendor = "Microsoft";

        // The "version" static property
        public static double Version
        {
            get { return version; }
            set { version = value; }
        }

        // The "vendor" static property
        public static string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        //... More (non)static code here ...
    }
}
