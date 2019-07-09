using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sturdevant_s_Application
{
    public partial class EoD : Form
    {
        public EoD()
        {
            InitializeComponent();
        }

        private void EoD_Load(object sender, EventArgs e)
        {
            eoDCalculator1.Visible = true;
            cppOrderSheetMain1.Visible = false;
            speicalOrderSheetMain1.Visible = false;
            eKeystoneOrderSheetMain1.Visible = false;
        }

        private void Btn_EoDPanel_Click(object sender, EventArgs e)
        {
            eoDCalculator1.Visible = true;
            cppOrderSheetMain1.Visible = false;
            speicalOrderSheetMain1.Visible = false;
            eKeystoneOrderSheetMain1.Visible = false;
        }

        private void Btn_CppPanel_Click(object sender, EventArgs e)
        {
            eoDCalculator1.Visible = false;
            cppOrderSheetMain1.Visible = true;
            speicalOrderSheetMain1.Visible = false;
            eKeystoneOrderSheetMain1.Visible = false;
        }

        private void Btn_KeystonePanel_Click(object sender, EventArgs e)
        {
            eoDCalculator1.Visible = false;
            cppOrderSheetMain1.Visible = false;
            speicalOrderSheetMain1.Visible = false;
            eKeystoneOrderSheetMain1.Visible = true;
        }

        private void Btn_SpecialOrderPanel_Click(object sender, EventArgs e)
        {
            eoDCalculator1.Visible = false;
            cppOrderSheetMain1.Visible = false;
            speicalOrderSheetMain1.Visible = true;
            eKeystoneOrderSheetMain1.Visible = false;
        }
    }
}
