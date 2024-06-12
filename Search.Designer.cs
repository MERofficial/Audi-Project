namespace AudiProject
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCriteria = new TextBox();
            lblCriteria = new Label();
            lblField = new Label();
            cmbField = new ComboBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            lblOperator = new Label();
            cbxOperator = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCriteria
            // 
            txtCriteria.Font = new Font("Century Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCriteria.Location = new Point(113, 262);
            txtCriteria.Margin = new Padding(2);
            txtCriteria.Name = "txtCriteria";
            txtCriteria.Size = new Size(336, 48);
            txtCriteria.TabIndex = 1;
            txtCriteria.TextChanged += txtCriteria_TextChanged;
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriteria.Location = new Point(148, 221);
            lblCriteria.Margin = new Padding(2, 0, 2, 0);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(279, 32);
            lblCriteria.TabIndex = 2;
            lblCriteria.Text = "Enter Search Criteria";
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblField.Location = new Point(207, 22);
            lblField.Margin = new Padding(2, 0, 2, 0);
            lblField.Name = "lblField";
            lblField.Size = new Size(161, 32);
            lblField.TabIndex = 3;
            lblField.Text = "Select Field";
            // 
            // cmbField
            // 
            cmbField.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbField.FormattingEnabled = true;
            cmbField.Items.AddRange(new object[] { "VIN", "Model", "Engine Size", "Production Year", "Colour", "Price (€)", "Available" });
            cmbField.Location = new Point(113, 74);
            cmbField.Margin = new Padding(2);
            cmbField.Name = "cmbField";
            cmbField.Size = new Size(336, 41);
            cmbField.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(193, 350);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(187, 44);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 433);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(568, 257);
            dataGridView1.TabIndex = 6;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperator.Location = new Point(220, 122);
            lblOperator.Margin = new Padding(2, 0, 2, 0);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(133, 32);
            lblOperator.TabIndex = 8;
            lblOperator.Text = "Operator";
            // 
            // cbxOperator
            // 
            cbxOperator.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxOperator.FormattingEnabled = true;
            cbxOperator.Items.AddRange(new object[] { "Select Field:", "=", ">=", "<=", ">", "<" });
            cbxOperator.Location = new Point(113, 155);
            cbxOperator.Margin = new Padding(2);
            cbxOperator.Name = "cbxOperator";
            cbxOperator.Size = new Size(336, 41);
            cbxOperator.TabIndex = 9;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 893);
            Controls.Add(cbxOperator);
            Controls.Add(lblOperator);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(cmbField);
            Controls.Add(lblField);
            Controls.Add(lblCriteria);
            Controls.Add(txtCriteria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmSearch";
            Text = "Search";
            Load += frmSearch_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCriteria;
        private Label lblCriteria;
        private Label lblField;
        private ComboBox cmbField;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label lblOperator;
        private ComboBox cbxOperator;
    }
}