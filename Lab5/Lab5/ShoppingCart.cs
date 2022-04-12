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
    
    public partial class ShoppingCart : Form
    {
        List<Shoe> shoeList = new List<Shoe>();
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet customerDataSet; 
        DataTable customerTable;
        DataTable dtShoppingCart;
        DataGridView customerDataGridView = new DataGridView();
        string strSQL;
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtShoes = customerDataSet.Tables["shoeTable"];
           

            
       
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        { 
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;");
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            customerDataSet = new DataSet("CustomerTable");
            myDataAdapter.Fill(customerDataSet, "CustomerTable");

            customerTable = customerDataSet.Tables["CustomerTable"];
            customerDataGridView.DataSource = customerTable;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
           
            DataRow drNewRecord = dtShoppingCart.NewRow();
            Customer newCustomer = new Customer();
            newCustomer.Name = nameBox.Text;
            newCustomer.PhoneNumber = Int32.Parse(phoneNumberBox.Text);
            newCustomer.PaymentInformation = Int32.Parse(paymentInformationBox.Text);

            drNewRecord["Name"] = nameBox.Text;
            drNewRecord["Phone Number"] = phoneNumberBox.Text;
            drNewRecord["Billing Information"] = paymentInformationBox.Text;
            



            // Add the new row to the DataTable in the DataSet
            dtShoppingCart.Rows.Add(drNewRecord);



            // Resume the databinding for the controls and move to the last record (newly added record).
            customerDataGridView.ResumeLayout();


            customerDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }
    }
}
