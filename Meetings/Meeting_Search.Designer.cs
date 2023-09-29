namespace Meetings
{
    partial class Meeting_Search
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
            this.meeting_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.meeting_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meeting_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث عن اجتماع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم الاجتماع";
            // 
            // meeting_number
            // 
            this.meeting_number.Location = new System.Drawing.Point(117, 84);
            this.meeting_number.Name = "meeting_number";
            this.meeting_number.Size = new System.Drawing.Size(100, 20);
            this.meeting_number.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meeting_title
            // 
            this.meeting_title.Location = new System.Drawing.Point(117, 126);
            this.meeting_title.Name = "meeting_title";
            this.meeting_title.Size = new System.Drawing.Size(100, 20);
            this.meeting_title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "عنوان الاجتماع";
            // 
            // meeting_date
            // 
            this.meeting_date.Location = new System.Drawing.Point(117, 169);
            this.meeting_date.Name = "meeting_date";
            this.meeting_date.Size = new System.Drawing.Size(100, 20);
            this.meeting_date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاريخ الاجتماع";
            // 
            // Meeting_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 325);
            this.Controls.Add(this.meeting_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meeting_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meeting_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meeting_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting_Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meeting_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox meeting_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meeting_date;
        private System.Windows.Forms.Label label4;
    }
}