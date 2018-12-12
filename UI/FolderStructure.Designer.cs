namespace UI
{
    partial class FolderCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderTitle = new System.Windows.Forms.Label();
            this.HrLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectDate = new System.Windows.Forms.TextBox();
            this.projectName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.todayDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.projectPath = new System.Windows.Forms.TextBox();
            this.browseFilePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderTitle
            // 
            this.folderTitle.AutoSize = true;
            this.folderTitle.Font = new System.Drawing.Font("Helvetica BQ", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTitle.Location = new System.Drawing.Point(148, 9);
            this.folderTitle.Name = "folderTitle";
            this.folderTitle.Size = new System.Drawing.Size(227, 35);
            this.folderTitle.TabIndex = 0;
            this.folderTitle.Text = "FolderCreator";
            // 
            // HrLine
            // 
            this.HrLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HrLine.Location = new System.Drawing.Point(12, 44);
            this.HrLine.Name = "HrLine";
            this.HrLine.Size = new System.Drawing.Size(526, 2);
            this.HrLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Date";
            // 
            // projectDate
            // 
            this.projectDate.Location = new System.Drawing.Point(72, 100);
            this.projectDate.Name = "projectDate";
            this.projectDate.Size = new System.Drawing.Size(372, 20);
            this.projectDate.TabIndex = 3;
            this.projectDate.Text = "Enter project date or click today                          format MM.dd.yy";
            this.projectDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.projectDate_MouseClick);
            this.projectDate.Validating += new System.ComponentModel.CancelEventHandler(this.projectDate_Validating);
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(72, 142);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(372, 20);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "Enter project name";
            this.projectName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.projectName_MouseClick);
            this.projectName.Validating += new System.ComponentModel.CancelEventHandler(this.projectName_Validating);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(159, 211);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Create";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // todayDate
            // 
            this.todayDate.Location = new System.Drawing.Point(240, 211);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(75, 23);
            this.todayDate.TabIndex = 4;
            this.todayDate.Text = "Today";
            this.todayDate.UseVisualStyleBackColor = true;
            this.todayDate.Click += new System.EventHandler(this.todayDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Path";
            // 
            // projectPath
            // 
            this.projectPath.Location = new System.Drawing.Point(72, 185);
            this.projectPath.Name = "projectPath";
            this.projectPath.Size = new System.Drawing.Size(291, 20);
            this.projectPath.TabIndex = 3;
            this.projectPath.Text = "Enter project path";
            this.projectPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.projectPath_MouseClick);
            // 
            // browseFilePath
            // 
            this.browseFilePath.Location = new System.Drawing.Point(369, 182);
            this.browseFilePath.Name = "browseFilePath";
            this.browseFilePath.Size = new System.Drawing.Size(75, 23);
            this.browseFilePath.TabIndex = 4;
            this.browseFilePath.Text = "Browse";
            this.browseFilePath.UseVisualStyleBackColor = true;
            this.browseFilePath.Click += new System.EventHandler(this.browseFilePath_Click);
            // 
            // FolderCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 318);
            this.Controls.Add(this.browseFilePath);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.projectPath);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HrLine);
            this.Controls.Add(this.folderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FolderCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderTitle;
        private System.Windows.Forms.Label HrLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectDate;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button todayDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectPath;
        private System.Windows.Forms.Button browseFilePath;
    }
}

