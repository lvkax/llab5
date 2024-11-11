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
        private Phone ThePhone;
        public fPhone(Phone phone)
        {
            ThePhone = phone;
            InitializeComponent();
            
         }
        

        public fPhone(SmartPhone t)
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

                // Если это смартфон, включаем дополнительные свойства
                if (ThePhone is SmartPhone smartphone)
                {
                    tbBatteryCapacity.Text = smartphone.BatteryCapacity;
                    cbHas3Cameras.Checked = smartphone.Has3Cameras;
                    cbHasWirelessCharging.Checked = smartphone.HasWirelessCharging;
                }
                else
                {
                    tbBatteryCapacity.Enabled = false;
                    cbHas3Cameras.Enabled = false;
                    cbHasWirelessCharging.Enabled = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePhone.Name = tbName.Text.Trim();
            ThePhone.Model = tbModel.Text.Trim();
            ThePhone.Cost = tbCost.Text.Trim();
            ThePhone.ReleaseYear = tbReleaseYear.Text.Trim();
            ThePhone.YearOfPurchase = tbYearofPurchase.Text.Trim();

            if (ThePhone is SmartPhone smartphone)
            {
                smartphone.BatteryCapacity = tbBatteryCapacity.Text.Trim();
                smartphone.Has3Cameras = cbHas3Cameras.Checked;
                smartphone.HasWirelessCharging = cbHasWirelessCharging.Checked;
            }

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
