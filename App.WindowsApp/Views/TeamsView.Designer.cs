namespace App.WindowsApp.Views
{
    partial class TeamsView
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnView;
        private Button btnDelete;
        private Button btnRefresh;

        private DataGridView dgvTeams;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvTeams = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            colEntryFee = new DataGridViewTextBoxColumn();
            txtSearchlbl = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeams).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registered Teams";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Image = Properties.Resources.square_plus;
            btnAdd.Location = new Point(20, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 54);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Team";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(161, 120);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 54);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnView
            // 
            btnView.AutoSize = true;
            btnView.Image = Properties.Resources.eye;
            btnView.Location = new Point(260, 120);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 54);
            btnView.TabIndex = 5;
            btnView.Text = "View";
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Image = Properties.Resources.square_minus;
            btnDelete.Location = new Point(365, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.Image = Properties.Resources.rotate_clockwise;
            btnRefresh.Location = new Point(482, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 54);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // dgvTeams
            // 
            dgvTeams.AllowUserToAddRows = false;
            dgvTeams.AllowUserToDeleteRows = false;
            dgvTeams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeams.BackgroundColor = Color.White;
            dgvTeams.ColumnHeadersHeight = 29;
            dgvTeams.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, colEntryFee });
            dgvTeams.Location = new Point(20, 180);
            dgvTeams.MultiSelect = false;
            dgvTeams.Name = "dgvTeams";
            dgvTeams.ReadOnly = true;
            dgvTeams.RowHeadersVisible = false;
            dgvTeams.RowHeadersWidth = 51;
            dgvTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeams.Size = new Size(1130, 520);
            dgvTeams.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Team ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Team Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Captain";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // colEntryFee
            // 
            dataGridViewCellStyle1.Format = "C2";
            colEntryFee.DefaultCellStyle = dataGridViewCellStyle1;
            colEntryFee.HeaderText = "Entry Fee";
            colEntryFee.MinimumWidth = 6;
            colEntryFee.Name = "colEntryFee";
            colEntryFee.ReadOnly = true;
            // 
            // txtSearchlbl
            // 
            txtSearchlbl.AutoSize = true;
            txtSearchlbl.Location = new Point(31, 72);
            txtSearchlbl.Name = "txtSearchlbl";
            txtSearchlbl.Size = new Size(56, 20);
            txtSearchlbl.TabIndex = 9;
            txtSearchlbl.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(93, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(266, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // TeamsView
            // 
            Controls.Add(txtSearch);
            Controls.Add(txtSearchlbl);
            Controls.Add(lblTitle);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvTeams);
            Name = "TeamsView";
            Size = new Size(1200, 750);
            ((System.ComponentModel.ISupportInitialize)dgvTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn colEntryFee;
        private Label txtSearchlbl;
        private TextBox txtSearch;
    }
}