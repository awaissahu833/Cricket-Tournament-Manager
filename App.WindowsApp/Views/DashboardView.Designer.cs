namespace App.WindowsApp.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTeams;

        private Label lblTeamsTitle;

        private Label lblTeamsCount;

        private GroupBox grpBatters;
        private GroupBox grpBowlers;

        private DataGridView dgvTopBatters;
        private DataGridView dgvTopBowlers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlTeams = new Panel();
            lblTeamsTitle = new Label();
            lblTeamsCount = new Label();
            grpBatters = new GroupBox();
            dgvTopBatters = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            grpBowlers = new GroupBox();
            dgvTopBowlers = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            pnlTeams.SuspendLayout();
            grpBatters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopBatters).BeginInit();
            grpBowlers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopBowlers).BeginInit();
            SuspendLayout();
            // 
            // pnlTeams
            // 
            pnlTeams.BorderStyle = BorderStyle.FixedSingle;
            pnlTeams.Controls.Add(lblTeamsTitle);
            pnlTeams.Controls.Add(lblTeamsCount);
            pnlTeams.Location = new Point(20, 20);
            pnlTeams.Name = "pnlTeams";
            pnlTeams.Size = new Size(250, 100);
            pnlTeams.TabIndex = 0;
            // 
            // lblTeamsTitle
            // 
            lblTeamsTitle.AutoSize = true;
            lblTeamsTitle.Location = new Point(10, 10);
            lblTeamsTitle.Name = "lblTeamsTitle";
            lblTeamsTitle.Size = new Size(88, 20);
            lblTeamsTitle.TabIndex = 0;
            lblTeamsTitle.Text = "Total Teams";
            // 
            // lblTeamsCount
            // 
            lblTeamsCount.AutoSize = true;
            lblTeamsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTeamsCount.Location = new Point(10, 40);
            lblTeamsCount.Name = "lblTeamsCount";
            lblTeamsCount.Size = new Size(40, 46);
            lblTeamsCount.TabIndex = 1;
            lblTeamsCount.Text = "0";
            // 
            // grpBatters
            // 
            grpBatters.Controls.Add(dgvTopBatters);
            grpBatters.Location = new Point(20, 140);
            grpBatters.Name = "grpBatters";
            grpBatters.Size = new Size(560, 250);
            grpBatters.TabIndex = 4;
            grpBatters.TabStop = false;
            grpBatters.Text = "Top 5 Batters";
            // 
            // dgvTopBatters
            // 
            dgvTopBatters.AllowUserToAddRows = false;
            dgvTopBatters.BackgroundColor = Color.White;
            dgvTopBatters.ColumnHeadersHeight = 29;
            dgvTopBatters.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvTopBatters.Dock = DockStyle.Fill;
            dgvTopBatters.Location = new Point(3, 23);
            dgvTopBatters.Name = "dgvTopBatters";
            dgvTopBatters.ReadOnly = true;
            dgvTopBatters.RowHeadersVisible = false;
            dgvTopBatters.RowHeadersWidth = 51;
            dgvTopBatters.Size = new Size(554, 224);
            dgvTopBatters.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Player ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Runs";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Fours";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Sixes";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // grpBowlers
            // 
            grpBowlers.Controls.Add(dgvTopBowlers);
            grpBowlers.Location = new Point(600, 140);
            grpBowlers.Name = "grpBowlers";
            grpBowlers.Size = new Size(550, 250);
            grpBowlers.TabIndex = 5;
            grpBowlers.TabStop = false;
            grpBowlers.Text = "Top 5 Bowlers";
            // 
            // dgvTopBowlers
            // 
            dgvTopBowlers.AllowUserToAddRows = false;
            dgvTopBowlers.BackgroundColor = Color.White;
            dgvTopBowlers.ColumnHeadersHeight = 29;
            dgvTopBowlers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvTopBowlers.Dock = DockStyle.Fill;
            dgvTopBowlers.Location = new Point(3, 23);
            dgvTopBowlers.Name = "dgvTopBowlers";
            dgvTopBowlers.ReadOnly = true;
            dgvTopBowlers.RowHeadersVisible = false;
            dgvTopBowlers.RowHeadersWidth = 51;
            dgvTopBowlers.Size = new Size(544, 224);
            dgvTopBowlers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Player ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Name";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Wickets";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Overs";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // DashboardView
            // 
            Controls.Add(pnlTeams);
            Controls.Add(grpBatters);
            Controls.Add(grpBowlers);
            Name = "DashboardView";
            Size = new Size(1200, 750);
            pnlTeams.ResumeLayout(false);
            pnlTeams.PerformLayout();
            grpBatters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopBatters).EndInit();
            grpBowlers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopBowlers).EndInit();
            ResumeLayout(false);
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
    }
}