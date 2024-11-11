using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llab5
{
    public partial class PhoneType : Form
    {
        public string SelectedPhoneType { get; private set; }
        public PhoneType()
        {
            InitializeComponent();
        }

        private void PhoneType_Load(object sender, EventArgs e)
        {
            comboBoxPhoneType.Items.Add("BasicPhone");
            comboBoxPhoneType.Items.Add("SmartPhone");
            comboBoxPhoneType.SelectedIndex = 0;
        }
        private void butnOk_Click(object sender, EventArgs e)
        {
            SelectedPhoneType = comboBoxPhoneType.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void butnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxPhoneType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
