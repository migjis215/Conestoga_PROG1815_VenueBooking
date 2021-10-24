
namespace Assignment1
{
    partial class VenueBooking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWaiting = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.txtWaiting = new System.Windows.Forms.RichTextBox();
            this.txtReservation = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnAddToWaiting = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSeat = new System.Windows.Forms.ListBox();
            this.lstRow = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment1.Properties.Resources.seatLayout1;
            this.pictureBox1.Location = new System.Drawing.Point(40, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWaiting);
            this.groupBox1.Controls.Add(this.btnReservation);
            this.groupBox1.Controls.Add(this.txtWaiting);
            this.groupBox1.Controls.Add(this.txtReservation);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(686, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 599);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservations and Waiting List";
            // 
            // btnWaiting
            // 
            this.btnWaiting.Location = new System.Drawing.Point(575, 69);
            this.btnWaiting.Name = "btnWaiting";
            this.btnWaiting.Size = new System.Drawing.Size(402, 57);
            this.btnWaiting.TabIndex = 3;
            this.btnWaiting.Text = "Show Waiting List";
            this.btnWaiting.UseVisualStyleBackColor = true;
            this.btnWaiting.Click += new System.EventHandler(this.btnWaiting_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(64, 69);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(402, 57);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Show All Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // txtWaiting
            // 
            this.txtWaiting.Location = new System.Drawing.Point(553, 141);
            this.txtWaiting.Name = "txtWaiting";
            this.txtWaiting.ReadOnly = true;
            this.txtWaiting.Size = new System.Drawing.Size(448, 421);
            this.txtWaiting.TabIndex = 1;
            this.txtWaiting.Text = "";
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(41, 141);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.ReadOnly = true;
            this.txtReservation.Size = new System.Drawing.Size(448, 421);
            this.txtReservation.TabIndex = 0;
            this.txtReservation.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDebug);
            this.groupBox2.Controls.Add(this.btnAddToWaiting);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstSeat);
            this.groupBox2.Controls.Add(this.lstRow);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 663);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1689, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings and Cancellations";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 14F);
            this.txtCustomerName.Location = new System.Drawing.Point(847, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(755, 50);
            this.txtCustomerName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer Name";
            // 
            // btnDebug
            // 
            this.btnDebug.Font = new System.Drawing.Font("Arial", 14F);
            this.btnDebug.ForeColor = System.Drawing.Color.Red;
            this.btnDebug.Location = new System.Drawing.Point(571, 294);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(679, 85);
            this.btnDebug.TabIndex = 8;
            this.btnDebug.Text = "Debug - Fill All Seats";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnAddToWaiting
            // 
            this.btnAddToWaiting.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAddToWaiting.Location = new System.Drawing.Point(1276, 184);
            this.btnAddToWaiting.Name = "btnAddToWaiting";
            this.btnAddToWaiting.Size = new System.Drawing.Size(326, 85);
            this.btnAddToWaiting.TabIndex = 7;
            this.btnAddToWaiting.Text = "Add to Waiting";
            this.btnAddToWaiting.UseVisualStyleBackColor = true;
            this.btnAddToWaiting.Click += new System.EventHandler(this.btnAddToWaiting_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCancel.Location = new System.Drawing.Point(924, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(326, 85);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1276, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(326, 85);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Arial", 14F);
            this.btnBook.Location = new System.Drawing.Point(571, 184);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(326, 85);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Row";
            // 
            // lstSeat
            // 
            this.lstSeat.FormattingEnabled = true;
            this.lstSeat.ItemHeight = 36;
            this.lstSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lstSeat.Location = new System.Drawing.Point(301, 123);
            this.lstSeat.Name = "lstSeat";
            this.lstSeat.Size = new System.Drawing.Size(155, 256);
            this.lstSeat.TabIndex = 1;
            // 
            // lstRow
            // 
            this.lstRow.FormattingEnabled = true;
            this.lstRow.ItemHeight = 36;
            this.lstRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.lstRow.Location = new System.Drawing.Point(82, 123);
            this.lstRow.Name = "lstRow";
            this.lstRow.Size = new System.Drawing.Size(155, 256);
            this.lstRow.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(40, 1120);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(42, 36);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "...";
            // 
            // VenueBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1329);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VenueBooking";
            this.Text = "Venue Booking";
            this.Load += new System.EventHandler(this.VenueBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWaiting;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.RichTextBox txtWaiting;
        private System.Windows.Forms.RichTextBox txtReservation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstRow;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnAddToWaiting;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSeat;
        private System.Windows.Forms.Label lblMessage;
    }
}

