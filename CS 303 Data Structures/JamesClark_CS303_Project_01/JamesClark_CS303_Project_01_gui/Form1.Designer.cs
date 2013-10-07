namespace JamesClark_CS303_Project_01_gui {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvDepartment3 = new System.Windows.Forms.ListView();
            this.lvDepartment2 = new System.Windows.Forms.ListView();
            this.lvDepartment1 = new System.Windows.Forms.ListView();
            this.btnJoinDepartment = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDepartment1 = new System.Windows.Forms.RadioButton();
            this.rbDepartment2 = new System.Windows.Forms.RadioButton();
            this.rbDepartment3 = new System.Windows.Forms.RadioButton();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn1v2 = new System.Windows.Forms.Button();
            this.btn2v1 = new System.Windows.Forms.Button();
            this.btn1Quit = new System.Windows.Forms.Button();
            this.btn2Quit = new System.Windows.Forms.Button();
            this.btn3v2 = new System.Windows.Forms.Button();
            this.btn2v3 = new System.Windows.Forms.Button();
            this.pnl1v2 = new System.Windows.Forms.Panel();
            this.pnl2v3 = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.TextBox();
            this.btn3Quit = new System.Windows.Forms.Button();
            this.pnlRadioButtons.SuspendLayout();
            this.pnl1v2.SuspendLayout();
            this.pnl2v3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDepartment3
            // 
            this.lvDepartment3.HideSelection = false;
            this.lvDepartment3.Location = new System.Drawing.Point(545, 154);
            this.lvDepartment3.MultiSelect = false;
            this.lvDepartment3.Name = "lvDepartment3";
            this.lvDepartment3.Size = new System.Drawing.Size(175, 189);
            this.lvDepartment3.TabIndex = 5;
            this.lvDepartment3.UseCompatibleStateImageBehavior = false;
            this.lvDepartment3.View = System.Windows.Forms.View.List;
            this.lvDepartment3.Click += new System.EventHandler(this.lvDepartment_Click);
            // 
            // lvDepartment2
            // 
            this.lvDepartment2.HideSelection = false;
            this.lvDepartment2.Location = new System.Drawing.Point(280, 151);
            this.lvDepartment2.MultiSelect = false;
            this.lvDepartment2.Name = "lvDepartment2";
            this.lvDepartment2.Size = new System.Drawing.Size(175, 189);
            this.lvDepartment2.TabIndex = 6;
            this.lvDepartment2.UseCompatibleStateImageBehavior = false;
            this.lvDepartment2.View = System.Windows.Forms.View.List;
            this.lvDepartment2.Click += new System.EventHandler(this.lvDepartment_Click);
            // 
            // lvDepartment1
            // 
            this.lvDepartment1.HideSelection = false;
            this.lvDepartment1.Location = new System.Drawing.Point(12, 154);
            this.lvDepartment1.MultiSelect = false;
            this.lvDepartment1.Name = "lvDepartment1";
            this.lvDepartment1.Size = new System.Drawing.Size(175, 189);
            this.lvDepartment1.TabIndex = 7;
            this.lvDepartment1.UseCompatibleStateImageBehavior = false;
            this.lvDepartment1.View = System.Windows.Forms.View.List;
            this.lvDepartment1.Click += new System.EventHandler(this.lvDepartment_Click);
            // 
            // btnJoinDepartment
            // 
            this.btnJoinDepartment.Location = new System.Drawing.Point(304, 52);
            this.btnJoinDepartment.Name = "btnJoinDepartment";
            this.btnJoinDepartment.Size = new System.Drawing.Size(121, 23);
            this.btnJoinDepartment.TabIndex = 8;
            this.btnJoinDepartment.Text = "Join Department";
            this.btnJoinDepartment.UseVisualStyleBackColor = true;
            this.btnJoinDepartment.Click += new System.EventHandler(this.btnJoinDepartment_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name: ";
            // 
            // rbDepartment1
            // 
            this.rbDepartment1.AutoSize = true;
            this.rbDepartment1.Checked = true;
            this.rbDepartment1.Location = new System.Drawing.Point(3, 3);
            this.rbDepartment1.Name = "rbDepartment1";
            this.rbDepartment1.Size = new System.Drawing.Size(89, 17);
            this.rbDepartment1.TabIndex = 15;
            this.rbDepartment1.TabStop = true;
            this.rbDepartment1.Text = "Department 1";
            this.rbDepartment1.UseVisualStyleBackColor = true;
            // 
            // rbDepartment2
            // 
            this.rbDepartment2.AutoSize = true;
            this.rbDepartment2.Location = new System.Drawing.Point(98, 3);
            this.rbDepartment2.Name = "rbDepartment2";
            this.rbDepartment2.Size = new System.Drawing.Size(89, 17);
            this.rbDepartment2.TabIndex = 16;
            this.rbDepartment2.Text = "Department 2";
            this.rbDepartment2.UseVisualStyleBackColor = true;
            // 
            // rbDepartment3
            // 
            this.rbDepartment3.AutoSize = true;
            this.rbDepartment3.Location = new System.Drawing.Point(193, 3);
            this.rbDepartment3.Name = "rbDepartment3";
            this.rbDepartment3.Size = new System.Drawing.Size(89, 17);
            this.rbDepartment3.TabIndex = 17;
            this.rbDepartment3.Text = "Department 3";
            this.rbDepartment3.UseVisualStyleBackColor = true;
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Controls.Add(this.rbDepartment3);
            this.pnlRadioButtons.Controls.Add(this.rbDepartment1);
            this.pnlRadioButtons.Controls.Add(this.rbDepartment2);
            this.pnlRadioButtons.Location = new System.Drawing.Point(15, 52);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(283, 31);
            this.pnlRadioButtons.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Department 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Department 3";
            // 
            // btn1v2
            // 
            this.btn1v2.Enabled = false;
            this.btn1v2.Location = new System.Drawing.Point(3, 3);
            this.btn1v2.Name = "btn1v2";
            this.btn1v2.Size = new System.Drawing.Size(75, 23);
            this.btn1v2.TabIndex = 23;
            this.btn1v2.Text = "Change >>";
            this.btn1v2.UseVisualStyleBackColor = true;
            this.btn1v2.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btn2v1
            // 
            this.btn2v1.Enabled = false;
            this.btn2v1.Location = new System.Drawing.Point(3, 33);
            this.btn2v1.Name = "btn2v1";
            this.btn2v1.Size = new System.Drawing.Size(75, 23);
            this.btn2v1.TabIndex = 24;
            this.btn2v1.Text = "<< Change";
            this.btn2v1.UseVisualStyleBackColor = true;
            this.btn2v1.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btn1Quit
            // 
            this.btn1Quit.Enabled = false;
            this.btn1Quit.Location = new System.Drawing.Point(12, 349);
            this.btn1Quit.Name = "btn1Quit";
            this.btn1Quit.Size = new System.Drawing.Size(75, 23);
            this.btn1Quit.TabIndex = 25;
            this.btn1Quit.Text = "Quit";
            this.btn1Quit.UseVisualStyleBackColor = true;
            this.btn1Quit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btn2Quit
            // 
            this.btn2Quit.Enabled = false;
            this.btn2Quit.Location = new System.Drawing.Point(280, 346);
            this.btn2Quit.Name = "btn2Quit";
            this.btn2Quit.Size = new System.Drawing.Size(75, 23);
            this.btn2Quit.TabIndex = 28;
            this.btn2Quit.Text = "Quit";
            this.btn2Quit.UseVisualStyleBackColor = true;
            this.btn2Quit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btn3v2
            // 
            this.btn3v2.Enabled = false;
            this.btn3v2.Location = new System.Drawing.Point(3, 3);
            this.btn3v2.Name = "btn3v2";
            this.btn3v2.Size = new System.Drawing.Size(75, 23);
            this.btn3v2.TabIndex = 27;
            this.btn3v2.Text = "<< Change";
            this.btn3v2.UseVisualStyleBackColor = true;
            this.btn3v2.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btn2v3
            // 
            this.btn2v3.Enabled = false;
            this.btn2v3.Location = new System.Drawing.Point(3, 32);
            this.btn2v3.Name = "btn2v3";
            this.btn2v3.Size = new System.Drawing.Size(75, 23);
            this.btn2v3.TabIndex = 26;
            this.btn2v3.Text = "Change >>";
            this.btn2v3.UseVisualStyleBackColor = true;
            this.btn2v3.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // pnl1v2
            // 
            this.pnl1v2.Controls.Add(this.btn1v2);
            this.pnl1v2.Controls.Add(this.btn2v1);
            this.pnl1v2.Location = new System.Drawing.Point(193, 196);
            this.pnl1v2.Name = "pnl1v2";
            this.pnl1v2.Size = new System.Drawing.Size(81, 89);
            this.pnl1v2.TabIndex = 29;
            // 
            // pnl2v3
            // 
            this.pnl2v3.Controls.Add(this.btn2v3);
            this.pnl2v3.Controls.Add(this.btn3v2);
            this.pnl2v3.Location = new System.Drawing.Point(461, 196);
            this.pnl2v3.Name = "pnl2v3";
            this.pnl2v3.Size = new System.Drawing.Size(81, 89);
            this.pnl2v3.TabIndex = 30;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.Red;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.White;
            this.txtError.Location = new System.Drawing.Point(15, 90);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(708, 20);
            this.txtError.TabIndex = 31;
            this.txtError.Visible = false;
            // 
            // btn3Quit
            // 
            this.btn3Quit.Enabled = false;
            this.btn3Quit.Location = new System.Drawing.Point(548, 346);
            this.btn3Quit.Name = "btn3Quit";
            this.btn3Quit.Size = new System.Drawing.Size(75, 23);
            this.btn3Quit.TabIndex = 32;
            this.btn3Quit.Text = "Quit";
            this.btn3Quit.UseVisualStyleBackColor = true;
            this.btn3Quit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 403);
            this.Controls.Add(this.btn3Quit);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.pnl2v3);
            this.Controls.Add(this.btn2Quit);
            this.Controls.Add(this.btn1Quit);
            this.Controls.Add(this.pnl1v2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnJoinDepartment);
            this.Controls.Add(this.lvDepartment1);
            this.Controls.Add(this.lvDepartment2);
            this.Controls.Add(this.lvDepartment3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "James Clark, CS 303, Project 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.pnl1v2.ResumeLayout(false);
            this.pnl2v3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDepartment1;
        private System.Windows.Forms.ListView lvDepartment2;
        private System.Windows.Forms.ListView lvDepartment3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Panel pnlRadioButtons;
        private System.Windows.Forms.RadioButton rbDepartment1;
        private System.Windows.Forms.RadioButton rbDepartment2;
        private System.Windows.Forms.RadioButton rbDepartment3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl1v2;
        private System.Windows.Forms.Panel pnl2v3;
        private System.Windows.Forms.Button btn1v2;
        private System.Windows.Forms.Button btn2v1;
        private System.Windows.Forms.Button btn2v3;
        private System.Windows.Forms.Button btn3v2;
        private System.Windows.Forms.Button btn1Quit;
        private System.Windows.Forms.Button btn2Quit;
        private System.Windows.Forms.Button btn3Quit;
        private System.Windows.Forms.Button btnJoinDepartment;
    }
}

