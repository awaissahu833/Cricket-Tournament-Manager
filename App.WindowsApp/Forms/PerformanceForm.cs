using App.Core.Models;
using System;
using System.Windows.Forms;
using App.Core.Services;
using System.Collections.Generic;
using App.Core.Utilities;
 
namespace App.WindowsApp.Forms
{
    public partial class PerformanceForm : Form
    {
        public PerformanceForm()
        {
            InitializeComponent();
            txtPerformanceId.Text = "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
            txtPlayerId.Text = "G-" + Guid.NewGuid().ToString("N").Substring(0, 6);
            txtPlayerId.ReadOnly = true;
            txtPerformanceId.ReadOnly = true;
            btnSave.Click += (s, e) => OnSave();
            btnCancel.Click += (s, e) => OnCancel();
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            LoadTeams();
        }

        private void LoadTeams()
        {
            var teamSvc = new DbTeamService(AppConfig.ConnectionString);
            var teams = teamSvc.GetAll() ?? new List<Team>();
            cmbTeam.DisplayMember = "Name";
            cmbTeam.ValueMember = "TeamId";
            cmbTeam.DataSource = teams;
        }

        private void OnSave()
        {
            if (cmbTeam.Items.Count > 0 && cmbTeam.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a team.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string GetPlayerId()
        {
            return txtPlayerId.Text.Trim();
        }

        public string GetPlayerName()
        {
            return txtPlayerName.Text.Trim();
        }

        public string GetTeamText()
        {
            return cmbTeam.Text;
        }

        public int GetRuns()
        {
            return int.TryParse(txtRuns.Text.Trim(), out var value) ? value : 0;
        }

        public int GetFours()
        {
            return int.TryParse(txtFours.Text.Trim(), out var value) ? value : 0;
        }

        public int GetSixes()
        {
            return int.TryParse(txtSixes.Text.Trim(), out var value) ? value : 0;
        }

        public int GetWickets()
        {
            return int.TryParse(txtWickets.Text.Trim(), out var value) ? value : 0;
        }

        public string GetOvers()
        {
            return txtOvers.Text.Trim() == ""
                ? "0"
                : txtOvers.Text.Trim();
        }

        public void SetPerformance(Performance p)
        {
            if (p == null) return;

            txtPerformanceId.Text = p.PerformanceId;
            txtPerformanceId.ReadOnly = true;
            txtPlayerId.Text = p.PlayerId;
            txtPlayerName.Text = p.PlayerName;
            cmbTeam.Text = p.TeamName;
            txtRuns.Text = p.Runs.ToString();
            txtFours.Text = p.Fours.ToString();
            txtSixes.Text = p.Sixes.ToString();
            txtWickets.Text = p.Wickets.ToString();
            txtOvers.Text = p.Overs.ToString();
                //string.Empty;
        }

        public string GetPerformanceId()
        {
            return txtPerformanceId.Text.Trim();
        }

        public void DisableEditing()
        {
            txtPerformanceId.ReadOnly = true;
            txtPlayerId.ReadOnly = true;
            txtPlayerName.ReadOnly = true;
            cmbTeam.Enabled = false;
            txtRuns.ReadOnly = true;
            txtFours.ReadOnly = true;
            txtSixes.ReadOnly = true;
            txtWickets.ReadOnly = true;
            txtOvers.ReadOnly = true;
            btnSave.Visible = false;
        }
    }
}
