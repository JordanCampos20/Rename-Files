namespace RenameFiles
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
            folderBrowserDialog = new FolderBrowserDialog();
            btnOpenFolder = new Button();
            txtFolder = new TextBox();
            groupBox1 = new GroupBox();
            btnRename = new Button();
            label2 = new Label();
            label1 = new Label();
            txtNewName = new TextBox();
            txtOldName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Location = new Point(255, 12);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(26, 23);
            btnOpenFolder.TabIndex = 0;
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(12, 12);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(237, 23);
            txtFolder.TabIndex = 1;
            txtFolder.TextChanged += txtFolder_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRename);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNewName);
            groupBox1.Controls.Add(txtOldName);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 185);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(6, 156);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(257, 23);
            btnRename.TabIndex = 10;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 9;
            label2.Text = "new name for files";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "old name";
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(6, 91);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(257, 23);
            txtNewName.TabIndex = 7;
            // 
            // txtOldName
            // 
            txtOldName.Location = new Point(6, 37);
            txtOldName.Name = "txtOldName";
            txtOldName.Size = new Size(257, 23);
            txtOldName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 238);
            Controls.Add(groupBox1);
            Controls.Add(btnOpenFolder);
            Controls.Add(txtFolder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rename files";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog;
        private Button btnOpenFolder;
        private TextBox txtFolder;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtNewName;
        private TextBox txtOldName;
        private Button btnRename;
    }
}
