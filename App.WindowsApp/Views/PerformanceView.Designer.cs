namespace App.WindowsApp.Views
{
    partial class PerformanceView
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblBatters;
        private Label lblBowlers;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnView;
        private Button btnDelete;
        private Button btnRefresh;

        private DataGridView dgvBatters;
        private DataGridView dgvBowlers;

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
            lblBatters = new Label();
            lblBowlers = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvBatters = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dgvBowlers = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            lblSearch = new Label();
            txtSearchPlayer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBatters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Player Performances";
            // 
            // lblBatters
            // 
            lblBatters.AutoSize = true;
            lblBatters.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBatters.Location = new Point(20, 180);
            lblBatters.Name = "lblBatters";
            lblBatters.Size = new Size(91, 25);
            lblBatters.TabIndex = 9;
            lblBatters.Text = "BATTERS";
            // 
            // lblBowlers
            // 
            lblBowlers.AutoSize = true;
            lblBowlers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBowlers.Location = new Point(20, 410);
            lblBowlers.Name = "lblBowlers";
            lblBowlers.Size = new Size(100, 25);
            lblBowlers.TabIndex = 11;
            lblBowlers.Text = "BOWLERS";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Image = Properties.Resources.square_plus;
            btnAdd.Location = new Point(20, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Image = Properties.Resources.edit1;
            btnEdit.Location = new Point(120, 120);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnView
            // 
            btnView.AutoSize = true;
            btnView.Image = Properties.Resources.eye;
            btnView.Location = new Point(220, 120);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 54);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Image = Properties.Resources.square_minus1;
            btnDelete.Location = new Point(320, 120);
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
            btnRefresh.Location = new Point(437, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 54);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // dgvBatters
            // 
            dgvBatters.AllowUserToAddRows = false;
            dgvBatters.AllowUserToDeleteRows = false;
            dgvBatters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatters.BackgroundColor = Color.White;
            dgvBatters.ColumnHeadersHeight = 29;
            dgvBatters.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvBatters.Location = new Point(20, 210);
            dgvBatters.Name = "dgvBatters";
            dgvBatters.ReadOnly = true;
            dgvBatters.RowHeadersVisible = false;
            dgvBatters.RowHeadersWidth = 51;
            dgvBatters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatters.Size = new Size(1130, 180);
            dgvBatters.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Player ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Team";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Runs";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "4s";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "6s";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dgvBowlers
            // 
            dgvBowlers.AllowUserToAddRows = false;
            dgvBowlers.AllowUserToDeleteRows = false;
            dgvBowlers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBowlers.BackgroundColor = Color.White;
            dgvBowlers.ColumnHeadersHeight = 29;
            dgvBowlers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgvBowlers.Location = new Point(20, 440);
            dgvBowlers.Name = "dgvBowlers";
            dgvBowlers.ReadOnly = true;
            dgvBowlers.RowHeadersVisible = false;
            dgvBowlers.RowHeadersWidth = 51;
            dgvBowlers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBowlers.Size = new Size(1130, 180);
            dgvBowlers.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Player ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Name";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Team";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Wickets";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Overs";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 75);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Player:";
            // 
            // txtSearchPlayer
            // 
            txtSearchPlayer.Location = new Point(140, 72);
            txtSearchPlayer.Name = "txtSearchPlayer";
            txtSearchPlayer.Size = new Size(200, 27);
            txtSearchPlayer.TabIndex = 2;
            //txtSearchPlayer.TextChanged += txtSearchPlayer_TextChanged;
            // 
            // PerformanceView
            // 
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearchPlayer);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(lblBatters);
            Controls.Add(dgvBatters);
            Controls.Add(lblBowlers);
            Controls.Add(dgvBowlers);
            Name = "PerformanceView";
            Size = new Size(1200, 750);
            ((System.ComponentModel.ISupportInitialize)dgvBatters).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBowlers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Label lblSearch;
        private TextBox txtSearchPlayer;
    }
}