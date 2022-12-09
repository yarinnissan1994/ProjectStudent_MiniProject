namespace ProjectStudent.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.SearchIdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(130, 42);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 26);
            this.idTxtBox.TabIndex = 4;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(130, 71);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 26);
            this.nameTxtBox.TabIndex = 5;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(130, 100);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(100, 26);
            this.ageTxtBox.TabIndex = 6;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(130, 129);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(100, 26);
            this.addressTxtBox.TabIndex = 7;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(302, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(155, 63);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(302, 81);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(155, 63);
            this.addStudentBtn.TabIndex = 9;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // SearchIdBtn
            // 
            this.SearchIdBtn.Location = new System.Drawing.Point(302, 150);
            this.SearchIdBtn.Name = "SearchIdBtn";
            this.SearchIdBtn.Size = new System.Drawing.Size(155, 63);
            this.SearchIdBtn.TabIndex = 10;
            this.SearchIdBtn.Text = "Search Student By ID";
            this.SearchIdBtn.UseVisualStyleBackColor = true;
            this.SearchIdBtn.Click += new System.EventHandler(this.SearchIdBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 222);
            this.Controls.Add(this.SearchIdBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button SearchIdBtn;
    }
}

