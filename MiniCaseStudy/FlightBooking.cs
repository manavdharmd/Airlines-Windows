using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using CommonLayer;
namespace MiniCaseStudy
{
    public partial class FlightBooking : Form
    {
        public FlightBooking()
        {
            InitializeComponent();
        }
        public string uid;
        Booking b_ob;
        private void btn_book_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Register Passengers" );

        }

        private void txt_seats_TextChanged(object sender, EventArgs e)
        {
            string s = txt_seats.Text;
            txt_cost.Text = (Convert.ToInt32(s) * 1200).ToString();
        }

        private void FlightBooking_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_passenger_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txt_seats.Text);
            while (s > 0)
            {
                b_ob.AddPassenger(txt_name.Text.ToString(), Convert.ToInt32(txt_age.Text));
                s--;
            }
          
        }

        private void btn_finalbook_Click(object sender, EventArgs e)
        {
            
            string status = "B";
            float cost = Convert.ToInt32(txt_seats.Text) * 1200;
            AirlineService ob = new AirlineService();
            b_ob = new Booking(uid, Convert.ToDateTime(txt_date.Text), txt_id.Text, status, Convert.ToInt32(txt_seats.Text), cost); 
            int a = ob.saveBooking(b_ob);
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
