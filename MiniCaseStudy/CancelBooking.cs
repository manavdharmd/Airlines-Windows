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
    public partial class CancelBooking : Form
    {
        public string uid;
        List<Booking> l_book;
        AirlineService a_ob = new AirlineService();
        public CancelBooking()
        {
            InitializeComponent();
        }
        private void CancelBooking_Load(object sender, EventArgs e)
        {
            
             l_book= a_ob.GetBookingsForCancel(uid);
            foreach (Booking item in l_book)
            {
                checkedListBox1.Items.Add("User Id:"+ item.UserId +" Cost: "+ item.Cost+" FlightId: "+ item.FlightId+" Reference Id "+ item.ReferenceId+"Seats: "+ item.Seats+" Date:"+item.Travelon);         
            }
            
        }
        private void btn_cancelall_Click(object sender, EventArgs e)
        {
            
             foreach (Booking item in l_book)
            {
                Booking b = new Booking(item.ReferenceId,item.UserId, item.Travelon, item.FlightId, item.Status, item.Seats, item.Cost);
                b.Cancel();
                a_ob.saveBooking(b);
                
       
            }
             MessageBox.Show("Tickets Cancelled");

        }
    }
}
