using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BeautifyBranchNaming
{
    public partial class BeautifyBranchNamingForm : Form
    {
        private enum BranchTypes
        {
            Features,
            Bugs,
            Tasks
        }

        public BeautifyBranchNamingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string branchType in Enum.GetNames(typeof(BranchTypes)))
            {
                ddlBranchType.Items.Add(branchType);
            }
            ddlBranchType.SelectedIndex = 0;
        }

        private void btnBeautify_Click(object sender, EventArgs e)
        {
            string trimmedBranchName = txtBranchName.Text.TrimStart().TrimEnd();
            txtBranchName.Text = trimmedBranchName.ToLower().Replace(" ", "-").Replace("/", "-");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{txtBranchType.Text}{txtBranchName.Text}");
        }

        private void ddlBranchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string FeaturesPrefix = "features/";
            const string BugsPrefix = "bugs/";
            const string TasksPrefix = "tasks/";

            switch (ddlBranchType.SelectedIndex)
            {
                case (int)BranchTypes.Features:
                    txtBranchType.Text = FeaturesPrefix;
                    break;
                case (int)BranchTypes.Bugs:
                    txtBranchType.Text = BugsPrefix;
                    break;
                case (int)BranchTypes.Tasks:
                    txtBranchType.Text = TasksPrefix;
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBranchName.Text = string.Empty;
        }
    }
}
