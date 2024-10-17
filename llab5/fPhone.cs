using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace llab5
{
    public partial class fPhone : Form
    {
        public fPhone()
        {
            InitializeComponent();
        }
        public Phone ThePhone;

        public fPhone(Phone t)
        {
            ThePhone = t;
            InitializeComponent();
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            if (ThePhone != null)
            {
                tbName.Text = ThePhone.Name;
                tbModel.Text = ThePhone.Model;
                tbCost.Text = ThePhone.Cost;
                tbReleaseYear.Text = ThePhone.ReleaseYear;
                tbYearofPurchase.Text = ThePhone.YearOfPurchase;
                tbBatteryCapacity.Text = ThePhone.BatteryCapacity;
                cbHas3Cameras.Checked = ThePhone.Has3Cameras;
                cbHasWirelessCharging.Checked = ThePhone.HasWirelessCharging;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePhone.Name = tbName.Text.Trim();
            ThePhone.Model = tbModel.Text.Trim();
            ThePhone.Cost = tbCost.Text.Trim();
            ThePhone.ReleaseYear = tbReleaseYear.Text.Trim();
            ThePhone.YearOfPurchase = tbYearofPurchase.Text.Trim();
            ThePhone.BatteryCapacity = tbBatteryCapacity.Text.Trim();
            ThePhone.Has3Cameras = cbHas3Cameras.Checked;
            ThePhone.HasWirelessCharging = cbHasWirelessCharging.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
