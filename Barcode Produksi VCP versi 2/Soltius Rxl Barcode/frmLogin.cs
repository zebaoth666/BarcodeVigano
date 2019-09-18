using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soltius.RetailExcel.Utils.PrintBarcode
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool sukses = false;
        public string orgCode = "";
        public string ugroup = "";

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //connection.callOrg(ds);

            //if (ds.Tables[0].Rows.Count > 0) {
            //    cmbOrg.DataSource = ds.Tables[0].DefaultView;
            //    cmbOrg.DisplayMember = "org_name";
            //    cmbOrg.ValueMember = "org_code";
            //}

            orgCode = connection.getOrg();
            TxtUsername.Focus();
        }

        private bool tesLogin(String userName, String userPass, String org)
        {
            if (org != "")
            {
                if (userName != "")
                {
                    if (userPass != "")
                    {
                        DataSet ds = new DataSet();

                        connection.callUser(userName, userPass, org, ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            orgCode = ds.Tables[0].Rows[0]["user_org_cd"].ToString();
                            ugroup = ds.Tables[0].Rows[0]["user_group"].ToString();
                            sukses = true;
                        }
                        else
                        {
                            sukses = false;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Password tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //TxtPassword.Focus();
                        sukses = false;
                    }
                }
                else
                {
                    //MessageBox.Show("Username tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //TxtUsername.Focus();
                    sukses = false;
                }
            }
            else
            {
                //MessageBox.Show("Username tidak boleh kosong", "Barcode Printing System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //cmbOrg.Focus();
                sukses = false;
            }

            return sukses;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            tesLogin(TxtUsername.Text, TxtPassword.Text, orgCode);
            if (sukses)
            {
                MainForm1 menu = new MainForm1();
                menu.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Barcode Printing System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                TxtUsername.Focus();
            }
        }

        private void cekOrg(string orgCode)
        {

        }
    }
}
