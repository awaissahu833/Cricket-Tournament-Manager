namespace App.WindowsApp.Forms
{
    partial class PerformanceForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPerfId;
        private Label lblTeam;
        private Label lblPlayerId;
        private Label lblPlayerName;

        private TextBox txtPerformanceId;
        private ComboBox cmbTeam;
        private TextBox txtPlayerId;
        private TextBox txtPlayerName;

        private GroupBox grpBatter;
        private GroupBox grpBowler;

        // Batter
        private Label lblRuns;
        private Label lblFours;
        private Label lblSixes;

        private TextBox txtRuns;
        private TextBox txtFours;
        private TextBox txtSixes;

        // Bowler
        private Label lblWickets;
        private Label lblOvers;

        private TextBox txtWickets;
        private TextBox txtOvers;

        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPerfId = new Label();
            lblTeam = new Label();
            lblPlayerId = new Label();
            lblPlayerName = new Label();
            txtPerformanceId = new TextBox();
            cmbTeam = new ComboBox();
            txtPlayerId = new TextBox();
            txtPlayerName = new TextBox();
            grpBatter = new GroupBox();
            lblRuns = new Label();
            txtRuns = new TextBox();
            lblFours = new Label();
            txtFours = new TextBox();
            lblSixes = new Label();
            txtSixes = new TextBox();
            grpBowler = new GroupBox();
            lblWickets = new Label();
            txtWickets = new TextBox();
            lblOvers = new Label();
            txtOvers = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            grpBatter.SuspendLayout();
            grpBowler.SuspendLayout();
            SuspendLayout();
            // 
            // lblPerfId
            // 
            lblPerfId.AutoSize = true;
            lblPerfId.Location = new Point(23, 93);
            lblPerfId.Name = "lblPerfId";
            lblPerfId.Size = new Size(111, 20);
            lblPerfId.TabIndex = 1;
            lblPerfId.Text = "Performance ID";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(23, 187);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(45, 20);
            lblTeam.TabIndex = 5;
            lblTeam.Text = "Team";
            // 
            // lblPlayerId
            // 
            lblPlayerId.AutoSize = true;
            lblPlayerId.Location = new Point(23, 233);
            lblPlayerId.Name = "lblPlayerId";
            lblPlayerId.Size = new Size(68, 20);
            lblPlayerId.TabIndex = 7;
            lblPlayerId.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(23, 280);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(93, 20);
            lblPlayerName.TabIndex = 9;
            lblPlayerName.Text = "Player Name";
            // 
            // txtPerformanceId
            // 
            txtPerformanceId.Location = new Point(194, 89);
            txtPerformanceId.Margin = new Padding(3, 4, 3, 4);
            txtPerformanceId.Name = "txtPerformanceId";
            txtPerformanceId.Size = new Size(342, 27);
            txtPerformanceId.TabIndex = 2;
            // 
            // cmbTeam
            // 
            cmbTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeam.Location = new Point(194, 183);
            cmbTeam.Margin = new Padding(3, 4, 3, 4);
            cmbTeam.Name = "cmbTeam";
            cmbTeam.Size = new Size(342, 28);
            cmbTeam.TabIndex = 6;
            // 
            // txtPlayerId
            // 
            txtPlayerId.Location = new Point(194, 229);
            txtPlayerId.Margin = new Padding(3, 4, 3, 4);
            txtPlayerId.Name = "txtPlayerId";
            txtPlayerId.Size = new Size(342, 27);
            txtPlayerId.TabIndex = 8;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(194, 276);
            txtPlayerName.Margin = new Padding(3, 4, 3, 4);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(342, 27);
            txtPlayerName.TabIndex = 10;
            // 
            // grpBatter
            // 
            grpBatter.Controls.Add(lblRuns);
            grpBatter.Controls.Add(txtRuns);
            grpBatter.Controls.Add(lblFours);
            grpBatter.Controls.Add(txtFours);
            grpBatter.Controls.Add(lblSixes);
            grpBatter.Controls.Add(txtSixes);
            grpBatter.Location = new Point(23, 333);
            grpBatter.Margin = new Padding(3, 4, 3, 4);
            grpBatter.Name = "grpBatter";
            grpBatter.Padding = new Padding(3, 4, 3, 4);
            grpBatter.Size = new Size(514, 160);
            grpBatter.TabIndex = 11;
            grpBatter.TabStop = false;
            grpBatter.Text = "BATTER DETAILS";
            // 
            // lblRuns
            // 
            lblRuns.Location = new Point(17, 40);
            lblRuns.Name = "lblRuns";
            lblRuns.Size = new Size(114, 31);
            lblRuns.TabIndex = 0;
            lblRuns.Text = "Runs";
            // 
            // txtRuns
            // 
            txtRuns.Location = new Point(137, 36);
            txtRuns.Margin = new Padding(3, 4, 3, 4);
            txtRuns.Name = "txtRuns";
            txtRuns.Size = new Size(91, 27);
            txtRuns.TabIndex = 1;
            // 
            // lblFours
            // 
            lblFours.Location = new Point(17, 80);
            lblFours.Name = "lblFours";
            lblFours.Size = new Size(114, 31);
            lblFours.TabIndex = 2;
            lblFours.Text = "Fours";
            // 
            // txtFours
            // 
            txtFours.Location = new Point(137, 76);
            txtFours.Margin = new Padding(3, 4, 3, 4);
            txtFours.Name = "txtFours";
            txtFours.Size = new Size(91, 27);
            txtFours.TabIndex = 3;
            // 
            // lblSixes
            // 
            lblSixes.Location = new Point(17, 120);
            lblSixes.Name = "lblSixes";
            lblSixes.Size = new Size(114, 31);
            lblSixes.TabIndex = 4;
            lblSixes.Text = "Sixes";
            // 
            // txtSixes
            // 
            txtSixes.Location = new Point(137, 116);
            txtSixes.Margin = new Padding(3, 4, 3, 4);
            txtSixes.Name = "txtSixes";
            txtSixes.Size = new Size(91, 27);
            txtSixes.TabIndex = 5;
            // 
            // grpBowler
            // 
            grpBowler.Controls.Add(lblWickets);
            grpBowler.Controls.Add(txtWickets);
            grpBowler.Controls.Add(lblOvers);
            grpBowler.Controls.Add(txtOvers);
            grpBowler.Location = new Point(23, 507);
            grpBowler.Margin = new Padding(3, 4, 3, 4);
            grpBowler.Name = "grpBowler";
            grpBowler.Padding = new Padding(3, 4, 3, 4);
            grpBowler.Size = new Size(514, 160);
            grpBowler.TabIndex = 12;
            grpBowler.TabStop = false;
            grpBowler.Text = "BOWLER DETAILS";
            // 
            // lblWickets
            // 
            lblWickets.Location = new Point(17, 47);
            lblWickets.Name = "lblWickets";
            lblWickets.Size = new Size(114, 31);
            lblWickets.TabIndex = 0;
            lblWickets.Text = "Wickets";
            // 
            // txtWickets
            // 
            txtWickets.Location = new Point(137, 43);
            txtWickets.Margin = new Padding(3, 4, 3, 4);
            txtWickets.Name = "txtWickets";
            txtWickets.Size = new Size(91, 27);
            txtWickets.TabIndex = 1;
            // 
            // lblOvers
            // 
            lblOvers.Location = new Point(17, 93);
            lblOvers.Name = "lblOvers";
            lblOvers.Size = new Size(114, 31);
            lblOvers.TabIndex = 2;
            lblOvers.Text = "Overs Bowled";
            // 
            // txtOvers
            // 
            txtOvers.Location = new Point(137, 89);
            txtOvers.Margin = new Padding(3, 4, 3, 4);
            txtOvers.Name = "txtOvers";
            txtOvers.Size = new Size(91, 27);
            txtOvers.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(194, 693);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 693);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Player Performance Entry";
            // 
            // PerformanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 800);
            Controls.Add(lblTitle);
            Controls.Add(lblPerfId);
            Controls.Add(txtPerformanceId);
            Controls.Add(lblTeam);
            Controls.Add(cmbTeam);
            Controls.Add(lblPlayerId);
            Controls.Add(txtPlayerId);
            Controls.Add(lblPlayerName);
            Controls.Add(txtPlayerName);
            Controls.Add(grpBatter);
            Controls.Add(grpBowler);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PerformanceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Player Performance Entry";
            grpBatter.ResumeLayout(false);
            grpBatter.PerformLayout();
            grpBowler.ResumeLayout(false);
            grpBowler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
    }
}