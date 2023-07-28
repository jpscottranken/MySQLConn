using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MySQLGUIAppProject
{
    public partial class frmEmployee : Form
    {
        //  Declare and initialize global constants
        const int MINDEPTCODE   =       1;          //  Dept code must be >= 1 && <= 7
        const int MAXDEPTCODE   =       7;          //  Dept code must be >= 1 && <= 7
        const decimal MINSALARY =       0.00M;      //  Minimum salary
        const decimal MAXSALARY = 1000000.00M;      //  Maximum salary

        //	Set up MySQL and Data variables
        //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlConnection.html
        MySqlConnection sqlConn     = new MySqlConnection();

        //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlCommand.html?highlight=mysqlcommand%2C
        MySqlCommand sqlCmd         = new MySqlCommand();

        //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlDataReader.html
        MySqlDataReader sqlReader   = null;

        //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlDataAdapter.html
        MySqlDataAdapter sqlDA      = new MySqlDataAdapter();
        DataTable sqlDT             = new DataTable();
        DataSet sqlDS               = new DataSet();
        String sqlQuery;

        //  https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=dotnet-plat-ext-7.0
        //  https://www.connectionstrings.com/mysql-connector-net-mysqlconnection/
        //  https://dev.mysql.com/doc/connector-net/en/connector-net-connections-string.html
        //	Set up the connection string variable
        //	Set up connection parameters
        string server   = "localhost";
        string userName = "root";
        string password = "";
        string database = "acme_widget";

        int id;                                     //  Inputted employee id
        int dc;                                     //  Inputted employee department code

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //  Call method to fill up dataGridView
            UploadData();
        }
        
        private void SetConnectionString()
        {
            //  Sets connection string as follows:
            //  Server=localhost;UID=root;PWD="";Database=acme_widget;
            sqlConn.ConnectionString = "Server=" + server + ";" +
               "UID=" + userName + ";" +
               "PWD=" + password + ";" +
               "Database=" + database;
        }

        private void UploadData()
        {
            SetConnectionString();

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            //  https://dev.mysql.com/doc/connector-net/en/connector-net-programming-mysqlcommand.html#connector-net-programming-mysqlcommand-text-type
            sqlCmd.CommandText = "SELECT * FROM employee";

            //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlCommand~ExecuteReader().html
            sqlReader = sqlCmd.ExecuteReader();

            //  https://docs.devart.com/dotconnect/mysql/Devart.Data~Devart.Common.DbLoader~LoadTable.html?highlight=datatable%2C
            sqlDT.Load(sqlReader);
            sqlReader.Close();
            sqlConn.Close();

            dgvAcmeWidget.DataSource = sqlDT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttemptToAddRecord();
        }

        private void AttemptToAddRecord()
        {
            SetConnectionString();

            try
            {
                if (IsValidData())
                {
                    //  Open the connection
                    sqlConn.Open();
                    sqlQuery = 
                        "INSERT INTO employee(employeeid, first_name, last_name, address, city, state_code, zip, phone, department_code, salary)" +
                        "VALUES('" + txtID.Text + "', '"    + 
                                     txtFirstName.Text      + "', '" +
                                     txtLastName.Text       + "', '" +
                                     txtAddress.Text        + "', '" +
                                     txtCity.Text           + "', '" +
                                     txtState.Text          + "', '" +
                                     txtZipCode.Text        + "', '" +
                                     txtPhone.Text          + "', '" +
                                     txtDepartmentCode.Text + "', '" +
                                     txtSalary.Text         + "')";

                    //  Set SQL Command object
                    sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

                    //  Set SQL DataReader object
                    sqlReader = sqlCmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");

                //  Close connection
                sqlConn.Close();
            }
            finally
            {
                //  Close connection
                sqlConn.Close();
            }

            UploadData();
        }

        private bool IsValidData()
        {
            //  Validate all 10 input fields are not empty.
            //
            //  Validate a employeeID and employeeDepartment_code
            //	are both integers.
            //
            //	Validate that salary is between 0 and 1000000
            //
            //  using methods from Validator.cs
            bool success = true;
            string errMsg = "";
            bool result;

            //  Validate the presence (i.e. a value) in 
            //  the txtID textbox.
            errMsg += Validator.IsPresent(
                                txtID.Text,
                                txtID.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtFirstName textbox.
            errMsg += Validator.IsPresent(
                                txtFirstName.Text,
                                txtFirstName.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtLastName textbox.
            errMsg += Validator.IsPresent(
                                txtLastName.Text,
                                txtLastName.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtAddress textbox.
            errMsg += Validator.IsPresent(
                                txtAddress.Text,
                                txtAddress.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtCity textbox.
            errMsg += Validator.IsPresent(
                                txtCity.Text,
                                txtCity.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtState textbox.
            errMsg += Validator.IsPresent(
                                txtState.Text,
                                txtState.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtZipCode textbox.
            errMsg += Validator.IsPresent(
                                txtZipCode.Text,
                                txtZipCode.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtPhone textbox.
            errMsg += Validator.IsPresent(
                                txtPhone.Text,
                                txtPhone.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtDepartment_Code textbox.
            errMsg += Validator.IsPresent(
                                txtDepartmentCode.Text,
                                txtDepartmentCode.Tag.ToString());

            //  Validate the presence (i.e. a value) in 
            //  the txtSalary textbox.
            errMsg += Validator.IsPresent(
                                txtSalary.Text,
                                txtSalary.Tag.ToString());

            //  Validate the value in the id
            //  textbox is numeric (integer).
            errMsg += Validator.IsInt32(
                                txtID.Text,
                                txtID.Tag.ToString());

            //  Validate the value in the department
            //  code textbox is numeric (integer).
            errMsg += Validator.IsInt32(
                                txtDepartmentCode.Text,
                                txtDepartmentCode.Tag.ToString());

            //  Validate the value in the salary
            //  textbox is numeric (decimal).
            errMsg += Validator.IsDecimal(
                                txtSalary.Text,
                                txtSalary.Tag.ToString());

            //  Validate the value in the employeeID is > 0
            result = Int32.TryParse(txtID.Text, out id);
            if (!result || id <= 0)
            {
                errMsg += "You Must Enter A Positive Number For The Employee ID\n";
            }

            //  Validate the value in the department code is between 1 and 7
            result = Int32.TryParse(txtDepartmentCode.Text, out dc);
            if ((!result) || ((dc < MINDEPTCODE) || (dc > MAXDEPTCODE)))
            {
                errMsg += "You Must Enter A Department Code Between " +
                            MINDEPTCODE + " and " + MAXDEPTCODE + "\n";
            }

            //  Validate the value in the salary is between 0 and 1000000
            result = Int32.TryParse(txtSalary.Text, out dc);
            errMsg += Validator.IsWithinRange(
                                txtSalary.Text,
                                txtSalary.Tag.ToString(),
                                MINSALARY, MAXSALARY);


            if (errMsg != "")
            {
                //  There were one or more validationerrors
                MessageBox.Show(errMsg, "INPUT ERROR(s)",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                success = false;
            }

            return success;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AttemptToUpdateRecord();
        }

        private void AttemptToUpdateRecord()
        {
            SetConnectionString();

            try
            {
                //  Open the connections
                sqlConn.Open();

                //MySqlCommand sqlCmd2 = new MySqlCommand();

                //  Set the SQL command object to the sqlConn
                sqlCmd.Connection = sqlConn;

                //  Set the SQL command text
                sqlCmd.CommandText =
                    "UPDATE employee SET first_name = @first_name, last_name = @last_name, address = @address, city = @city, state_code = @state_code, zip = @zip, phone = @phone, department_code = @department_code, salary = @salary WHERE employeeid = @employeeid";
                //employeeid = @employeeid, 
                sqlCmd.CommandType = CommandType.Text;

                //  https://docs.devart.com/dotconnect/mysql/Devart.Data.MySql~Devart.Data.MySql.MySqlParameterCollection_members.html?highlight=addwithvalue%2C
                //  Associate "@" parameters with their
                //  respective textbox values
                sqlCmd.Parameters.AddWithValue("@employeeid", txtID.Text);
                sqlCmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@last_name",  txtLastName.Text);
                sqlCmd.Parameters.AddWithValue("@address"  ,  txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@city",       txtCity.Text);
                sqlCmd.Parameters.AddWithValue("@state_code", txtState.Text);
                sqlCmd.Parameters.AddWithValue("@zip",        txtZipCode.Text);
                sqlCmd.Parameters.AddWithValue("@phone",      txtPhone.Text);
                sqlCmd.Parameters.AddWithValue("@department_code", txtDepartmentCode.Text);
                sqlCmd.Parameters.AddWithValue("@salary",     txtSalary.Text);

                //  https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executenonquery?view=dotnet-plat-ext-7.0
                sqlCmd.ExecuteNonQuery();

                sqlConn.Close();
                UploadData();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AttemptToDeleteRecord();
        }

        private void AttemptToDeleteRecord()
        {
            SetConnectionString();

            try
            {
                //  Open the connection
                sqlConn.Open();

                //  Set the SQL Comman connection
                sqlCmd.Connection = sqlConn;

                DialogResult dialog = MessageBox.Show(
                    "Are You Sure You Want To Delete This Employee Record?",
                    "DELETE CURRENT EMPLOYEE RECORD",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    //  https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-parameters.html
                    sqlCmd.Parameters.Add(new MySqlParameter("@employeeid", txtID.Text));

                    //  https://dev.mysql.com/doc/dev/connector-net/latest/api/data_api/MySql.Data.MySqlClient.MySqlCommand.html
                    sqlCmd.CommandText = "DELETE FROM employee WHERE employeeid = @employeeid";

                    sqlCmd.ExecuteNonQuery();

                    sqlConn.Close();

                    foreach (DataGridViewRow item in this.dgvAcmeWidget.SelectedRows)
                    {
                        //  https://mysqlcode.com/mysql-delete/
                        dgvAcmeWidget.Rows.RemoveAt(item.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }

            ClearEmployeeInfoAndSearch();
            UploadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEmployeeInfoAndSearch();
        }

        private void ClearEmployeeInfoAndSearch()
        {
            try
            {
                foreach (Control c in gbEmployeeInfo.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }

                txtSearch.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }

            //UploadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            try
            {
                DialogResult dialog = MessageBox.Show(
                       "Do You Really Want To Exit?",
                       "EXIT NOW?",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }
        }

        private void dgvAcmeWidget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillUpEmployeeTextBoses();
        }

        private void FillUpEmployeeTextBoses()
        {
            try
            {
                txtID.Text              = dgvAcmeWidget.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text       = dgvAcmeWidget.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text        = dgvAcmeWidget.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text         = dgvAcmeWidget.SelectedRows[0].Cells[3].Value.ToString();
                txtCity.Text            = dgvAcmeWidget.SelectedRows[0].Cells[4].Value.ToString();
                txtState.Text           = dgvAcmeWidget.SelectedRows[0].Cells[5].Value.ToString();
                txtZipCode.Text         = dgvAcmeWidget.SelectedRows[0].Cells[6].Value.ToString();
                txtPhone.Text           = dgvAcmeWidget.SelectedRows[0].Cells[7].Value.ToString();
                txtDepartmentCode.Text  = dgvAcmeWidget.SelectedRows[0].Cells[8].Value.ToString();
                txtSalary.Text          = dgvAcmeWidget.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //  
                DataView dv = sqlDT.DefaultView;
                dv.RowFilter = string.Format("last_name LIKE '%{0}%'", txtSearch.Text);
                dgvAcmeWidget.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ERROR");
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
