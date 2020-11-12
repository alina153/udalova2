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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.inventoryDataSet.Orders);
            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Orders WHERE OrderID = @OrderID", ordersTableAdapter.Connection);

            var parameter = command.Parameters.Add("@OrderID", SqlDbType.Int, 5, "OrderID");

            parameter.SourceVersion = DataRowVersion.Original;

            ordersTableAdapter.Adapter.DeleteCommand = command;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.Update(inventoryDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add dlg = new Add();
            dlg.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search dlg = new Search();
            dlg.Show(this);
        }
    }
    }

