
namespace ADOSTUDENT
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddStu = new System.Windows.Forms.Button();
            this.EditStu = new System.Windows.Forms.Button();
            this.DeleteStu = new System.Windows.Forms.Button();
            this.StuCode = new System.Windows.Forms.Label();
            this.StuName = new System.Windows.Forms.Label();
            this.StuDept = new System.Windows.Forms.Label();
            this.StuDOB = new System.Windows.Forms.Label();
            this.StuAddress = new System.Windows.Forms.Label();
            this.txtStuCode = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuDept = new System.Windows.Forms.TextBox();
            this.txtStuAdd = new System.Windows.Forms.TextBox();
            this.dtpStuDOB = new System.Windows.Forms.DateTimePicker();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(461, 312);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(112, 34);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddStu
            // 
            this.AddStu.Location = new System.Drawing.Point(26, 404);
            this.AddStu.Name = "AddStu";
            this.AddStu.Size = new System.Drawing.Size(206, 34);
            this.AddStu.TabIndex = 1;
            this.AddStu.Text = "Add Student";
            this.AddStu.UseVisualStyleBackColor = true;
            this.AddStu.Click += new System.EventHandler(this.AddStu_Click);
            // 
            // EditStu
            // 
            this.EditStu.Location = new System.Drawing.Point(302, 404);
            this.EditStu.Name = "EditStu";
            this.EditStu.Size = new System.Drawing.Size(206, 34);
            this.EditStu.TabIndex = 2;
            this.EditStu.Text = "Edit Student";
            this.EditStu.UseVisualStyleBackColor = true;
            this.EditStu.Click += new System.EventHandler(this.EditStu_Click);
            // 
            // DeleteStu
            // 
            this.DeleteStu.Location = new System.Drawing.Point(582, 404);
            this.DeleteStu.Name = "DeleteStu";
            this.DeleteStu.Size = new System.Drawing.Size(206, 34);
            this.DeleteStu.TabIndex = 3;
            this.DeleteStu.Text = "Delete Student";
            this.DeleteStu.UseVisualStyleBackColor = true;
            this.DeleteStu.Click += new System.EventHandler(this.DeleteStu_Click);
            // 
            // StuCode
            // 
            this.StuCode.AutoSize = true;
            this.StuCode.Location = new System.Drawing.Point(155, 35);
            this.StuCode.Name = "StuCode";
            this.StuCode.Size = new System.Drawing.Size(120, 25);
            this.StuCode.TabIndex = 4;
            this.StuCode.Text = "Student Code";
            // 
            // StuName
            // 
            this.StuName.AutoSize = true;
            this.StuName.Location = new System.Drawing.Point(155, 87);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(125, 25);
            this.StuName.TabIndex = 5;
            this.StuName.Text = "Student Name";
            // 
            // StuDept
            // 
            this.StuDept.AutoSize = true;
            this.StuDept.Location = new System.Drawing.Point(155, 138);
            this.StuDept.Name = "StuDept";
            this.StuDept.Size = new System.Drawing.Size(173, 25);
            this.StuDept.TabIndex = 6;
            this.StuDept.Text = "Student Department";
            // 
            // StuDOB
            // 
            this.StuDOB.AutoSize = true;
            this.StuDOB.Location = new System.Drawing.Point(155, 188);
            this.StuDOB.Name = "StuDOB";
            this.StuDOB.Size = new System.Drawing.Size(57, 25);
            this.StuDOB.TabIndex = 7;
            this.StuDOB.Text = "D.O.B";
            // 
            // StuAddress
            // 
            this.StuAddress.AutoSize = true;
            this.StuAddress.Location = new System.Drawing.Point(155, 239);
            this.StuAddress.Name = "StuAddress";
            this.StuAddress.Size = new System.Drawing.Size(77, 25);
            this.StuAddress.TabIndex = 8;
            this.StuAddress.Text = "Address";
            // 
            // txtStuCode
            // 
            this.txtStuCode.Location = new System.Drawing.Point(459, 32);
            this.txtStuCode.Name = "txtStuCode";
            this.txtStuCode.Size = new System.Drawing.Size(218, 31);
            this.txtStuCode.TabIndex = 9;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(459, 84);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(218, 31);
            this.txtStuName.TabIndex = 10;
            // 
            // txtStuDept
            // 
            this.txtStuDept.Location = new System.Drawing.Point(459, 138);
            this.txtStuDept.Name = "txtStuDept";
            this.txtStuDept.Size = new System.Drawing.Size(218, 31);
            this.txtStuDept.TabIndex = 11;
            // 
            // txtStuAdd
            // 
            this.txtStuAdd.Location = new System.Drawing.Point(459, 236);
            this.txtStuAdd.Name = "txtStuAdd";
            this.txtStuAdd.Size = new System.Drawing.Size(218, 31);
            this.txtStuAdd.TabIndex = 12;
            // 
            // dtpStuDOB
            // 
            this.dtpStuDOB.Location = new System.Drawing.Point(459, 183);
            this.dtpStuDOB.Name = "dtpStuDOB";
            this.dtpStuDOB.Size = new System.Drawing.Size(218, 31);
            this.dtpStuDOB.TabIndex = 13;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(155, 314);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(218, 31);
            this.SearchBox.TabIndex = 14;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(676, 314);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(112, 34);
            this.ResetBtn.TabIndex = 15;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.dtpStuDOB);
            this.Controls.Add(this.txtStuAdd);
            this.Controls.Add(this.txtStuDept);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuCode);
            this.Controls.Add(this.StuAddress);
            this.Controls.Add(this.StuDOB);
            this.Controls.Add(this.StuDept);
            this.Controls.Add(this.StuName);
            this.Controls.Add(this.StuCode);
            this.Controls.Add(this.DeleteStu);
            this.Controls.Add(this.EditStu);
            this.Controls.Add(this.AddStu);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddStu;
        private System.Windows.Forms.Button EditStu;
        private System.Windows.Forms.Button DeleteStu;
        private System.Windows.Forms.Label StuCode;
        private System.Windows.Forms.Label StuName;
        private System.Windows.Forms.Label StuDept;
        private System.Windows.Forms.Label StuDOB;
        private System.Windows.Forms.Label StuAddress;
        private System.Windows.Forms.TextBox txtStuCode;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuDept;
        private System.Windows.Forms.TextBox txtStuAdd;
        private System.Windows.Forms.DateTimePicker dtpStuDOB;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ResetBtn;
    }
}

