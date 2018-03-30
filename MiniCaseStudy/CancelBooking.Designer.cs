namespace MiniCaseStudy
{
    partial class CancelBooking
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_cancelall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(25, 28);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(444, 344);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btn_cancelall
            // 
            this.btn_cancelall.Location = new System.Drawing.Point(186, 412);
            this.btn_cancelall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelall.Name = "btn_cancelall";
            this.btn_cancelall.Size = new System.Drawing.Size(100, 28);
            this.btn_cancelall.TabIndex = 2;
            this.btn_cancelall.Text = "Cancel All";
            this.btn_cancelall.UseVisualStyleBackColor = true;
            this.btn_cancelall.Click += new System.EventHandler(this.btn_cancelall_Click);
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btn_cancelall);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CancelBooking";
            this.Text = "CancelBooking";
            this.Load += new System.EventHandler(this.CancelBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_cancelall;

    }
}