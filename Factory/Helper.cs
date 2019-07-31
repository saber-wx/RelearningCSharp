using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class Helper
    {
        internal const string PASSWORD = "wx123456";

        internal static SQLContext context = new SQLContext ();

    }
}
