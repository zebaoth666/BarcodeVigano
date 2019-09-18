using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soltius.RetailExcel.Helper {

    internal partial class GeneralDescriptionForm : Form {

        #region Methods

        #region Event Handlers

        private void GeneralDescriptionForm_Load(object sender, EventArgs e) {
            try {
                StartUp();
            } catch {
                throw;
            }
        }

        #endregion

        #region Not Overridables

        private void StartUp() {
            try {
                SetupPosition();
            } catch {
                throw;
            }
        }

        private void SetupPosition() {
            try {
                bool hasOwnerForm = (this.Owner != null && !this.Owner.IsDisposed);
                if (hasOwnerForm) {
                    this.CenterToParent();
                } else {
                    this.CenterToScreen();
                }
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        internal GeneralDescriptionForm() {
            InitializeComponent();
        }

        #endregion

        #endregion

        #region Fields



        #endregion

    }

}
