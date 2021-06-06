namespace 고시프_프로젝트
{
    partial class Information_check
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SeatTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TicketName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(235, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "티켓 정보";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(140, 104);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(224, 21);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SeatTextBox
            // 
            this.SeatTextBox.Location = new System.Drawing.Point(140, 170);
            this.SeatTextBox.Name = "SeatTextBox";
            this.SeatTextBox.Size = new System.Drawing.Size(224, 21);
            this.SeatTextBox.TabIndex = 2;
            this.SeatTextBox.TextChanged += new System.EventHandler(this.SeatTextBox_TextChanged);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(140, 243);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(224, 21);
            this.NumberTextBox.TabIndex = 3;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(140, 309);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(224, 21);
            this.DateTextBox.TabIndex = 4;
            this.DateTextBox.TextChanged += new System.EventHandler(this.DateTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14F);
            this.label5.Location = new System.Drawing.Point(30, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14F);
            this.label6.Location = new System.Drawing.Point(30, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date :";
            // 
            // TicketName
            // 
            this.TicketName.AutoSize = true;
            this.TicketName.Font = new System.Drawing.Font("굴림", 20F);
            this.TicketName.Location = new System.Drawing.Point(68, 27);
            this.TicketName.Name = "TicketName";
            this.TicketName.Size = new System.Drawing.Size(30, 27);
            this.TicketName.TabIndex = 11;
            this.TicketName.Text = "  ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Modify_Button);
            // 
            // Information_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TicketName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.SeatTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Information_check";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SeatTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TicketName;
        private System.Windows.Forms.Button button1;
    }
}