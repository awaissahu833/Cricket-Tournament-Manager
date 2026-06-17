using System;
using System.Windows.Forms;
using App.Core.Services;

namespace App.WindowsApp.Views
{
    public partial class DashboardView : UserControl
    {
        private readonly DbTeamService _teamService;

        public DashboardView()
        {

            InitializeComponent();
            _teamService = new DbTeamService(AppConfig.ConnectionString);
            
            AppConfig.DbPerformanceService ??= new DbPerformanceService(AppConfig.ConnectionString);
            RefreshData();
        }

        public void RefreshData()
        {
            var teams = _teamService?.GetAll();
            SetLabelText("lblTeamsCount", teams?.Count.ToString() ?? "0");

            

            
            if (dgvTopBatters != null && dgvTopBowlers != null)
            {
                dgvTopBatters.Rows.Clear();
                dgvTopBowlers.Rows.Clear();

                var perfService = AppConfig.DbPerformanceService;
                if (perfService != null)
                {
                    var batters = perfService.GetTopBatters(5);
                    if (batters != null)
                    {
                        foreach (var b in batters)
                            dgvTopBatters.Rows.Add(b.PlayerId, b.PlayerName, b.Runs, b.Fours, b.Sixes);
                    }

                    var bowlers = perfService.GetTopBowlers(5);
                    if (bowlers != null)
                    {
                        foreach (var b in bowlers)
                            dgvTopBowlers.Rows.Add(b.PlayerId, b.PlayerName, b.Wickets, b.Overs);
                    }
                }
            }
        }

        private void SetLabelText(string labelName, string text)
        {
            var ctrls = this.
                Controls?.Find(labelName, true);
            if (ctrls != null && ctrls.Length > 0 && ctrls[0] is Label lbl)
            {
                lbl.Text = text;
            }
        }
    }
}
