namespace App.WindowsApp.Views
{
    partial class MatchesView
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnView;
        private Button btnDelete;
        private Button btnRefresh;

        private DataGridView dgvMatches;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvMatches = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            lblstatus = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Match Schedule";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Image = Properties.Resources.square_plus;
            btnAdd.Location = new Point(20, 75);
            btnAdd.Margin = new Padding(3, 3, 10, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Match";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Image = Properties.Resources.edit2;
            btnEdit.Location = new Point(173, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Match";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnView
            // 
            btnView.AutoSize = true;
            btnView.Image = Properties.Resources.eye;
            btnView.Location = new Point(329, 75);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 54);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Image = Properties.Resources.square_minus;
            btnDelete.Location = new Point(578, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 54);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.Image = Properties.Resources.rotate_clockwise1;
            btnRefresh.Location = new Point(445, 75);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 54);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // dgvMatches
            // 
            dgvMatches.AllowUserToAddRows = false;
            dgvMatches.AllowUserToDeleteRows = false;
            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.BackgroundColor = Color.White;
            dgvMatches.ColumnHeadersHeight = 29;
            dgvMatches.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvMatches.Location = new Point(20, 135);
            dgvMatches.MultiSelect = false;
            dgvMatches.Name = "dgvMatches";
            dgvMatches.ReadOnly = true;
            dgvMatches.RowHeadersVisible = false;
            dgvMatches.RowHeadersWidth = 51;
            dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.Size = new Size(1130, 565);
            dgvMatches.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Match ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Team A";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Team B";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(795, 88);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(70, 25);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(871, 89);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 11;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // MatchesView
            // 
            Controls.Add(cmbStatus);
            Controls.Add(lblstatus);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMatches);
            Name = "MatchesView";
            Size = new Size(1200, 750);
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label lblstatus;
        private ComboBox cmbStatus;
    }
}
