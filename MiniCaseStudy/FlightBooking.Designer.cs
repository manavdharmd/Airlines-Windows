namespace MiniCaseStudy
{
    partial class FlightBooking
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_seats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_passenger = new System.Windows.Forms.Button();
            this.btn_finalbook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(108, 37);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter flightId";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(108, 70);
            this.txt_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(132, 22);
            this.txt_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-6, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter flightDate";
            // 
            // txt_seats
            // 
            this.txt_seats.Location = new System.Drawing.Point(108, 106);
            this.txt_seats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_seats.Name = "txt_seats";
            this.txt_seats.Size = new System.Drawing.Size(132, 22);
            this.txt_seats.TabIndex = 4;
            this.txt_seats.TextChanged += new System.EventHandler(this.txt_seats_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(108, 137);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(132, 22);
            this.txt_cost.TabIndex = 8;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(51, 206);
            this.btn_book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(100, 28);
            this.btn_book.TabIndex = 10;
            this.btn_book.Text = "Proceed";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(248, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 146);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Age";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(99, 87);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(132, 22);
            this.txt_age.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 35);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 22);
            this.txt_name.TabIndex = 13;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // btn_passenger
            // 
            this.btn_passenger.Location = new System.Drawing.Point(312, 206);
            this.btn_passenger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_passenger.Name = "btn_passenger";
            this.btn_passenger.Size = new System.Drawing.Size(100, 28);
            this.btn_passenger.TabIndex = 12;
            this.btn_passenger.Text = "Submit";
            this.btn_passenger.UseVisualStyleBackColor = true;
            this.btn_passenger.Click += new System.EventHandler(this.btn_passenger_Click);
            // 
            // btn_finalbook
            // 
            this.btn_finalbook.Location = new System.Drawing.Point(193, 390);
            this.btn_finalbook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_finalbook.Name = "btn_finalbook";
            this.btn_finalbook.Size = new System.Drawing.Size(100, 28);
            this.btn_finalbook.TabIndex = 13;
            this.btn_finalbook.Text = "Book";
            this.btn_finalbook.UseVisualStyleBackColor = true;
            this.btn_finalbook.Click += new System.EventHandler(this.btn_finalbook_Click);
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btn_finalbook);
            this.Controls.Add(this.btn_passenger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_seats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FlightBooking";
            this.Text = "FlightBooking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_seats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_passenger;
        private System.Windows.Forms.Button btn_finalbook;
    }
}