/*
 * Program ID: Assignment1
 * 
 * Purpose: To create a booking system
 * 
 * Revision History: 
 *      created Feb 2021 by J.Kim
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class VenueBooking : Form
    {
        string[,] reservations = new string[5, 6];
        string[] waiting = new string[10];
        bool bookingAvailable;
        bool waitingAvailable;

        public VenueBooking()
        {
            InitializeComponent();
        }

        // Remove text in message label when the program runs
        private void VenueBooking_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        // Unselect user selections in the row list box and the seat list box
        public void InitializeUserSelection(ListBox row, ListBox seat)
        {
            row.ClearSelected();
            seat.ClearSelected();
        }

        // Unselect user selections in the row list box and the seat list box
        // Delete text in the text box that user enter the customer name
        public void InitializeUserSelection(ListBox row, ListBox seat, TextBox customerName)
        {
            row.ClearSelected();
            seat.ClearSelected();
            customerName.Text = "";
        }

        // Check that there are elements without values in a two-dimensional array
        public bool CheckNullContained(string[,] stringArray)
        {
            bool nullContained = false;

            foreach (string item in stringArray)
            {
                if (item == null)
                {
                    nullContained = true;
                }
            }

            return nullContained;
        }

        // Check that there are elements without values in a one-dimensional array
        public bool CheckNullContained(string[] stringArray)
        {
            bool nullContained = false;

            foreach (string item in stringArray)
            {
                if (item == null)
                {
                    nullContained = true;
                }
            }

            return nullContained;
        }

        // Show rows and numbers of all seats, one per line
        // For reserved seats, show customer name together 
        private void btnReservation_Click(object sender, EventArgs e)
        {
            txtReservation.Text = "";

            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                string row = lstRow.Items[i].ToString();
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    string seat = lstSeat.Items[j].ToString();
                    txtReservation.Text += row + seat + " - " + reservations[i, j] + "\n";
                }
            }
        }

        // Show names of waiting customers one per line
        private void btnWaiting_Click(object sender, EventArgs e)
        {
            txtWaiting.Text = "";

            for (int i = 0; i < waiting.Length; i++)
            {
                txtWaiting.Text += waiting[i] + "\n";
            }
        }

        // Show message on message label when all seats are reserved
        // Show message if either row, seat or customer name is not selected or entered
        // Show message if the seat selected by user is already reserved
        // Show message if the reservation is successful

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            int rowIndex = lstRow.SelectedIndex;
            int seatIndex = lstSeat.SelectedIndex;
            string customerName = txtCustomerName.Text.Trim();

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;
            bookingAvailable = CheckNullContained(reservations);
            
            if (!bookingAvailable)
            {
                lblMessage.Text += "There are currently no seats available for reservation.\n" +
                                   "Click the 'Add to Waiting' button to leave your name on the waiting list.";
                InitializeUserSelection(lstRow, lstSeat);
                btnReservation_Click(sender, e);
                btnWaiting_Click(sender, e);

                return;
            }

            if (rowIndex == -1)
            {
                lblMessage.Text += "Please select a row of seats from the 'row' list.\n";
            }
            if (seatIndex == -1)
            {
                lblMessage.Text += "Please select a seat number from the 'seat' list.\n";
            }
            if (lblMessage.Text == "" && reservations[rowIndex, seatIndex] != null)
            {
                string seatSelected = lstRow.Items[rowIndex].ToString() + lstSeat.Items[seatIndex].ToString();

                lblMessage.Text += "The " + seatSelected + " seat is already reserved.\n" +
                                   "Please check the reservation list and choose a differnt seat.";
                InitializeUserSelection(lstRow, lstSeat);
                btnReservation_Click(sender, e);

                return;
            }

            if (string.IsNullOrEmpty(customerName))
            {
                lblMessage.Text += "Please enter your name in the 'Customer Name' field.";
                txtCustomerName.Text = "";
            }

            if (lblMessage.Text != "")
            {
                return;
            }
            else
            {
                reservations[rowIndex, seatIndex] = customerName;
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text += "Your reservation has been successful.";
            }

            InitializeUserSelection(lstRow, lstSeat, txtCustomerName);
            btnReservation_Click(sender, e);
        }

        // Show message if there are seats available for reservation 
        // Show message if user can no longer add a name to the waiting list
        // Show message if the customer name is not entered
        // Show message if the name is successfully stored in the waiting list
        private void btnAddToWaiting_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;
            bookingAvailable = CheckNullContained(reservations);
            waitingAvailable = CheckNullContained(waiting);

            if (bookingAvailable)
            {
                lblMessage.Text += "There are currently seats available for reservation.\n" +
                                   "Please check the seats that are not booked and click the 'Book' button to select a seat.\n\n";

                for (int i = 0; i < reservations.GetLength(0); i++)
                {
                    string row = lstRow.Items[i].ToString();
                    for (int j = 0; j < reservations.GetLength(1); j++)
                    {
                        string seat = lstSeat.Items[j].ToString();
                        if (reservations[i, j] == null)
                        {
                            lblMessage.Text += row + seat + ", ";
                        }
                    }
                }

                lblMessage.Text = lblMessage.Text.Substring(0, lblMessage.Text.Length - 2);
            }
            else if (!waitingAvailable)
            {
                lblMessage.Text += "Sorry, the waiting list is currently full.";
            }
            else if (string.IsNullOrEmpty(customerName))
            {
                lblMessage.Text += "Please enter your name in the 'Customer Name' field.";
            }
            else
            {
                for (int i = 0; i < waiting.Length; i++)
                {
                    if (waiting[i] == null)
                    {
                        waiting[i] = customerName;

                        lblMessage.ForeColor = Color.Blue;
                        lblMessage.Text += "Your name has been successfully saved on the waiting list.";

                        break;
                    }
                }
            }

            InitializeUserSelection(lstRow, lstSeat, txtCustomerName);
            btnReservation_Click(sender, e);
            btnWaiting_Click(sender, e);
        }

        // Show message if either row or seat is not selected
        // Show message if the selected seat is not reserved
        // Show message box to confirm seat reservation cancellation
        // After cancellation, If the waiting list is not empty, delete the first name from the list and reserve the cancelled seat with that name
        // Show message if the reservation is cancelled
        private void btnCancel_Click(object sender, EventArgs e)
        {
            int rowIndex = lstRow.SelectedIndex;
            int seatIndex = lstSeat.SelectedIndex;

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;

            if (rowIndex == -1)
            {
                lblMessage.Text += "Please select a row of seats from the 'row' list.\n";
            }
            if (seatIndex == -1)
            {
                lblMessage.Text += "Please select a seat number from the 'seat' list.";
            }

            if (lblMessage.Text != "")
            {
                txtCustomerName.Text = "";
                return;
            }

            string seatSelected = lstRow.Items[rowIndex].ToString() + lstSeat.Items[seatIndex].ToString();
           
            if (reservations[rowIndex, seatIndex] == null)
            {
                lblMessage.Text += "The " + seatSelected + " seat is not booked yet.";
            }
            else
            {
                string messageBoxText = "Customer Name:\t" + reservations[rowIndex, seatIndex] + "\n" +
                                        "Reserved Seat:\t" + seatSelected + "\n\n" +
                                        "Are you sure you want to cancel the reservation for this seat?";
                string reply = MessageBox.Show(messageBoxText, "Reservation Cancellation", 
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                
                if (reply == "Yes")
                {
                    lblMessage.ForeColor = Color.Blue;

                    if (waiting[0] != null)
                    {
                        reservations[rowIndex, seatIndex] = waiting[0];

                        for (int i = 0; i < waiting.Length; i++)
                        {
                            if (i < (waiting.Length - 1))
                            {
                                waiting[i] = waiting[i + 1];
                            }
                            else
                            {
                                waiting[i] = null;
                            }
                        }
                        
                        lblMessage.Text += "The reservation for " + seatSelected + " seat has been canceled.\n" +
                                           "Cancelled seat has been booked under the name of " + reservations[rowIndex, seatIndex] + ".";
                    }
                    else
                    {
                        reservations[rowIndex, seatIndex] = null;
                        lblMessage.Text += "The reservation for " + seatSelected + " seat has been canceled.";
                    }
                }
            }

            InitializeUserSelection(lstRow, lstSeat, txtCustomerName);
            btnReservation_Click(sender, e);
            btnWaiting_Click(sender, e);
        }

        // Change the reserved name of all seats to 'TEST'
        // Clear the waiting list
        private void btnDebug_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Blue;

            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    reservations[i, j] = "TEST";
                }
            }

            for (int i = 0; i < waiting.Length; i++)
            {
                waiting[i] = null;
            }

            InitializeUserSelection(lstRow, lstSeat, txtCustomerName);
            btnReservation_Click(sender, e);
            btnWaiting_Click(sender, e);
            
            lblMessage.Text = "The operation is complete.";
        }

        // Exit Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
