using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderCreator;

namespace UI
{
    public partial class FolderCreator : Form
    {
        public FolderCreator()
        {
            InitializeComponent();
            TurnValidationOff = true;
        }

        private bool KeepTrackOffValidation;

        private bool TurnValidationOff;

        private void projectName_MouseClick(object sender, MouseEventArgs e)
        {
            if (projectName.Text.Trim() != "" || projectName.Text != null)
            {
                projectName.Text = "";
            }
        }

        private void projectDate_MouseClick(object sender, MouseEventArgs e)
        {
            if (projectDate.Text.Trim() != "" || projectDate.Text != null)
            {
                projectDate.Text = "";
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string error = null;
            string error2 = null;

            if (projectDate.Text.Length == 0 && projectName.Text.Length == 0)
            {
                submit.Visible = false;
                error = "Please enter a project date";
                error2 = "Please enter project name";
                var ErrorWarming = new ErrorProvider();
                ErrorWarming.SetError(projectDate, error);
                ErrorWarming.SetError(projectName, error2);

            }
            else
            {
                var date = projectDate.Text;
                var pName = projectName.Text;
                var folderPath = projectPath.Text;

                var StartFolderCreator = new creator().FolderRequirements(folderPath, date, pName);

                // reset values to empty string 
                var pdate = projectDate.Text == "";
                var pPath = projectPath.Text == "";
                var newPname = projectName.Text == "";

            }
            

        }

        private void todayDate_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Today;

            if (projectDate.Text.Trim() != "" || projectDate.Text != null)
            {
                projectDate.Text = "";
            }

            if (projectDate.Text.Length == 0)
            {
                TurnValidationOff = true;

                KeepTrackOffValidation = TurnValidationOff;
            }

            projectDate.AppendText(currentDate.ToString("MM.dd.yy"));


        }

        private void projectPath_MouseClick(object sender, MouseEventArgs e)
        {
            if (projectPath.Text.Trim() != "" || projectPath.Text != null)
            {
                projectPath.Text = "";
            }
        }

        private void browseFilePath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (DialogResult.OK == folderDialog.ShowDialog())
                {
                    projectPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void projectDate_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (projectDate.Text.Length == 0)
            {
                error = "Please enter a date";
                KeepTrackOffValidation = e.Cancel = TurnValidationOff;

            }
            var ErrorWarming = new ErrorProvider();
            ErrorWarming.SetError(projectDate, error);
        }

        private void projectName_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (projectName.Text.Length == 0)
            {
                error = "Please enter a date";
                e.Cancel = true;
            }
            var ErrorWarming = new ErrorProvider();
            ErrorWarming.SetError(projectName, error);
        }
    }
}
