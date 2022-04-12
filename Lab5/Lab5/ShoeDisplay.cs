using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class ShoeDisplay : Form
    {
        public ShoeDisplay()
        {
            InitializeComponent();
        }

        private void ShoeDisplay_Load(object sender, EventArgs e)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            string strSQL;
            strSQL = "SELECT * FROM ShoeList";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet shoeDataSet = new DataSet("ShoeTable");
            myDataAdapter.Fill(shoeDataSet, "ShoeTable");

            // Set the data source for the DataGridView to display the records and their information.
            // The DataGridView DataSource property can be assigned a DataTable, BindingSource, or a collection.
            DataTable shoeTable = shoeDataSet.Tables["ShoeTable"];
            shoeDataGridView.DataSource = shoeTable;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void shoeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.shoeDataGridView.SelectedRows.Count > 0 &&
           this.shoeDataGridView.SelectedRows[0].Index !=
           this.shoeDataGridView.Rows.Count - 1)
            {
                this.shoeDataGridView.Rows.RemoveAt(
                this.shoeDataGridView.SelectedRows[0].Index);
                shoeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }
    }
}
