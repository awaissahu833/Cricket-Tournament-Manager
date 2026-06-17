using System.Drawing;
using System.Windows.Forms;
using App.WindowsApp.Views;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private DashboardView? _dashboardView;
        private TeamsView? _teamsView;
        private MatchesView? _matchesView;
        private PerformanceView? _performanceView;

        private Button? _activeButton;

        private readonly Color NormalBackColor =
            Color.FromArgb(244, 244, 246);

        private readonly Color ActiveBackColor =
            Color.FromArgb(153, 153, 161);

        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            btnDashboard.Click += (s, e) =>
            {
                ShowDashboard();
                SetActiveButton(btnDashboard);
            };

            btnTeams.Click += (s, e) =>
            {
                ShowTeams();
                SetActiveButton(btnTeams);
            };

            btnMatches.Click += (s, e) =>
            {
                ShowMatches();
                SetActiveButton(btnMatches);
            };

            btnPerformances.Click += (s, e) =>
            {
                ShowPerformances();
                SetActiveButton(btnPerformances);
            };

            ShowDashboard();
            SetActiveButton(btnDashboard);
        }

        private void SetActiveButton(Button button)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = NormalBackColor;
                _activeButton.Font =
                    new Font(_activeButton.Font, FontStyle.Regular);
            }

            _activeButton = button;

            _activeButton.BackColor = ActiveBackColor;
            _activeButton.Font =
                new Font(_activeButton.Font, FontStyle.Bold);
        }

        private void ShowView(UserControl view)
        {
            panelContent.Controls.Clear();

            view.Dock = DockStyle.Fill;

            panelContent.Controls.Add(view);
        }

        private void ShowDashboard()
        {
            if (_dashboardView == null)
                _dashboardView = new DashboardView();

            _dashboardView.RefreshData();

            ShowView(_dashboardView);
        }

        private void ShowTeams()
        {
            if (_teamsView == null)
                _teamsView = new TeamsView(AppConfig.ConnectionString);

            ShowView(_teamsView);
        }

        private void ShowMatches()
        {
            if (_matchesView == null)
                _matchesView = new MatchesView();

            ShowView(_matchesView);
        }

        private void ShowPerformances()
        {
            if (_performanceView == null)
                _performanceView = new PerformanceView();

            _performanceView.RefreshGrids();

            ShowView(_performanceView);
        }
    }
}