namespace Gabanete_FirstLabExam
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
            this.btnEmployeeFullName = new System.Windows.Forms.Button();
            this.btnRegularEmployee = new System.Windows.Forms.Button();
            this.btnContractualEmployee = new System.Windows.Forms.Button();
            this.btnMySQL = new System.Windows.Forms.Button();
            this.btnManagerApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeFullName
            // 
            this.btnEmployeeFullName.Location = new System.Drawing.Point(53, 29);
            this.btnEmployeeFullName.Name = "btnEmployeeFullName";
            this.btnEmployeeFullName.Size = new System.Drawing.Size(333, 58);
            this.btnEmployeeFullName.TabIndex = 0;
            this.btnEmployeeFullName.Text = " 1. Get Employee Full Name";
            this.btnEmployeeFullName.UseVisualStyleBackColor = true;
            this.btnEmployeeFullName.Click += new System.EventHandler(this.btnEmployeeFullName_Click);
            // 
            // btnRegularEmployee
            // 
            this.btnRegularEmployee.Location = new System.Drawing.Point(53, 116);
            this.btnRegularEmployee.Name = "btnRegularEmployee";
            this.btnRegularEmployee.Size = new System.Drawing.Size(333, 58);
            this.btnRegularEmployee.TabIndex = 1;
            this.btnRegularEmployee.Text = " 2. Show Regular Employee Salary";
            this.btnRegularEmployee.UseVisualStyleBackColor = true;
            this.btnRegularEmployee.Click += new System.EventHandler(this.btnRegularEmployee_Click);
            // 
            // btnContractualEmployee
            // 
            this.btnContractualEmployee.Location = new System.Drawing.Point(53, 203);
            this.btnContractualEmployee.Name = "btnContractualEmployee";
            this.btnContractualEmployee.Size = new System.Drawing.Size(333, 58);
            this.btnContractualEmployee.TabIndex = 2;
            this.btnContractualEmployee.Text = "3. Show Contractual Employee Salary";
            this.btnContractualEmployee.UseVisualStyleBackColor = true;
            this.btnContractualEmployee.Click += new System.EventHandler(this.btnContractualEmployee_Click);
            // 
            // btnMySQL
            // 
            this.btnMySQL.Location = new System.Drawing.Point(53, 288);
            this.btnMySQL.Name = "btnMySQL";
            this.btnMySQL.Size = new System.Drawing.Size(333, 58);
            this.btnMySQL.TabIndex = 3;
            this.btnMySQL.Text = "4. Show Saving to MySQL";
            this.btnMySQL.UseVisualStyleBackColor = true;
            this.btnMySQL.Click += new System.EventHandler(this.btnMySQL_Click);
            // 
            // btnManagerApprove
            // 
            this.btnManagerApprove.Location = new System.Drawing.Point(53, 367);
            this.btnManagerApprove.Name = "btnManagerApprove";
            this.btnManagerApprove.Size = new System.Drawing.Size(333, 58);
            this.btnManagerApprove.TabIndex = 4;
            this.btnManagerApprove.Text = "5. Manager Approve Leave";
            this.btnManagerApprove.UseVisualStyleBackColor = true;
            this.btnManagerApprove.Click += new System.EventHandler(this.btnManagerApprove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnManagerApprove);
            this.Controls.Add(this.btnMySQL);
            this.Controls.Add(this.btnContractualEmployee);
            this.Controls.Add(this.btnRegularEmployee);
            this.Controls.Add(this.btnEmployeeFullName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeFullName;
        private System.Windows.Forms.Button btnRegularEmployee;
        private System.Windows.Forms.Button btnContractualEmployee;
        private System.Windows.Forms.Button btnMySQL;
        private System.Windows.Forms.Button btnManagerApprove;
    }
}

