namespace Student_List_v2
{
    partial class StudentManagement
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClassChoice = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ClassChoice);
            this.flowLayoutPanel1.Controls.Add(this.ClassBox);
            this.flowLayoutPanel1.Controls.Add(this.UpdateButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ClassChoice
            // 
            this.ClassChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassChoice.Location = new System.Drawing.Point(3, 0);
            this.ClassChoice.Name = "ClassChoice";
            this.ClassChoice.Size = new System.Drawing.Size(110, 27);
            this.ClassChoice.TabIndex = 0;
            this.ClassChoice.Text = "Choose class:";
            this.ClassChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(119, 3);
            this.ClassBox.MaxDropDownItems = 30;
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(216, 21);
            this.ClassBox.TabIndex = 1;
            this.ClassBox.DropDown += new System.EventHandler(this.ClassBox_DropDown);
            // 
            // StudentView
            // 
            this.StudentView.AllowUserToAddRows = false;
            this.StudentView.AllowUserToDeleteRows = false;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentView.Location = new System.Drawing.Point(147, 136);
            this.StudentView.Name = "StudentView";
            this.StudentView.ReadOnly = true;
            this.StudentView.Size = new System.Drawing.Size(426, 215);
            this.StudentView.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(341, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(92, 21);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Show";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.StudentView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "StudentManagement";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ClassChoice;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.DataGridView StudentView;
        private System.Windows.Forms.Button UpdateButton;
    }
}

