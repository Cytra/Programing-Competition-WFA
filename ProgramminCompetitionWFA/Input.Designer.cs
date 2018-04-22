namespace ProgramminCompetitionWFA
{
    partial class Input
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
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.TaskDropDownList = new System.Windows.Forms.ComboBox();
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SolutionTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NicknameLabel.Location = new System.Drawing.Point(32, 107);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(96, 25);
            this.NicknameLabel.TabIndex = 0;
            this.NicknameLabel.Text = "Nickname";
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Location = new System.Drawing.Point(171, 112);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NicknameTextBox.TabIndex = 2;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputLabel.Location = new System.Drawing.Point(28, 27);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(84, 40);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            this.InputLabel.Click += new System.EventHandler(this.InputLabel_Click);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TaskLabel.Location = new System.Drawing.Point(32, 147);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(49, 25);
            this.TaskLabel.TabIndex = 4;
            this.TaskLabel.Text = "Task";
            // 
            // TaskDropDownList
            // 
            this.TaskDropDownList.FormattingEnabled = true;
            this.TaskDropDownList.Location = new System.Drawing.Point(171, 150);
            this.TaskDropDownList.Name = "TaskDropDownList";
            this.TaskDropDownList.Size = new System.Drawing.Size(121, 21);
            this.TaskDropDownList.TabIndex = 5;
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SolutionLabel.Location = new System.Drawing.Point(32, 189);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(82, 25);
            this.SolutionLabel.TabIndex = 6;
            this.SolutionLabel.Text = "Solution";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SubmitButton.Location = new System.Drawing.Point(220, 328);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(172, 48);
            this.SubmitButton.TabIndex = 26;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SolutionTextBox
            // 
            this.SolutionTextBox.Location = new System.Drawing.Point(171, 189);
            this.SolutionTextBox.Name = "SolutionTextBox";
            this.SolutionTextBox.Size = new System.Drawing.Size(275, 113);
            this.SolutionTextBox.TabIndex = 27;
            this.SolutionTextBox.Text = "";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(505, 107);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(315, 263);
            this.OutputTextBox.TabIndex = 28;
            this.OutputTextBox.Text = "";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.OutputLabel.Location = new System.Drawing.Point(500, 55);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(71, 25);
            this.OutputLabel.TabIndex = 29;
            this.OutputLabel.Text = "Output";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 402);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.SolutionTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SolutionLabel);
            this.Controls.Add(this.TaskDropDownList);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.NicknameLabel);
            this.Name = "Input";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.ComboBox TaskDropDownList;
        private System.Windows.Forms.Label SolutionLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.RichTextBox SolutionTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label OutputLabel;
    }
}