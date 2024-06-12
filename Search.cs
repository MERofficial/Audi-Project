using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AudiProject
{
    public partial class frmSearch : Form
    {
        private string dbConnectionString = "datasource=localhost;port=3306;database=audi;username=root;password=Bd195555";
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public frmSearch()
        {
            InitializeComponent();
            this.Text = "Audi Project - Date: " + DateTime.Today.ToString();
            this.Load += frmSearch_Load;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.Text = "Task A Search - Flavia Silva Malone " + DateTime.Now.ToShortDateString();

            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                using (connection = new MySqlConnection(dbConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Cars";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        adapter = new MySqlDataAdapter(command);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        // Add number of Row
                        dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbField.Text != "" && cbxOperator.Text != "" && txtCriteria.Text != "")
            {
                try
                {
                    using (connection = new MySqlConnection(dbConnectionString))
                    {
                        connection.Open();
                        string columnName = GetDatabaseColumnName(cmbField.Text);
                        string query = $"SELECT * FROM Cars WHERE {columnName} {cbxOperator.Text} @criteria";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Determine the data type of the column and correctly convert the criteria
                            if (columnName == "CarPrice" || columnName == "EngineSize")
                            {
                                if (decimal.TryParse(txtCriteria.Text, out decimal numericCriteria))
                                {
                                    command.Parameters.AddWithValue("@criteria", numericCriteria);
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid numeric value.");
                                    return;
                                }
                            }
                            else if (columnName == "Available")
                            {
                                if (int.TryParse(txtCriteria.Text, out int boolCriteria) && (boolCriteria == 0 || boolCriteria == 1))
                                {
                                    command.Parameters.AddWithValue("@criteria", boolCriteria);
                                }
                                else
                                {
                                    MessageBox.Show("Please enter 1 for available or 0 for unavailable vehicles.");
                                    return;
                                }
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@criteria", txtCriteria.Text);
                            }

                            adapter = new MySqlDataAdapter(command);
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;

                            // Add row numbering
                            dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
                        }
                    }

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all search fields.");
            }
        }

        private void frmSearch_Load_1(object sender, EventArgs e)
        {
            // Additional logic upon form load, if necessary.
        }

        private string GetDatabaseColumnName(string selectedField)
        {
            switch (selectedField)
            {
                case "Model":
                    return "Model";
                case "Engine Size":
                    return "EngineSize";
                case "Production Year": 
                    return "ProductionYear";
                case "Price (€)":
                    return "CarPrice"; 
                case "Available":
                    return "Available";
                default:
                    throw new ArgumentException("Invalid field selected");
            }
        }
    }
}