namespace Faculty_GUI
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
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstFaculty = new System.Windows.Forms.ListBox();
            this.picFaculty = new System.Windows.Forms.PictureBox();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbFeedback = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNewSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(694, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(693, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter feedback faculty score:";
            // 
            // lstFaculty
            // 
            this.lstFaculty.FormattingEnabled = true;
            this.lstFaculty.ItemHeight = 20;
            this.lstFaculty.Location = new System.Drawing.Point(180, 22);
            this.lstFaculty.Name = "lstFaculty";
            this.lstFaculty.Size = new System.Drawing.Size(200, 64);
            this.lstFaculty.TabIndex = 5;
            this.lstFaculty.UseTabStops = false;
            this.lstFaculty.Click += new System.EventHandler(this.lstFaculty_SelectedValueChanged);
            this.lstFaculty.SelectedIndexChanged += new System.EventHandler(this.lstFaculty_SelectedValueChanged);
            // 
            // picFaculty
            // 
            this.picFaculty.Location = new System.Drawing.Point(180, 115);
            this.picFaculty.Name = "picFaculty";
            this.picFaculty.Size = new System.Drawing.Size(430, 339);
            this.picFaculty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFaculty.TabIndex = 6;
            this.picFaculty.TabStop = false;
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(696, 420);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(184, 59);
            this.btnCalculateSalary.TabIndex = 7;
            this.btnCalculateSalary.Text = "Calculate Salary";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Start Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(692, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Salary after feedback:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(693, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Life:";
            // 
            // cmbFeedback
            // 
            this.cmbFeedback.FormattingEnabled = true;
            this.cmbFeedback.Location = new System.Drawing.Point(913, 335);
            this.cmbFeedback.Name = "cmbFeedback";
            this.cmbFeedback.Size = new System.Drawing.Size(121, 28);
            this.cmbFeedback.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(791, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 17;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(797, 154);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 20);
            this.lblDepartment.TabIndex = 19;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(738, 204);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(0, 20);
            this.lblLife.TabIndex = 20;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(785, 244);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(0, 20);
            this.lblStart.TabIndex = 21;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(779, 287);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 20);
            this.lblEnd.TabIndex = 22;
            // 
            // lblNewSalary
            // 
            this.lblNewSalary.AutoSize = true;
            this.lblNewSalary.Location = new System.Drawing.Point(899, 382);
            this.lblNewSalary.Name = "lblNewSalary";
            this.lblNewSalary.Size = new System.Drawing.Size(0, 20);
            this.lblNewSalary.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 582);
            this.Controls.Add(this.lblNewSalary);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbFeedback);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCalculateSalary);
            this.Controls.Add(this.picFaculty);
            this.Controls.Add(this.lstFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Faculty Salary Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstFaculty;
        private System.Windows.Forms.PictureBox picFaculty;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbFeedback;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblNewSalary;
    }
}

