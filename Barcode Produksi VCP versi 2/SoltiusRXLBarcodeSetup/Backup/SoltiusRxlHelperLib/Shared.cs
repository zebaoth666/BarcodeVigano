using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Soltius.RetailExcel.Helper {

    public delegate void SingleParamInvoker<T>(T @object);

    public delegate void MultiParamInvoker<T>(params T[] objects);

    public static class StringHelper {

        public static bool Like(this string source, string pattern, CompareMethod compareOption) {
            try {
                return LikeOperator.LikeString(source, pattern, (Microsoft.VisualBasic.CompareMethod)(int)compareOption);
            } catch {
                throw;
            }
        }

        /// <summary>
        /// Indicates how to compare strings when calling comparison functions.
        /// </summary>
        public enum CompareMethod {
            /// <summary>
            /// Performs a binary comparison.
            /// </summary>
            Binary,
            /// <summary>
            /// Performs a textual comparison.
            /// </summary>
            Text
        }

    }

    public static class DefaultApplicationInfo {

        public static readonly string ShortApplicationName = "Soltius Rxl Add-in";

        public static readonly string ApplicationVersionSuffix = "v3.5";

        public static readonly string FullApplicationName = ShortApplicationName + " " + ApplicationVersionSuffix;

        public static readonly string AbbreviatedApplicationName = "SoltiusRxlAddIn";

    }

}
