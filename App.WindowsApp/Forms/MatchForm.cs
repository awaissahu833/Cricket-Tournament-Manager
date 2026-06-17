using System;
using System.Windows.Forms;
using App.Core.Models;
using App.Core.Services;
using App.Core.Utilities;

namespace App.WindowsApp.Forms
{
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();
            txtMatchId.Text = "M-"+Guid.NewGuid().ToString("N").Substring(0, 6);
            txtMatchId.ReadOnly = true;
            btnSave.Click += (s, e) => OnSave();
            btnCancel.Click += (s, e) => OnCancel();
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            LoadTeams();
            LoadStatuses();
        }

        private void OnCancel()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadTeams()
        {
            var svc = new DbTeamService(AppConfig.ConnectionString);
            var teams = svc.GetAll() ?? new System.Collections.Generic.List<Team>();
            cmbTeamA.DisplayMember = "Name";
            cmbTeamA.ValueMember = "TeamId";
            cmbTeamA.DataSource = teams;

            cmbTeamB.DisplayMember = "Name";
            cmbTeamB.ValueMember = "TeamId";
            cmbTeamB.DataSource = new System.Collections.Generic.List<Team>(teams);
        }

        private void OnSave()
        {
            var teamA = cmbTeamA.SelectedValue?.ToString();
            var teamB = cmbTeamB.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(teamA))
            {
                MessageBox.Show("Please select Team A.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teamB))
            {
                MessageBox.Show("Please select Team B.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (teamA == teamB)
            {
                MessageBox.Show("Team A and Team B must be different.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public Match GetMatch()
        {
            return new Match
            {
                MatchId = txtMatchId.Text.Trim(),
                Team1Id = cmbTeamA.SelectedValue?.ToString() ?? cmbTeamA.Text,
                Team2Id = cmbTeamB.SelectedValue?.ToString() ?? cmbTeamB.Text,
                Status = cmbStatus.SelectedItem is MatchStatusEnum s ? s : MatchStatusEnum.Scheduled
            };
        }

        private void LoadStatuses()
        {
            cmbStatus.DisplayMember = "";
            cmbStatus.ValueMember = "";
            cmbStatus.Items.Clear();
            foreach (var s in Enum.GetValues(typeof(MatchStatusEnum)))
            {
                cmbStatus.Items.Add((MatchStatusEnum)s);
            }
            cmbStatus.SelectedItem = MatchStatusEnum.Scheduled;
        }

        public void SetMatch(Match m)
        {
            if (m == null) return;

            txtMatchId.Text = m.MatchId;
            txtMatchId.ReadOnly = true;
            if (cmbTeamA.DataSource != null)
            {
                try { cmbTeamA.SelectedValue = m.Team1Id; } catch { cmbTeamA.Text = m.Team1Id; }
            }
            if (cmbTeamB.DataSource != null)
            {
                try { cmbTeamB.SelectedValue = m.Team2Id; } catch { cmbTeamB.Text = m.Team2Id; }
            }
            try { cmbStatus.SelectedItem = m.Status; } catch { cmbStatus.SelectedItem = MatchStatusEnum.Scheduled; }
        }

        public void DisableEditing()
        {
            txtMatchId.ReadOnly = true;
            cmbTeamA.Enabled = false;
            cmbTeamB.Enabled = false;
            btnSave.Visible = false;
            cmbStatus.Enabled = false;
        }
    }
}
