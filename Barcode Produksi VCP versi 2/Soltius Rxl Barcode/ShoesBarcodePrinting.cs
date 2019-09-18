using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;

using Soltius;
using Soltius.RetailExcel;
using Soltius.RetailExcel.Data;
using Soltius.RetailExcel.Data.Properties;
using Soltius.RetailExcel.Helper;

namespace Soltius.RetailExcel.Utils.PrintBarcode
{

      public class ShoesBarcodePrinting
    {
        SqlConnection queryConnection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(null));
        SqlDataAdapter dataAdapter;
        dsShoesBarcodePrinting ds = null;
        string sqlSelect;
        
       
    }
}
