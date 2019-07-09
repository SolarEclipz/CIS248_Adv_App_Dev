using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sturdevant_s_Application
{
    public partial class eKeystoneOrderSheetMain : UserControl
    {
        public eKeystoneOrderSheetMain()
        {
            InitializeComponent();
        }

        private void EKeystoneOrderSheetMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Wheat;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.eKeystone_OrdersTableAdapter.Fill(this.cIS248_ProjectDataSet.eKeystone_Orders);

            //this.dataGridView1.Refresh();
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount -1;
        }
    }
}
