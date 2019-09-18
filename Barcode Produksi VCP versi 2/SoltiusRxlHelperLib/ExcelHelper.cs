using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Linq;

using Soltius.RetailExcel.Helper.Properties;

namespace Soltius.RetailExcel.Helper {

    public static class ExcelHelper {

        #region Methods

        public static void Export(DataSet dataSet, string fileName) {
            try {
                if (dataSet == null) {
                    throw new ArgumentNullException("dataSet");
                }
                if (string.IsNullOrEmpty(fileName)) {
                    throw new ArgumentException("filename can not be null or empty.");
                }
                if (!fileName.EndsWith(".xls", StringComparison.CurrentCultureIgnoreCase)) {
                    fileName += ".xls";
                }
                using (MemoryStream dataSetStream = new MemoryStream()) {
                    dataSet.WriteXml(dataSetStream);
                    dataSetStream.Flush();
                    dataSetStream.Position = 0;
                    using (XmlTextReader reader = new XmlTextReader(dataSetStream)) {
                        XslCompiledTransform transformer = new XslCompiledTransform();
                        using (MemoryStream xltStream = new MemoryStream(Resources.ExcelStyleSheet)) {
                            using (XmlTextReader xltReader = new XmlTextReader(xltStream)) {
                                transformer.Load(xltReader);
                            }
                            using (XmlWriter writer = XmlWriter.Create(fileName)) {
                                transformer.Transform(reader, writer);
                            }
                        }
                    }
                }
            } catch {
                throw;
            }
        }

        #endregion

    }

}
