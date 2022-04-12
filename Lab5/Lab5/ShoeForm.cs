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
    public partial class ShoeForm : Form

    {
        List<Shoe> shoeList = new List<Shoe>();
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet shoeDataSet;
        DataRow drNewRecord;
        DataTable shoeTable;
        DataGridView dataGridView = new DataGridView();
        string strSQL;
        public ShoeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;");
            strSQL = "SELECT * FROM shoeList";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            shoeDataSet = new DataSet("ShoeTable");
            myDataAdapter.Fill(shoeDataSet, "ShoeTable");

            shoeTable = shoeDataSet.Tables["ShoeTable"];
            shoeDataGridView.DataSource = shoeTable;
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            string strSQL;
            strSQL = " INSERT INTO shoeList (Manufacturer, Gender, Price, Type, Image) " +
                    "VALUES ('" + manufacturerBox.Text + "','" + genderBox.Text + "','" +
                     priceBox.Text + "','" + shoeTypeBox.Text + "','" + imageComboBox.SelectedItem + "')";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);

            myDataAdapter.Fill(shoeDataSet, "ShoeTable");

            shoeTable = shoeDataSet.Tables["ShoeTable"];
            shoeDataGridView.DataSource = shoeTable;

            try
            {
                myConnection.Open();
                insertCommand.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("Error with inserting.");
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void genderBtn_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;");


            if (maleBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Gender = 'male'";
            }
            else if (femaleBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Gender = 'female'";
            }
            else
            {
                strSQL = "SELECT * FROM ShoeList WHERE Gender = 'unisex'";
            }

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            shoeDataSet = new DataSet("ShoeTable");
            myDataAdapter.Fill(shoeDataSet, "ShoeTable");

            shoeTable = shoeDataSet.Tables["StudentsTable"];
            shoeDataGridView.DataSource = shoeTable;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow record in shoeTable.Rows)
            {
                Shoe shoe = new Shoe();
                shoe.Manufacturer = record["Manufacturer"].ToString();
                shoe.Gender = record["Gender"].ToString();
                shoe.Price = Int32.Parse(record["Price"].ToString());
                shoe.Type = record["Type"].ToString();
                shoe.Image = record["Image"].ToString();

                shoeList.Add(shoe);
            }
            shoeDataGridView.DataSource = shoeList;
            MessageBox.Show("Data from the Shoe List has been loaded");
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;");

            string type = "";
            if (basketballBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Type = 'basketball'";
                
            }
            else if (dressBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Type = 'dress'";
            }
            else if (runningBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Type = 'running'";
            }
            else if (casualBtn.Checked)
            {
                strSQL = "SELECT * FROM ShoeList WHERE Type = 'running'";
            }
            else
            {
                strSQL = "SELECT * FROM ShoeList WHERE Type = 'hiking'";
            }




            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            shoeDataSet = new DataSet("ShoeTable");
            myDataAdapter.Fill(shoeDataSet, "ShoeTable");

            shoeTable = shoeDataSet.Tables["StudentsTable"];
            shoeDataGridView.DataSource = shoeTable;
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shoe.accdb;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            string strSQL;
            strSQL = "UPDATE shoeList(ShoeID, Manufacturer, Gender, Price, Type, Image) " +
                    "VALUES ('" + manufacturerBox.Text + "','" + genderBox.Text + "','" +
                     priceBox.Text + "','" + shoeTypeBox.Text + "','" + imageComboBox.SelectedItem + "')";
            DataSet myDataSet = new DataSet("Shoe");
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            OleDbCommand updateCommand = new OleDbCommand(strSQL, myConnection);
            try
            {
                myConnection.Open();
                updateCommand.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("Error with inserting.");
            }
            finally
            {
                myConnection.Close();
            }

            myDataAdapter.Fill(myDataSet, "Shoe");


            DataTable shoeList = myDataSet.Tables["Shoe"];
            DataRow newRecord;

            newRecord = shoeList.NewRow();
            newRecord["Manufacturer"] = manufacturerBox.Text;
            newRecord["Gender"] = genderBox.Text;
            newRecord["Price"] = priceBox.Text;
            newRecord["Type"] = shoeTypeBox.Text;

            shoeList.Rows.Add(newRecord);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, "Shoe");

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataTable dtShoe = shoeDataSet.Tables["ShoeTable"];
            DataRow drNewRecord = dtShoe.NewRow();
            Shoe newShoe = new Shoe();
            newShoe.Manufacturer = manufacturerBox.Text;
            newShoe.Type = shoeTypeBox.Text;
            newShoe.Gender = genderBox.Text;
            
            drNewRecord["Manufacturer"] = manufacturerBox.Text;
            drNewRecord["Gender"] = genderBox.Text;
            drNewRecord["Price"] = newShoe.calculatePrice();
            drNewRecord["Type"] = typeBtn.Text;
            


            // Add the new row to the DataTable in the DataSet
            dtShoe.Rows.Add(drNewRecord);

            

            // Resume the databinding for the controls and move to the last record (newly added record).
            shoeDataGridView.ResumeLayout();
            
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DataTable dtShoe = shoeDataSet.Tables["ShoeTable"];
            DataRow drNewRecord = dtShoe.NewRow();
            Shoe newShoe = new Shoe();
            newShoe.Type = typeBtn.Text;
            newShoe.Manufacturer = manufacturerBox.Text;
            newShoe.Gender = genderBox.Text;

            drNewRecord["Manufacturer"] = manufacturerBox.Text;
            drNewRecord["Gender"] = genderBox.Text;
            drNewRecord["Price"] = newShoe.calculatePrice();
            drNewRecord["Type"] = typeBtn.Text;


            // Add the new row to the DataTable in the DataSet
            shoeTable.Rows.Add(drNewRecord);



            // Resume the databinding for the controls and move to the last record (newly added record).
            shoeDataGridView.ResumeLayout();

            //Committing the user input into a new row in the dataset, meaning it is not saved
            shoeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }
    }
}
