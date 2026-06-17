namespace App.WindowsApp.Forms
{
    partial class TeamForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblTeamId;
        private Label lblTeamName;
        private Label lblCaptainName;
        private Label lblEntryFee;

        private TextBox txtTeamId;
        private TextBox txtTeamName;
        private TextBox txtCaptainName;
        private NumericUpDown numEntryFee;

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
            lblTitle = new Label();

            lblTeamId = new Label();
            lblTeamName = new Label();
            lblCaptainName = new Label();
            lblEntryFee = new Label();

            txtTeamId = new TextBox();
            txtTeamName = new TextBox();
            txtCaptainName = new TextBox();

            numEntryFee = new NumericUpDown();

            btnSave = new Button();
            btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)numEntryFee).BeginInit();

            SuspendLayout();

            // 
            // TeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 320);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Team Registration";

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Text = "Team Registration";

            // 
            // lblTeamId
            // 
            lblTeamId.AutoSize = true;
            lblTeamId.Location = new Point(20, 70);
            lblTeamId.Text = "Team ID";

            // 
            // txtTeamId
            // 
            txtTeamId.Location = new Point(150, 67);
            txtTeamId.Size = new Size(220, 23);

            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Location = new Point(20, 105);
            lblTeamName.Text = "Team Name";

            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(150, 102);
            txtTeamName.Size = new Size(220, 23);

            // 
            // lblCaptainName
            // 
            lblCaptainName.AutoSize = true;
            lblCaptainName.Location = new Point(20, 140);
            lblCaptainName.Text = "Captain Name";

            // 
            // txtCaptainName
            // 
            txtCaptainName.Location = new Point(150, 137);
            txtCaptainName.Size = new Size(220, 23);

            // 
            // lblEntryFee
            // 
            lblEntryFee.AutoSize = true;
            lblEntryFee.Location = new Point(20, 175);
            lblEntryFee.Text = "Entry Fee";

            // 
            // numEntryFee
            // 
            numEntryFee.Location = new Point(150, 172);
            numEntryFee.Maximum = 1000000;
            numEntryFee.Minimum = 0;
            numEntryFee.Size = new Size(220, 23);

            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 230);
            btnSave.Size = new Size(100, 35);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;

            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 230);
            btnCancel.Size = new Size(100, 35);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //btnCancel.Click += (s, e) => this.Close();

            // 
            // Controls
            // 
            Controls.Add(lblTitle);

            Controls.Add(lblTeamId);
            Controls.Add(txtTeamId);

            Controls.Add(lblTeamName);
            Controls.Add(txtTeamName);

            Controls.Add(lblCaptainName);
            Controls.Add(txtCaptainName);

            Controls.Add(lblEntryFee);
            Controls.Add(numEntryFee);

            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            ((System.ComponentModel.ISupportInitialize)numEntryFee).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}