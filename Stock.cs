using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AudiProject
{
    public partial class frmStock : Form
    {
        private string dbConnectionString = "datasource=localhost;port=3306;database=audi;username=root;password=Bd195555";
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private MySqlDataReader reader = null;
        private string sqlStatement;
        private DataTable dataTable = null;
        private int location;
        private int maxrow;

        public frmStock()
        {
            InitializeComponent();
            this.Text = "Audi Project - Date: " + DateTime.Today.ToString();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(dbConnectionString);
            this.Text = "Connected to Audi Database";

            string query = "SELECT * FROM cars";
            NavigateRecords(query, 0);
        }

        private void ClearBoxes()
        {
            txtVin.Clear();
            cmbModel.ResetText();
            cmbColour.ResetText();
            txtEngine.Clear();
            txtYear.Clear();
            txtRent.Clear();
            cbxYes.Checked = false;
            txtRecord.Clear();
            txtVin.Tag = null; // Clear the Tag as well
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVin.Tag == null)
                {
                    MessageBox.Show("Current VIN code is not set.");
                    return;
                }

                string currentVin = txtVin.Tag.ToString();
                string newVin = txtVin.Text;
                string ml = cmbModel.Text;
                string cr = cmbColour.Text;
                string en = txtEngine.Text;
                string yr = txtYear.Text;
                string rt = txtRent.Text;
                bool isChecked = cbxYes.Checked;

                connection.Open();

                string upDateSQL = "UPDATE cars SET VinCode = @newVin, Model = @model, Colour = @colour, EngineSize = @engine, ProductionYear = @year, CarPrice = @price, Available = @available WHERE VinCode = @currentVin";

                using (MySqlCommand command = new MySqlCommand(upDateSQL, connection))
                {
                    command.Parameters.AddWithValue("@newVin", newVin);
                    command.Parameters.AddWithValue("@model", ml);
                    command.Parameters.AddWithValue("@colour", cr);
                    command.Parameters.AddWithValue("@engine", en);
                    command.Parameters.AddWithValue("@year", yr);
                    command.Parameters.AddWithValue("@price", rt);
                    command.Parameters.AddWithValue("@available", isChecked);
                    command.Parameters.AddWithValue("@currentVin", currentVin);

                    command.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Update successful.");
                txtVin.Tag = newVin; // Update the current VIN code
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string vn = txtVin.Text;
                string ml = cmbModel.Text;
                string cr = cmbColour.Text;
                string en = txtEngine.Text;
                string yr = txtYear.Text;
                string rt = txtRent.Text;
                bool isChecked = cbxYes.Checked;

                connection.Open();

                string insertSQL = "INSERT INTO cars (VinCode, Model, Colour, EngineSize, ProductionYear, CarPrice, Available) VALUES (@vin, @model, @colour, @engine, @year, @price, @available)";

                using (MySqlCommand command = new MySqlCommand(insertSQL, connection))
                {
                    command.Parameters.AddWithValue("@vin", vn);
                    command.Parameters.AddWithValue("@model", ml);
                    command.Parameters.AddWithValue("@colour", cr);
                    command.Parameters.AddWithValue("@engine", en);
                    command.Parameters.AddWithValue("@year", yr);
                    command.Parameters.AddWithValue("@price", rt);
                    command.Parameters.AddWithValue("@available", isChecked);

                    command.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Record added successfully.");

                // Update the maximum row count
                maxrow++;

                // Update the Record display
                string query = "SELECT * FROM cars";
                NavigateRecords(query, maxrow);

                ClearBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string vinToDelete = txtVin.Text;

                if (string.IsNullOrEmpty(vinToDelete))
                {
                    MessageBox.Show("VIN code is required to delete a record.");
                    return;
                }

                connection.Open();

                string deleteSQL = "DELETE FROM cars WHERE VinCode = @vin";

                using (MySqlCommand command = new MySqlCommand(deleteSQL, connection))
                {
                    command.Parameters.AddWithValue("@vin", vinToDelete);
                    command.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Record deleted successfully.");

                // Update the record display
                string query = "SELECT * FROM cars";
                NavigateRecords(query, 0);

                ClearBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            location = 0;
            sqlStatement = "SELECT * FROM cars";
            NavigateRecords(sqlStatement, location);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (location > 0)
            {
                location -= 1;
                sqlStatement = "SELECT * FROM cars";
                NavigateRecords(sqlStatement, location);
            }
            else
            {
                MessageBox.Show("No more rows.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (location < maxrow)
            {
                location += 1;
                sqlStatement = "SELECT * FROM cars";
                NavigateRecords(sqlStatement, location);
            }
            else
            {
                MessageBox.Show("No more rows.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            location = maxrow;
            sqlStatement = "SELECT * FROM cars";
            NavigateRecords(sqlStatement, location);
        }

        private void NavigateRecords(string sql, int location)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                maxrow = dataTable.Rows.Count - 1;

                if (location >= 0 && location <= maxrow)
                {
                    txtRecord.Text = $"{location + 1} of {maxrow + 1}";
                    txtVin.Text = dataTable.Rows[location].Field<string>("VinCode");
                    txtVin.Tag = dataTable.Rows[location].Field<string>("VinCode"); // Set the Tag to the current VinCode
                    cmbModel.Text = dataTable.Rows[location].Field<string>("Model");
                    cmbColour.Text = dataTable.Rows[location].Field<string>("Colour");
                    txtEngine.Text = dataTable.Rows[location]["EngineSize"].ToString();
                    txtYear.Text = dataTable.Rows[location]["ProductionYear"].ToString();
                    txtRent.Text = dataTable.Rows[location].Field<decimal>("CarPrice").ToString();
                    cbxYes.Checked = Convert.ToBoolean(dataTable.Rows[location]["Available"]);
                }
                else
                {
                    MessageBox.Show("Invalid record location.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                dataTable.Dispose();
            }
        }

        private void cmbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for cmbColour selection change
        }

        private void cmbColour_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
