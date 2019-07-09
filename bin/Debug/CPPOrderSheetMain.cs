using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sturdevant_s_Application
{
    public partial class CPPOrderSheetMain : UserControl
    {
        public CPPOrderSheetMain()
        {
            InitializeComponent();
        }

        private void CPPOrderSheetMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Wheat;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.cPP_Order_SheetTableAdapter1.Fill(this.cIS248_ProjectDataSet1.CPP_Order_Sheet);

            //this.dataGridView1.Refresh();
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount -1;
        }

        private void ToolStripButton_Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.RefreshEdit();
                this.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // takes the user to the bottom of the datagrid view.
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void ToolStripButton_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cPPOrderSheetBindingSource1.EndEdit();
                this.cPP_Order_SheetTableAdapter1.Update(this.cIS248_ProjectDataSet1.CPP_Order_Sheet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

    }
}
