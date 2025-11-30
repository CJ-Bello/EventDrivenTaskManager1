namespace EventDrivenTaskManager1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            btnRemoveSelected = new Button();
            btnClearAll = new Button();
            lstTasks = new ListBox();
            lblStatus = new Label();
            chkConfirmDelete = new CheckBox();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(95, 74);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(237, 23);
            txtTask.TabIndex = 0;
            txtTask.Text = "Enter Task";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(95, 117);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(176, 117);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(75, 23);
            btnRemoveSelected.TabIndex = 2;
            btnRemoveSelected.Text = "Remove";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(257, 117);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(95, 156);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(596, 199);
            lstTasks.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(95, 393);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(95, 371);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(106, 19);
            chkConfirmDelete.TabIndex = 6;
            chkConfirmDelete.Text = "Confirm Delete";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkConfirmDelete);
            Controls.Add(lblStatus);
            Controls.Add(lstTasks);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAddTask;
        private Button btnRemoveSelected;
        private Button btnClearAll;
        private ListBox lstTasks;
        private Label lblStatus;
        private CheckBox chkConfirmDelete;
    }
}
