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
            this.lblExecutives = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lvExecutives = new System.Windows.Forms.ListView();
            this.lvDepartments = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExecutives
            // 
            this.lblExecutives.AutoSize = true;
            this.lblExecutives.Location = new System.Drawing.Point(448, 9);
            this.lblExecutives.Name = "lblExecutives";
            this.lblExecutives.Size = new System.Drawing.Size(59, 13);
            this.lblExecutives.TabIndex = 2;
            this.lblExecutives.Text = "Executives";
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Location = new System.Drawing.Point(321, 9);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(67, 13);
            this.lblDepartments.TabIndex = 3;
            this.lblDepartments.Text = "Departments";
            // 
            // lvExecutives
            // 
            this.lvExecutives.HideSelection = false;
            this.lvExecutives.Location = new System.Drawing.Point(451, 25);
            this.lvExecutives.MultiSelect = false;
            this.lvExecutives.Name = "lvExecutives";
            this.lvExecutives.Size = new System.Drawing.Size(121, 225);
            this.lvExecutives.TabIndex = 4;
            this.lvExecutives.UseCompatibleStateImageBehavior = false;
            this.lvExecutives.View = System.Windows.Forms.View.List;
            // 
            // lvDepartments
            // 
            this.lvDepartments.HideSelection = false;
            this.lvDepartments.Location = new System.Drawing.Point(324, 25);
            this.lvDepartments.MultiSelect = false;
            this.lvDepartments.Name = "lvDepartments";
            this.lvDepartments.Size = new System.Drawing.Size(121, 225);
            this.lvDepartments.TabIndex = 5;
            this.lvDepartments.UseCompatibleStateImageBehavior = false;
            this.lvDepartments.View = System.Windows.Forms.View.List;
            this.lvDepartments.SelectedIndexChanged += new System.EventHandler(this.lvDepartments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDepartments);
            this.Controls.Add(this.lvExecutives);
            this.Controls.Add(this.lblDepartments);
            this.Controls.Add(this.lblExecutives);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "James Clark, CS 303, Project 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExecutives;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ListView lvExecutives;
        private System.Windows.Forms.ListView lvDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

