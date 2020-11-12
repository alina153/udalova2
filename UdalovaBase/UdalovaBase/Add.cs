using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdalovaBase
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form2 main = this.Owner as Form2;
                if (main != null)
                {

                    DataRow nRow = main.inventoryDataSet.Tables[0].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    //nRow[0] = rc;
                    nRow[0] = tbOrderID.Text = Convert.ToString(Convert.ToInt32(tbOrderID.Text));
                    nRow[1] = tbCarModel.Text;
                    nRow[2] = tbColorName.Text;
                    nRow[3] = tbCustomerName.Text;
                    nRow[4] = tbPrice.Text = Convert.ToString(Convert.ToInt32(tbPrice.Text));
                    main.inventoryDataSet.Tables[0].Rows.Add(nRow);
                    main.ordersTableAdapter.Update(main.inventoryDataSet.Orders);
                    main.inventoryDataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbOrderID.Text  = "";
                    tbCarModel.Text = "";
                    tbColorName.Text = "";
                    tbCustomerName.Text = "";
                    tbPrice.Text = "";
            }
            
        }
    }
}
