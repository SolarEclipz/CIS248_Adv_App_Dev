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
    public partial class SpeicalOrderSheetMain : UserControl
    {
        public SpeicalOrderSheetMain()
        {
            InitializeComponent();
        }

        private void SpeicalOrderSheetMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Wheat;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.special_OrdersTableAdapter.Fill(this.cIS248_ProjectDataSet.Special_Orders);
        }

        private void ToolStripButton_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.specialOrdersBindingSource.EndEdit();
                this.special_OrdersTableAdapter.Update(this.cIS248_ProjectDataSet.Special_Orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripButton_Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.RefreshEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // takes the user to the bottom of the datagrid view.
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }
    }
}
