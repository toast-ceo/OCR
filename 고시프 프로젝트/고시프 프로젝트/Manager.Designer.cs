namespace 고시프_프로젝트
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.확인 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MovieTypeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "완료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Check);
            // 
            // 확인
            // 
            this.확인.Location = new System.Drawing.Point(150, 414);
            this.확인.Name = "확인";
            this.확인.Size = new System.Drawing.Size(78, 22);
            this.확인.TabIndex = 1;
            this.확인.Text = "확인";
            this.확인.UseVisualStyleBackColor = true;
            this.확인.Click += new System.EventHandler(this.Check_Informtion);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Baseball";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Baseball_Type);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Museum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Museum_Type);
            // 
            // MovieTypeButton
            // 
            this.MovieTypeButton.Location = new System.Drawing.Point(76, 39);
            this.MovieTypeButton.Name = "MovieTypeButton";
            this.MovieTypeButton.Size = new System.Drawing.Size(78, 22);
            this.MovieTypeButton.TabIndex = 4;
            this.MovieTypeButton.Text = "Movie";
            this.MovieTypeButton.UseVisualStyleBackColor = true;
            this.MovieTypeButton.Click += new System.EventHandler(this.Movie_Type);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seat : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(12, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :  ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(76, 121);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(246, 21);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextbox);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 21);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.SeatTextbox);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 21);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.NumberTextbox);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 340);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 21);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.DateTextbox);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 470);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieTypeButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.확인);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "manager";
            this.RightToLeftLayout = true;
            this.Text = "manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 확인;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MovieTypeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}