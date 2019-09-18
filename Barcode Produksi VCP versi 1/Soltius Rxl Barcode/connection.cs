using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Soltius.RetailExcel.Utils.PrintBarcode
{
    class connection
    {
        public static OdbcConnection conn;
        public static OdbcCommand command;
        public static OdbcDataAdapter adapter;

        public static void bukaConn()
        {
            conn = new OdbcConnection("DSN=factorySystem");
            //conn.ConnectionString = "DSN=factorySystem";
            conn.Open();
        }

        public static void tutupConn()
        {
            //conn.ConnectionString = "DSN=factorySystem";
            conn.Close();
        }

        public static void callUser(String userName, String userPass, String userOrg, DataSet ds)
        {
            try
            {
                bukaConn();

                command = new OdbcCommand("select * from m_user where user_name='" + userName +
                                    "' and user_password='" + userPass + "' and user_org_cd='" + userOrg + "'", conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Terjadi Kesalahan Sistem, Silakan Hubungi Administrator!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callOrg(DataSet ds)
        {
            try
            {

                bukaConn();

                command = new OdbcCommand("select org_code, org_name from m_organization", conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callUserAuth(DataSet ds, String groupUser)
        {
            try
            {

                bukaConn();

                command = new OdbcCommand("select * from m_user_group where user_group_id='" + groupUser + "'", conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

                tutupConn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callStyleProd(DataSet ds, string textSQL)
        {
            try
            {
                bukaConn();

                command = new OdbcCommand("select '' style_id,'' style_description union select style_id, style_description from m_style" +
                                           " where style_status='O' and style_type='PM' " + textSQL, conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

                tutupConn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callBrand(DataSet ds, string textSQL)
        {
            try
            {
                bukaConn();

                command = new OdbcCommand("select '' brand_id,'' brand_desc union select brand_id, brand_desc from m_brand" +
                                           " where brand_status='O' and brand_type='PM' " + textSQL, conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

                tutupConn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callColor(DataSet ds, string textSQL)
        {
            try
            {
                bukaConn();

                command = new OdbcCommand("select '' color_id, '' color_description union" +
                                        " select DISTINCT  color_id, color_description from m_item, m_color" +
                                        " where item_color_id=color_id and color_status='O' " + textSQL, conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

                tutupConn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static void callSize(DataSet ds, string textSQL)
        {
            try
            {
                bukaConn();

                command = new OdbcCommand("select '' size_id, '' size_description union" +
                                           " select DISTINCT  size_id, size_description from m_item, m_size" +
                                           " where item_size_id=size_id and size_status='O' " + textSQL, conn);
                command.CommandTimeout = 10000;
                adapter = new OdbcDataAdapter(command);
                adapter.Fill(ds);

                tutupConn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupConn();
            }
        }

        public static String getOrg()
        {
            bukaConn();

            command = new OdbcCommand("select msp_org_cd from m_setup_parameter", conn);
            command.CommandTimeout = 10000;
            DataSet ds = new DataSet();
            adapter = new OdbcDataAdapter(command);
            adapter.Fill(ds);

            string orgCode = ds.Tables[0].Rows[0][0].ToString();

            tutupConn();

            return orgCode;
        }
    }
}
