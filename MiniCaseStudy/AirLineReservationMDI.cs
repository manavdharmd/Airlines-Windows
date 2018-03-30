using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCaseStudy
{
    public partial class AirLineReservationMDI : Form
    {
        public string id=" ";
        FlightBooking fb;
        CancelBooking cb;
        UserLogin u;
        UserRegistration ur;
        Confirm cm;
        SearchFlights sf;
        public AirLineReservationMDI()
        {
            InitializeComponent();     
        }  
        private void bookFlightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (id != " ")
            {
                fb = new FlightBooking { uid = id };
                fb.MdiParent = this;
                fb.Show();
            }
            else 
            {
                MessageBox.Show("Login to continue.");
            }
            
        }
        private void cancelFlightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (id != " ")
            {
                cb = new CancelBooking{uid=id};
                cb.MdiParent = this;
                cb.Show();
            }
            else
            {
                MessageBox.Show("Login to continue.");
            }
            
            
        }
        private void existingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id == " ")
            {
                u = new UserLogin();
                u.MdiParent = this;
                u.Show();
            }
            else
            {
                MessageBox.Show("Already logged in ");
            }
        }
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id == " ")
            {
                ur = new UserRegistration();
                ur.MdiParent = this;
                ur.Show();
            }
            else
            {
                MessageBox.Show("Already Registered");
            }
            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != " ")
            {
                cm = new Confirm { uid=id};
                cm.MdiParent = this;
                cm.Show();

            }
            else
            {
                MessageBox.Show("Login to continue.");
            }
            
            
        }
        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (id != " ")
            {

                sf = new SearchFlights();
                sf.MdiParent = this;
                sf.Show();
            }
            else
            {
                MessageBox.Show("Login to continue.");
            }
            
            
        }
    }
}
