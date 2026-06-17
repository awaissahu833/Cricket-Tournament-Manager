using App.Core.Models;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App.WindowsApp.Forms;
namespace App.WindowsApp.Views
{
    public partial class TeamsView : UserControl
    {
        private readonly DbTeamService _service;

        public TeamsView()
        {
            InitializeComponent();
            _service = new DbTeamService(AppConfig.ConnectionString);
            WireEvents();
            RefreshGrid();
        }

        public TeamsView(string connectionString)
        {
            InitializeComponent();
            _service = new DbTeamService(connectionString);
            WireEvents();
            RefreshGrid();
        }

        private void WireEvents()
        {
            btnAdd.Click += (s, e) => AddTeam();
            btnEdit.Click += (s, e) => EditSelectedTeam();
            btnView.Click += (s, e) => ViewSelectedTeam();
            btnDelete.Click += (s, e) => DeleteSelectedTeam();
            btnRefresh.Click += (s, e) => RefreshGrid();

            txtSearch.TextChanged += (s, e) => RefreshGrid(txtSearch.Text);
        }

        private void RefreshGrid()
        {
            RefreshGrid(null);
        }

        private void RefreshGrid(string? keyword)
        {
            dgvTeams.Rows.Clear();

            List<Team> teams;

            if (string.IsNullOrWhiteSpace(keyword))
                teams = _service.GetAll();
            else
                teams = _service.Search(keyword);

            foreach (var t in teams)
            {
                dgvTeams.Rows.Add(
                    t.TeamId,
                    t.Name,
                    t.Captain,
                    t.EntryFee
                );
            }
        }

        private string? GetSelectedId()
        {
            if (dgvTeams.SelectedRows.Count == 0)
                return null;

            return dgvTeams.SelectedRows[0].Cells[0].Value?.ToString();
        }

        private void AddTeam()
        {
            using var form = new App.WindowsApp.Forms.TeamForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var team = form.GetTeam();

                if (string.IsNullOrWhiteSpace(team.TeamId))
                    team.TeamId = Guid.NewGuid().ToString("N");

                _service.Add(team);
                RefreshGrid();
            }
        }

        private void EditSelectedTeam()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show(
                    "Please select a team to edit.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            var team = _service.GetById(id);

            if (team == null)
            {
                MessageBox.Show(
                    "Team not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using var form = new App.WindowsApp.Forms.TeamForm();

            form.SetTeam(team);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var updated = form.GetTeam();

                _service.Update(updated);
                RefreshGrid();
            }
        }

        private void ViewSelectedTeam()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show(
                    "Please select a team to view.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            var team = _service.GetById(id);

            if (team == null)
            {
                MessageBox.Show(
                    "Team not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using var form = new TeamForm();

            form.SetTeam(team);
            form.DisableEditing();

            form.ShowDialog();
        }

        private void DeleteSelectedTeam()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show(
                    "Please select a team to delete.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (MessageBox.Show(
                "Are you sure to delete selected team?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(id);
                RefreshGrid();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(txtSearch.Text);
        }
    }
}