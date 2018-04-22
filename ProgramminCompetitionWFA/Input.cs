using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ProgramingCompetitionLibrary;
using ProgramingCompetitionLibrary.Models;

namespace ProgramminCompetitionWFA
{
    public partial class Input : Form
    {
        private const string TaskModel = "Excercises.csv";
        public Input()
        {
            InitializeComponent();
            LoadDropDown();
        }

        private void InputLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoadDropDown()
        {
            List<TaskModel> taskModels = TaskModel.FullFilepath().LoadFile().ConvertToTaskModel();
            List<string> taskNames = null;

            foreach (var p in taskModels)
            {
                TaskDropDownList.Items.Add(p.TaskName);

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                string output = OutputModel.FetchData(SolutionTextBox.Text);
                OutputTextBox.Text = output;
                
            }
            else
            {
                MessageBox.Show("Missing Nickname, Solution Or Task not selected");
            }
            
        }

        private bool ValidForm()
        {
            bool output = true;

            if (NicknameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (SolutionTextBox.Text.Length == 0)
            {
                return false;
            }

            if (TaskDropDownList.SelectedIndex == -1)
            {
                return false;
            }


            return output;
        }


    }
}
