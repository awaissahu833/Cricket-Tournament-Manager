using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App.Core.Services;
using App.Core.Models;
using App.WindowsApp.Forms;
namespace App.WindowsApp.Views
{
    public partial class PerformanceView : UserControl
    {
        private readonly DbPerformanceService _dbPerfSvc;
        private DataGridView? _activeGrid;

        public PerformanceView()
        {
            InitializeComponent();

            if (AppConfig.DbPerformanceService == null)
            {
                AppConfig.DbPerformanceService =
                    new DbPerformanceService(AppConfig.ConnectionString);
            }

            _dbPerfSvc = AppConfig.DbPerformanceService;

            WireEvents();
            RefreshGrids();
        }

        private void WireEvents()
        {
            btnRefresh.Click += (s, e) => RefreshGrids();
            btnAdd.Click += (s, e) => OnAdd();
            btnEdit.Click += (s, e) => OnEdit();
            btnView.Click += (s, e) => OnView();
            btnDelete.Click += (s, e) => OnDelete();

            txtSearchPlayer.TextChanged += (s, e) => RefreshGrids();

            // 🔥 Track active grid
            dgvBatters.CellClick += (s, e) => _activeGrid = dgvBatters;
            dgvBowlers.CellClick += (s, e) => _activeGrid = dgvBowlers;
        }

        public async Task RefreshGrids()
        {
            dgvBatters.Rows.Clear();
            dgvBowlers.Rows.Clear();

            List<Performance> list =  _dbPerfSvc.GetAll();

            string keyword = txtSearchPlayer.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                list = list.FindAll(p =>
                    p.PlayerName.ToLower().Contains(keyword));
            }

            foreach (var p in list)
            {
                // Batters
                if (p.Runs > 0)
                {
                    int idx = dgvBatters.Rows.Add(
                        p.PlayerId,
                        p.PlayerName,
                        p.TeamName,
                        p.Runs,
                        p.Fours,
                        p.Sixes);

                    dgvBatters.Rows[idx].Tag = p.PerformanceId;
                }

                // Bowlers
                if (p.Wickets > 0 || !string.IsNullOrWhiteSpace(p.Overs))
                {
                    int idx = dgvBowlers.Rows.Add(
                        p.PlayerId,
                        p.PlayerName,
                        p.TeamName,
                        p.Wickets,
                        p.Overs);

                    dgvBowlers.Rows[idx].Tag = p.PerformanceId;
                }
            }
        }

        private string? GetSelectedPerformanceId()
        {
            if (_activeGrid?.SelectedRows.Count > 0)
                return _activeGrid.SelectedRows[0].Tag?.ToString();

            return null;
        }

        private void OnAdd()
        {
            using var form = new PerformanceForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var perf = new App.Core.Models.Performance
                {
                    PerformanceId = string.IsNullOrWhiteSpace(form.GetPerformanceId())
                        ? Guid.NewGuid().ToString("N")
                        : form.GetPerformanceId(),

                    PlayerId = form.GetPlayerId(),
                    PlayerName = form.GetPlayerName(),
                    TeamName = form.GetTeamText(),

                    Runs = form.GetRuns(),
                    Fours = form.GetFours(),
                    Sixes = form.GetSixes(),

                    Wickets = form.GetWickets(),
                    Overs = form.GetOvers()
                };

                _dbPerfSvc.Add(perf);
                RefreshGrids();
            }
        }

        private void OnView()
        {
            var id = GetSelectedPerformanceId();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Select a performance to view.");
                return;
            }

            var p = _dbPerfSvc.GetAll()
                              .Find(x => x.PerformanceId == id);

            if (p == null)
            {
                MessageBox.Show("Performance not found.");
                return;
            }

            using var form = new App.WindowsApp.Forms.PerformanceForm();

            form.SetPerformance(p);
            form.DisableEditing();
            form.ShowDialog();
        }

        private void OnEdit()
        {
            var id = GetSelectedPerformanceId();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Select a performance to edit.");
                return;
            }

            var p = _dbPerfSvc.GetAll()
                              .Find(x => x.PerformanceId == id);

            if (p == null)
            {
                MessageBox.Show("Performance not found.");
                return;
            }

            using var form = new App.WindowsApp.Forms.PerformanceForm();

            form.SetPerformance(p);

            if (form.ShowDialog() == DialogResult.OK)
            {
                p.PlayerId = form.GetPlayerId();
                p.PlayerName = form.GetPlayerName();
                p.TeamName = form.GetTeamText();

                p.Runs = form.GetRuns();
                p.Fours = form.GetFours();
                p.Sixes = form.GetSixes();

                p.Wickets = form.GetWickets();
                p.Overs = form.GetOvers();

                _dbPerfSvc.Update(p);
                RefreshGrids();
            }
        }

        private void OnDelete()
        {
            var id = GetSelectedPerformanceId();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Select a performance to delete.");
                return;
            }

            if (MessageBox.Show(
                "Delete selected performance?",
                "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _dbPerfSvc.Delete(id);
                RefreshGrids();
            }
        }
    }
}