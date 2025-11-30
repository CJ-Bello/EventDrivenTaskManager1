namespace EventDrivenTaskManager1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnAddTask.Click += btnAddTask_Click;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            btnClearAll.Click += btnClearAll_Click;
            txtTask.TextChanged += txtTask_TextChanged;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;

            btnAddTask.Enabled = false;
            lblStatus.Text = "Ready.";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();

                lblStatus.Text = "Task added at " + DateTime.Now.ToShortTimeString();
            }
            else
            {
                MessageBox.Show("Please enter a task first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lblStatus.Text = "No task entered.";
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                lblStatus.Text = "No task selected to remove.";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this task?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    lblStatus.Text = "Task deletion cancelled.";
                    return;
                }
            }

            string removedTask = lstTasks.SelectedItem.ToString();
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);

            lblStatus.Text = "Removed task: " + removedTask;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count > 0)
            {
                lstTasks.Items.Clear();
                lblStatus.Text = "All tasks cleared.";
            }
            else
            {
                lblStatus.Text = "Task list is already empty.";
            }
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            btnAddTask.Enabled = !string.IsNullOrWhiteSpace(txtTask.Text);
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lblStatus.Text = "Selected task: " + lstTasks.SelectedItem.ToString();
            }
        }
    }
}
 
