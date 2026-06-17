using App.Core.Models;
using App.Core.Services;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App.WindowsApp.Forms;
namespace App.WindowsApp.Views
{
    public partial class MatchesView : UserControl
    {
        private readonly DbMatchService _service;

        public MatchesView()
        {
            InitializeComponent();

            cmbStatus.Items.Add("All");

            foreach (MatchStatusEnum status in Enum.GetValues(typeof(MatchStatusEnum)))
            {
                cmbStatus.Items.Add(status);
            }

            _service = new DbMatchService(AppConfig.ConnectionString);

            WireEvents();

            cmbStatus.SelectedIndex = 0;

            RefreshGrid();
        }

        private void WireEvents()
        {
            btnAdd.Click += (s, e) => AddMatch();
            btnEdit.Click += (s, e) => EditSelectedMatch();
            btnView.Click += (s, e) => ViewSelectedMatch();
            btnDelete.Click += (s, e) => DeleteSelectedMatch();
            btnRefresh.Click += (s, e) => RefreshGrid();
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
        }

        private void RefreshGrid()
        {
            dgvMatches.Rows.Clear();

            var matches = _service.GetAll();

            if (cmbStatus.Text != "All")
            {
                matches = matches
                    .Where(m => m.Status.ToString() == cmbStatus.Text)
                    .ToList();
            }

            foreach (var m in matches)
            {
                dgvMatches.Rows.Add(
                    m.MatchId,
                    m.Team1Name,
                    m.Team2Name,
                    m.Status
                );
            }
        }

        private string? GetSelectedId()
        {
            if (dgvMatches.SelectedRows.Count == 0)
                return null;

            return dgvMatches.SelectedRows[0].Cells[0].Value?.ToString();
        }

        private void AddMatch()
        {
            using var form = new MatchForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var match = form.GetMatch();

                //if (string.IsNullOrWhiteSpace(match.MatchId))
                //    match.MatchId = Guid.NewGuid().ToString("N");

                _service.Add(match);
                RefreshGrid();
            }
        }

        private void EditSelectedMatch()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show("Please select a match to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var match = _service.GetById(id);

            if (match == null)
            {
                MessageBox.Show("Match not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var form = new MatchForm();

            form.SetMatch(match);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _service.Update(form.GetMatch());
                RefreshGrid();
            }
        }

        private void ViewSelectedMatch()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show("Please select a match to view.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var match = _service.GetById(id);

            if (match == null)
            {
                MessageBox.Show("Match not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var form = new MatchForm();

            form.SetMatch(match);
            form.DisableEditing();
            form.ShowDialog();
        }

        private void DeleteSelectedMatch()
        {
            var id = GetSelectedId();

            if (id == null)
            {
                MessageBox.Show("Please select a match to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                "Are you sure to delete selected match?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(id);
                RefreshGrid();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}