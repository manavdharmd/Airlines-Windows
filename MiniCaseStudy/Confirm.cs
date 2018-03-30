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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }
        public string uid;
        private void Confirm_Load(object sender, EventArgs e)
        {
            AirlineService ob = new AirlineService();
            List<Booking> l_book=ob.GetALLBookings(uid);
            foreach (Booking item in l_book)
            {
                listBox1.Items.Add("ReferenceId: "+item.ReferenceId+" Flight Id:"+item.FlightId+" Status:"+item.Status+" Bookseats: "+item.Seats+" TotalCost: "+item.Cost+" Travel Date:"+item.Travelon);
                
            }

        }
    }
}
