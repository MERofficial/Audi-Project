namespace AudiProject
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            lblVin = new Label();
            lblModel = new Label();
            lblColour = new Label();
            lblEngine = new Label();
            lblYear = new Label();
            lblRent = new Label();
            lblAvailable = new Label();
            txtRent = new TextBox();
            txtYear = new TextBox();
            txtEngine = new TextBox();
            cmbModel = new ComboBox();
            txtVin = new TextBox();
            btnFirst = new Button();
            btnLast = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            txtRecord = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            cmbColour = new ComboBox();
            cbxYes = new CheckBox();
            SuspendLayout();
            this.ClientSize = new Size(this.ClientSize.Width * 2, this.ClientSize.Height);
            // 
            // lblVin
            // 
            lblVin.AutoSize = true;
            lblVin.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVin.Location = new Point(67, 59);
            lblVin.Name = "lblVin";
            lblVin.Size = new Size(108, 49);
            lblVin.TabIndex = 0;
            lblVin.Text = "VIN:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.Location = new Point(67, 137);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(167, 49);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblColour
            // 
            lblColour.AutoSize = true;
            lblColour.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColour.Location = new Point(67, 215);
            lblColour.Name = "lblColour";
            lblColour.Size = new Size(174, 49);
            lblColour.TabIndex = 2;
            lblColour.Text = "Colour:";

            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEngine.Location = new Point(67, 292);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(266, 49);
            lblEngine.TabIndex = 3;
            lblEngine.Text = "Engine Size:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(67, 375);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(368, 49);
            lblYear.TabIndex = 4;
            lblYear.Text = "Production Year:";
            // 
            // lblRent
            // 
            lblRent.AutoSize = true;
            lblRent.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRent.Location = new Point(67, 451);
            lblRent.Name = "lblRent";
            lblRent.Size = new Size(206, 49);
            lblRent.TabIndex = 5;
            lblRent.Text = "Price (€):";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(67, 533);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(232, 49);
            lblAvailable.TabIndex = 6;
            lblAvailable.Text = "Available:";
            // 
            // txtRent
            // 
            txtRent.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRent.Location = new Point(486, 440);
            txtRent.Name = "txtRent";
            txtRent.Size = new Size(390, 60);
            txtRent.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYear.Location = new Point(486, 364);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(390, 60);
            txtYear.TabIndex = 8;
            // 
            // txtEngine
            // 
            txtEngine.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEngine.Location = new Point(486, 281);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(390, 60);
            txtEngine.TabIndex = 9;
            // 
            // cmbModel
            // 
            cmbModel.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbModel.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "Select Model:", "A1", "A3 ", "A4", "A5", "A6", "A7", "A8", "e-tron GT", "Q2", "Q3", "Q4", "Q4 e-tron", "Q5", "Q7", "Q8", "Q8 e-tron", "RS3", "RS4", "RS5", "RS6", "RS7", "R8", "S3", "S4", "S5", "S6", "S7", "S8", "TT" });
            cmbModel.Location = new Point(486, 126);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(390, 60);
            cmbModel.TabIndex = 11;
            // 
            // txtVin
            // 
            txtVin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVin.Location = new Point(486, 48);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(390, 47);
            txtVin.TabIndex = 12;
            // 
            // btnFirst
            // 
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(67, 609);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(119, 48);
            btnFirst.TabIndex = 14;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(757, 609);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(119, 48);
            btnLast.TabIndex = 15;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnPrev
            // 
            btnPrev.Image = (Image)resources.GetObject("btnPrev.Image");
            btnPrev.Location = new Point(214, 609);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(119, 48);
            btnPrev.TabIndex = 16;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(607, 609);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(119, 48);
            btnNext.TabIndex = 17;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(67, 721);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(230, 83);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtRecord
            // 
            txtRecord.Location = new Point(389, 611);
            txtRecord.Name = "txtRecord";
            txtRecord.Size = new Size(157, 47);
            txtRecord.TabIndex = 19;
            txtRecord.TextAlign = HorizontalAlignment.Center;
            txtRecord.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(646, 721);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 83);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(69, 855);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 83);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(646, 855);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(230, 83);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbColour
            // 
            cmbColour.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbColour.BackColor = Color.White;
            cmbColour.DrawMode = DrawMode.OwnerDrawFixed;
            cmbColour.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbColour.FormattingEnabled = true;
            cmbColour.Items.AddRange(new object[] { "Select Colour:", "aqua", "black", "blue", "fuchsia", "gray", "green", "lime", "maroon", "navy", "olive", "orange", "purple", "red", "silver", "teal", "white", "yellow" });
            cmbColour.Location = new Point(486, 204);
            cmbColour.Name = "cmbColour";
            cmbColour.Size = new Size(390, 61);
            cmbColour.TabIndex = 23;

            // 
            // cbxYes
            // 
            cbxYes.AutoSize = true;
            cbxYes.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxYes.Location = new Point(753, 526);
            cbxYes.Name = "cbxYes";
            cbxYes.Size = new Size(123, 56);
            cbxYes.TabIndex = 24;
            cbxYes.Text = "YES";
            cbxYes.UseVisualStyleBackColor = true;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(19F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 1297);
            Controls.Add(cbxYes);
            Controls.Add(cmbColour);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtRecord);
            Controls.Add(btnUpdate);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnLast);
            Controls.Add(btnFirst);
            Controls.Add(txtVin);
            Controls.Add(cmbModel);
            Controls.Add(txtEngine);
            Controls.Add(txtYear);
            Controls.Add(txtRent);
            Controls.Add(lblAvailable);
            Controls.Add(lblRent);
            Controls.Add(lblYear);
            Controls.Add(lblEngine);
            Controls.Add(lblColour);
            Controls.Add(lblModel);
            Controls.Add(lblVin);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmStock";
            Text = "Stock";
            Load += frmStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVin;
        private Label lblModel;
        private Label lblColour;
        private Label lblEngine;
        private Label lblYear;
        private Label lblRent;
        private Label lblAvailable;
        private TextBox txtRent;
        private TextBox txtYear;
        private TextBox txtEngine;
        private ComboBox cmbModel;
        private TextBox txtVin;
        private Button btnFirst;
        private Button btnLast;
        private Button btnPrev;
        private Button btnNext;
        private Button btnUpdate;
        private TextBox txtRecord;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCancel;
        private ComboBox cmbColour;
        private CheckBox cbxYes;
    }
}