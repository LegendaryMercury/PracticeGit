namespace ContainerManagerMkII
{
    partial class Form1
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
            this.ContainerListBox1 = new System.Windows.Forms.ListBox();
            this.AddContainerButton = new System.Windows.Forms.Button();
            this.ContainerNumberTxtBox = new System.Windows.Forms.TextBox();
            this.ContainerNumbLable1 = new System.Windows.Forms.Label();
            this.RemoveContainerButton = new System.Windows.Forms.Button();
            this.ContainerWeightTxtBox = new System.Windows.Forms.TextBox();
            this.ContainerWeightLable1 = new System.Windows.Forms.Label();
            this.ContainerCapacityTxtBox = new System.Windows.Forms.TextBox();
            this.ContainerCapLabel1 = new System.Windows.Forms.Label();
            this.TwentyFCheckBox = new System.Windows.Forms.CheckBox();
            this.FourtyFCheckBox = new System.Windows.Forms.CheckBox();
            this.EditContainerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContainerListBox1
            // 
            this.ContainerListBox1.FormattingEnabled = true;
            this.ContainerListBox1.Location = new System.Drawing.Point(12, 259);
            this.ContainerListBox1.Name = "ContainerListBox1";
            this.ContainerListBox1.Size = new System.Drawing.Size(776, 147);
            this.ContainerListBox1.TabIndex = 1;
            // 
            // AddContainerButton
            // 
            this.AddContainerButton.Location = new System.Drawing.Point(209, 25);
            this.AddContainerButton.Name = "AddContainerButton";
            this.AddContainerButton.Size = new System.Drawing.Size(150, 25);
            this.AddContainerButton.TabIndex = 2;
            this.AddContainerButton.Text = "Add Container";
            this.AddContainerButton.UseVisualStyleBackColor = true;
            this.AddContainerButton.Click += new System.EventHandler(this.AddContainerButton_Click);
            // 
            // ContainerNumberTxtbox
            // 
            this.ContainerNumberTxtBox.Location = new System.Drawing.Point(12, 25);
            this.ContainerNumberTxtBox.Name = "ContainerNumberTxtbox";
            this.ContainerNumberTxtBox.Size = new System.Drawing.Size(191, 20);
            this.ContainerNumberTxtBox.TabIndex = 3;
            // 
            // ContainerNumbLable1
            // 
            this.ContainerNumbLable1.AutoSize = true;
            this.ContainerNumbLable1.Location = new System.Drawing.Point(12, 9);
            this.ContainerNumbLable1.Name = "ContainerNumbLable1";
            this.ContainerNumbLable1.Size = new System.Drawing.Size(92, 13);
            this.ContainerNumbLable1.TabIndex = 4;
            this.ContainerNumbLable1.Text = "Container Number";
            // 
            // RemoveContainerButton
            // 
            this.RemoveContainerButton.Location = new System.Drawing.Point(209, 56);
            this.RemoveContainerButton.Name = "RemoveContainerButton";
            this.RemoveContainerButton.Size = new System.Drawing.Size(150, 25);
            this.RemoveContainerButton.TabIndex = 5;
            this.RemoveContainerButton.Text = "Remove Container";
            this.RemoveContainerButton.UseVisualStyleBackColor = true;
            this.RemoveContainerButton.Click += new System.EventHandler(this.RemoveContainerButton_Click);
            // 
            // ContainerWeightTxtBox
            // 
            this.ContainerWeightTxtBox.Location = new System.Drawing.Point(12, 64);
            this.ContainerWeightTxtBox.Name = "ContainerWeightTxtBox";
            this.ContainerWeightTxtBox.Size = new System.Drawing.Size(191, 20);
            this.ContainerWeightTxtBox.TabIndex = 6;
            // 
            // ContainerWeightLable1
            // 
            this.ContainerWeightLable1.AutoSize = true;
            this.ContainerWeightLable1.Location = new System.Drawing.Point(12, 48);
            this.ContainerWeightLable1.Name = "ContainerWeightLable1";
            this.ContainerWeightLable1.Size = new System.Drawing.Size(110, 13);
            this.ContainerWeightLable1.TabIndex = 7;
            this.ContainerWeightLable1.Text = "Container Weight (kg)";
            // 
            // ContainerCapacityTxtBox
            // 
            this.ContainerCapacityTxtBox.Location = new System.Drawing.Point(12, 103);
            this.ContainerCapacityTxtBox.Name = "ContainerCapacityTxtBox";
            this.ContainerCapacityTxtBox.Size = new System.Drawing.Size(191, 20);
            this.ContainerCapacityTxtBox.TabIndex = 8;
            // 
            // ContainerCapLabel1
            // 
            this.ContainerCapLabel1.AutoSize = true;
            this.ContainerCapLabel1.Location = new System.Drawing.Point(9, 87);
            this.ContainerCapLabel1.Name = "ContainerCapLabel1";
            this.ContainerCapLabel1.Size = new System.Drawing.Size(118, 13);
            this.ContainerCapLabel1.TabIndex = 9;
            this.ContainerCapLabel1.Text = "Container Capacity (KL)";
            // 
            // TwentyFCheckBox
            // 
            this.TwentyFCheckBox.AutoSize = true;
            this.TwentyFCheckBox.Location = new System.Drawing.Point(12, 142);
            this.TwentyFCheckBox.Name = "TwentyFCheckBox";
            this.TwentyFCheckBox.Size = new System.Drawing.Size(85, 17);
            this.TwentyFCheckBox.TabIndex = 10;
            this.TwentyFCheckBox.Text = "Twenty Foot";
            this.TwentyFCheckBox.UseVisualStyleBackColor = true;
            // 
            // FourtyFCheckBox
            // 
            this.FourtyFCheckBox.AutoSize = true;
            this.FourtyFCheckBox.Location = new System.Drawing.Point(103, 142);
            this.FourtyFCheckBox.Name = "FourtyFCheckBox";
            this.FourtyFCheckBox.Size = new System.Drawing.Size(79, 17);
            this.FourtyFCheckBox.TabIndex = 11;
            this.FourtyFCheckBox.Text = "Fourty Foot";
            this.FourtyFCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditContainerButton
            // 
            this.EditContainerButton.Location = new System.Drawing.Point(209, 87);
            this.EditContainerButton.Name = "EditContainerButton";
            this.EditContainerButton.Size = new System.Drawing.Size(150, 25);
            this.EditContainerButton.TabIndex = 12;
            this.EditContainerButton.Text = "Edit Container";
            this.EditContainerButton.UseVisualStyleBackColor = true;
            this.EditContainerButton.Click += new System.EventHandler(this.EditContainerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(209, 118);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 25);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EditContainerButton);
            this.Controls.Add(this.FourtyFCheckBox);
            this.Controls.Add(this.TwentyFCheckBox);
            this.Controls.Add(this.ContainerCapLabel1);
            this.Controls.Add(this.ContainerCapacityTxtBox);
            this.Controls.Add(this.ContainerWeightLable1);
            this.Controls.Add(this.ContainerWeightTxtBox);
            this.Controls.Add(this.RemoveContainerButton);
            this.Controls.Add(this.ContainerNumbLable1);
            this.Controls.Add(this.ContainerNumberTxtBox);
            this.Controls.Add(this.AddContainerButton);
            this.Controls.Add(this.ContainerListBox1);
            this.Name = "Form1";
            this.Text = "Container Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ContainerListBox1;
        private System.Windows.Forms.Button AddContainerButton;
        private System.Windows.Forms.TextBox ContainerNumberTxtBox;
        private System.Windows.Forms.Label ContainerNumbLable1;
        private System.Windows.Forms.Button RemoveContainerButton;
        private System.Windows.Forms.TextBox ContainerWeightTxtBox;
        private System.Windows.Forms.Label ContainerWeightLable1;
        private System.Windows.Forms.TextBox ContainerCapacityTxtBox;
        private System.Windows.Forms.Label ContainerCapLabel1;
        private System.Windows.Forms.CheckBox TwentyFCheckBox;
        private System.Windows.Forms.CheckBox FourtyFCheckBox;
        private System.Windows.Forms.Button EditContainerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

