using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
            txtTeamId.Text = "T-"+Guid.NewGuid().ToString("N").Substring(0,6);
            txtTeamId.ReadOnly = true;
            btnSave.Click += (s, e) => OnSave();
        }

        private void OnSave()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Team GetTeam()
        {
            return new Team
            {
                TeamId = txtTeamId.Text?.Trim(),
                Name = txtTeamName.Text?.Trim(),
                Captain = txtCaptainName.Text?.Trim(),
                EntryFee = numEntryFee.Value
            };
        }

        public void SetTeam(Team team)
        {
            if (team == null) return;
            txtTeamId.Text = team.TeamId;
            txtTeamId.ReadOnly = true;
            txtTeamName.Text = team.Name;
            txtCaptainName.Text = team.Captain;
            numEntryFee.Value = team.EntryFee;
        }

        public void DisableEditing()
        {
            txtTeamId.ReadOnly = true;
            txtTeamName.ReadOnly = true;
            txtCaptainName.ReadOnly = true;
            numEntryFee.Enabled = false;
            btnSave.Visible = false;
        }
    }
}
